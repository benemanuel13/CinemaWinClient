using CinemaWinClient.Interfaces;
using CinemaWinClient.Models.ApiModels;
using Microsoft.Azure.Management.Media;
using Microsoft.Azure.Management.Media.Models;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Microsoft.Rest;
using Microsoft.Rest.Azure.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaWinClient.Forms
{
    public partial class EncodeFilmForm : Form
    {
        private readonly IApiService _apiService;
        private readonly IConfig _config;

        private const string AdaptiveStreamingTransformName = "MyTransformWithAdaptiveStreamingPreset";
        private string Issuer = "myIssuer";
        private string Audience = "myAudience";
        private string ContentKeyPolicyName = "SharedContentKeyPolicyUsedByAllAssets";

        private Film film;
        private string basePath;

        public EncodeFilmForm(Film film, IApiService api, IConfig config)
        {
            InitializeComponent();

            _apiService = api;
            _config = config;

            this.film = film;
            basePath = api.BasePath;

            StartEncoding();
        }

        private async void StartEncoding()
        {
            await CreateAsset(film.AssetName, basePath + _config.Values.GetSection("UploadPath").Value + "/" + film.RemoteFileName);
        }

        public async Task CreateAsset(string name, string Url)
        {
            IAzureMediaServicesClient azureclient = await CreateMediaServicesClientAsync();

            string uniqueness = Guid.NewGuid().ToString("N");
            string jobName = $"job-{uniqueness}";

            Asset outputAsset = await CreateOutputAssetAsync(azureclient, _config.Values.GetSection("ResourceGroup").Value, _config.Values.GetSection("AccountName").Value, name);

            if (outputAsset == null)
            {
                MessageBox.Show("Asset Already Exists With This Name.", "Invalid Asset Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Job job = await SubmitJobAsync(azureclient, _config.Values.GetSection("ResourceGroup").Value, _config.Values.GetSection("AccountName").Value, AdaptiveStreamingTransformName, outputAsset.Name, jobName, Url);
            job = await WaitForJobToFinishAsync(azureclient, _config.Values.GetSection("ResourceGroup").Value, _config.Values.GetSection("AccountName").Value, AdaptiveStreamingTransformName, jobName);

            if (job.State == JobState.Finished)
            {
                await azureclient.Jobs.DeleteAsync(_config.Values.GetSection("ResourceGroup").Value, _config.Values.GetSection("AccountName").Value, AdaptiveStreamingTransformName, jobName);

                await _apiService.DeleteFilmFile(film.FilmID);

                await CreateStreamingLocatorAsync(azureclient, _config.Values.GetSection("ResourceGroup").Value, _config.Values.GetSection("AccountName").Value, name, name + "Locator", ContentKeyPolicyName);

                film.AssetCreated = true;

                film.Source = GetSource(azureclient, film);

                await _apiService.PostFilm(film);

                MessageBox.Show("Successfully Created Asset", "Success");
            }
            else
            {
                await azureclient.Jobs.DeleteAsync(_config.Values.GetSection("ResourceGroup").Value, _config.Values.GetSection("AccountName").Value, AdaptiveStreamingTransformName, jobName);
                await azureclient.Assets.DeleteAsync(_config.Values.GetSection("ResourceGroup").Value, _config.Values.GetSection("AccountName").Value, film.AssetName);

                MessageBox.Show("Failed To Create Asset", "Failure");

                this.Close();

                return;
            }

            this.Close();
        }

        private string GetSource(IAzureMediaServicesClient client, Film film)
        {
            ListPathsResponse paths = client.StreamingLocators.ListPathsAsync(_config.Values.GetSection("ResourceGroup").Value, _config.Values.GetSection("AccountName").Value, film.AssetName + "Locator").Result;
            StreamingEndpoint streamingEndpoint = client.StreamingEndpoints.GetAsync(_config.Values.GetSection("ResourceGroup").Value, _config.Values.GetSection("AccountName").Value, "default").Result;

            string dashPath = "";

            foreach (StreamingPath path in paths.StreamingPaths)
            {
                UriBuilder uriBuilder = new UriBuilder();
                uriBuilder.Scheme = "https";
                uriBuilder.Host = streamingEndpoint.HostName;

                // Look for just the DASH path and generate a URL for the Azure Media Player to playback the content with the AES token to decrypt.
                // Note that the JWT token is set to expire in 1 hour. 
                if (path.StreamingProtocol == StreamingPolicyStreamingProtocol.Dash)
                {
                    uriBuilder.Path = path.Paths[0];

                    dashPath = uriBuilder.ToString();
                }
            }

            return dashPath;
        }
        private static async Task<StreamingLocator> CreateStreamingLocatorAsync(
            IAzureMediaServicesClient client,
            string resourceGroup,
            string accountName,
            string assetName,
            string locatorName,
            string contentPolicyName)
        {
            StreamingLocator locator = await client.StreamingLocators.CreateAsync(
                resourceGroup,
                accountName,
                locatorName,
                new StreamingLocator
                {
                    AssetName = assetName,
                    StreamingPolicyName = PredefinedStreamingPolicy.ClearKey,
                    DefaultContentKeyPolicyName = contentPolicyName
                });

            return locator;
        }

        private async Task<Microsoft.Azure.Management.Media.Models.Asset> CreateOutputAssetAsync(IAzureMediaServicesClient client, string resourceGroupName, string accountName, string assetName)
        {
            Microsoft.Azure.Management.Media.Models.Asset outputAsset = await client.Assets.GetAsync(resourceGroupName, accountName, assetName);
            Microsoft.Azure.Management.Media.Models.Asset asset = new Microsoft.Azure.Management.Media.Models.Asset();
            string outputAssetName = assetName;

            if (outputAsset != null)
            {
                return null;
            }

            return await client.Assets.CreateOrUpdateAsync(resourceGroupName, accountName, outputAssetName, asset);
        }

        private async Task<Job> SubmitJobAsync(IAzureMediaServicesClient client,
            string resourceGroup,
            string accountName,
            string transformName,
            string outputAssetName,
            string jobName,
            string url)
        {
            JobInputHttp jobInput =
                new JobInputHttp(files: new[] { url });

            JobOutput[] jobOutputs =
            {
                new JobOutputAsset(outputAssetName),
            };

            Job job = await client.Jobs.CreateAsync(
                resourceGroup,
                accountName,
                transformName,
                jobName,
                new Job
                {
                    Input = jobInput,
                    Outputs = jobOutputs,
                });

            return job;
        }

        private async Task<Job> WaitForJobToFinishAsync(IAzureMediaServicesClient client,
            string resourceGroupName,
            string accountName,
            string transformName,
            string jobName)
        {
            const int SleepIntervalMs = 5 * 1000;

            Job job = null;

            do
            {
                job = await client.Jobs.GetAsync(resourceGroupName, accountName, transformName, jobName);

                await Task.Run(() => { });

                for (int i = 0; i < job.Outputs.Count; i++)
                {
                    JobOutput output = job.Outputs[i];

                    //Update UI
                    statusLabel.Text = output.State.ToString();
                    
                    if (output.State == JobState.Processing)
                    {
                        progressLabel.Text = output.Progress.ToString("##0");
                        encodingProgress.Value = output.Progress;
                    }
                }

                if (job.State != JobState.Finished && job.State != JobState.Error && job.State != JobState.Canceled)
                {
                    await Task.Delay(SleepIntervalMs);
                }
            }
            while (job.State != JobState.Finished && job.State != JobState.Error && job.State != JobState.Canceled);

            return job;
        }

        private async Task<ServiceClientCredentials> GetCredentialsAsync()
        {
            ClientCredential clientCredential = new ClientCredential(_config.Values.GetSection("AadClientId").Value, _config.Values.GetSection("AadSecret").Value);
            return await ApplicationTokenProvider.LoginSilentAsync(_config.Values.GetSection("AadTenantId").Value, clientCredential, ActiveDirectoryServiceSettings.Azure);
        }

        private async Task<IAzureMediaServicesClient> CreateMediaServicesClientAsync()
        {
            var credentials = await GetCredentialsAsync();

            return new AzureMediaServicesClient(new Uri(_config.Values.GetSection("ArmEndpoint").Value), credentials)
            {
                SubscriptionId = _config.Values.GetSection("SubscriptionId").Value,
            };
        }
    }
}
