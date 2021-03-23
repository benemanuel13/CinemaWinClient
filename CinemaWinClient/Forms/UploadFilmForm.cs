using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

using System.Net.Http;
using System.Net.Http.Headers;
using CinemaWinClient.Services;
using CinemaWinClient.Interfaces;
using CinemaWinClient.Models.ApiModels;
using System.Text.Json;

namespace CinemaWinClient.Forms
{
    public partial class UploadFilmForm : Form
    {
        MainForm mainForm;
        private IApiService _apiService;
        private Film film;

        private string AdminKey { get; set; }

        public UploadFilmForm(MainForm mainForm, IApiService api, Film film, string adminKey)
        {
            InitializeComponent();

            this.mainForm = mainForm;
            _apiService = api;
            this.film = film;

            AdminKey = adminKey;
        }

        private async void uploadFile_Click(object sender, EventArgs e)
        {
            string fileName = "";
            bool success = true;

            try
            {
                if (FileName.Text != "")
                {
                    string extension = Path.GetExtension(FileName.Text);
                    fileName = Guid.NewGuid() + extension;

                    long chunkSize = 10485760;

                    long bytesSent = 0;
                    byte[] bytes = new byte[chunkSize];

                    string firstText = "true";

                    using (var fileStream = File.OpenRead(FileName.Text))
                    {
                        UploadProgress.Maximum = (int)(fileStream.Length / chunkSize);
                        int read = 0;
                        bool last = false;

                        bool retry = false;

                        while (bytesSent < fileStream.Length)
                        {
                            HttpClient httpClient = new HttpClient();

                            httpClient.DefaultRequestHeaders.Add("Authorization", AdminKey);

                            httpClient.Timeout = System.Threading.Timeout.InfiniteTimeSpan;
                            HttpResponseMessage response;

                            if (!retry)
                            {
                                read = fileStream.Read(bytes, 0, (int)chunkSize);
                                last = bytesSent > (fileStream.Length - read);
                            }

                            using (var stream = new MemoryStream())
                            {
                                stream.Write(bytes, 0, read);
                                stream.Flush();

                                retry = false;

                                stream.Seek(0, SeekOrigin.Begin);

                                string lastText = "false";

                                if (last)
                                    lastText = "true";

                                var fileContent = new StreamContent(stream);
                                fileContent.Headers.Add("Filename", fileName);
                                fileContent.Headers.Add("First", firstText);
                                fileContent.Headers.Add("Last", lastText);
                                fileContent.Headers.Add("Position", bytesSent.ToString());
                                fileContent.Headers.Add("Length", read.ToString());
                                fileContent.Headers.Add("ChunkSize", chunkSize.ToString());

                                fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/octet-stream");

                                string basePath = _apiService.BasePath;

                                response = await httpClient.PostAsync(basePath + "api/Admin/PostFilmFile", fileContent);

                                if (response.IsSuccessStatusCode)
                                {
                                    string message = response.Content.ReadAsStringAsync().Result;
                                }
                                else
                                {
                                    string res = response.Content.ReadAsStringAsync().Result;

                                    DialogResult result = MessageBox.Show("Upload Interupted, Retry? : " + res, "Failure", MessageBoxButtons.YesNo);

                                    if (result == DialogResult.No)
                                    {
                                        return;
                                    }
                                    else
                                    {
                                        retry = true;
                                    }
                                }

                                firstText = "false";

                                if (!retry)
                                {
                                    bytesSent += read;
                                }

                                UploadProgress.Value = (int)(bytesSent / chunkSize);
                            }
                        }
                    }
                }
            }
            catch {
                success = false;
            }

            if (success)
            {
                UploadProgress.Value = UploadProgress.Maximum;

                MessageBox.Show("Successfully Uploaded File", "Success");

                this.film.RemoteFileName = fileName;
                this.film.Uploaded = true;

                await _apiService.PostFilm(this.film);

                await mainForm.UploadedFile(fileName);

                this.Close();
            }
            else
            {
                MessageBox.Show("Failed To Upload File", "Failure");
            }
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog.ShowDialog();

            string filename = OpenFileDialog.FileName;

            if (!string.IsNullOrEmpty(filename))
            {
                uploadFile.Enabled = true;
            }

            FileName.Text = filename;
        }
    }
}
