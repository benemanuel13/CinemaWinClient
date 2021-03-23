using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Net.Http;
using Newtonsoft.Json;
using System.IO;

using CinemaWinClient.Extensions;
using CinemaWinClient.Models.ApiModels;
using System.Threading;
using CinemaWinClient.Interfaces;

namespace CinemaWinClient.Forms
{
    public enum FileType
    {
        Trailer,
        Poster,
        Still,
        Director
    }

    public partial class FilmDetails : Form
    {
        private Models.ApiModels.FilmDetails details;

        private string posterFile = ""; 
        private string posterUrl = "";

        private string still1File = "";
        private string still2File = "";
        private string still3File = "";

        private string directorFile = "";
        private string directorUrl = "";

        private string trailerFile = "";
        private string trailerUrl = "";

        private int currentFilmID = 0;

        private readonly IApiService _apiService;

        private string basePath = "";

        public FilmDetails(int filmID, IApiService apiService)
        {
            InitializeComponent();

            _apiService = apiService;
            basePath = _apiService.BasePath;

            GetFilmDetails(filmID);
        }

        private async void GetFilmDetails(int filmID)
        {
            currentFilmID = filmID;

            details = await _apiService.GetFilmDetails(filmID);

            FilmTitle.Text = details.Film.Title;

            if (details.PosterUrl != null && details.PosterUrl != "")
            {
                poster.Load(basePath + details.PosterUrl);
                posterUrl = basePath + details.PosterUrl;
            }

            if (details.DirectorPicUrl != null && details.DirectorPicUrl != "")
            {
                director.Load(basePath + details.DirectorPicUrl);
                directorUrl = basePath + details.DirectorPicUrl;
            }

            if (details.TrailerUrl != null && details.TrailerUrl != "")
            {
                TrailerUploaded.Text = "Yes";
            }

            Origin.Text = details.DirectorOrigin;
            Bio.Text = details.DirectorBio;

            FilmLength.Text = details.FilmLength.ToString();
            Synopsis.Text = details.Synopsis;
            FirstFilm.Checked = details.DirectorsFirstFilm;

            foreach (string screen in Enum.GetNames(typeof(Models.ApiModels.Screen)))
            {
                Screens.Items.Add(Enum.Parse<Models.ApiModels.Screen>(screen).GetDescription());
            }

            Screens.SelectedIndex = (int)details.Screen;

            int still = 0;
            
            foreach (StillUrl stillUrl in details.StillUrls)
            {
                if (still == 0)
                {
                    still1.Load(basePath + stillUrl.Url);
                    still2SelectButton.Enabled = true;
                }
                else if (still == 1)
                {
                    still2.Load(basePath + stillUrl.Url);
                    still3SelectButton.Enabled = true;
                }
                else if (still == 2)
                {
                    still3.Load(basePath + stillUrl.Url);
                }

                    still++;
                }
            }

        private void FilmDetails_Load(object sender, EventArgs e)
        {

        }

        private async void UploadFile(int filmID, string file, FileType fileType, int stillNo = -1)
        {
            if (file == "")
            {
                MessageBox.Show("You Must Provide A File To Upload.", "Invalid Input");
                return;
            }

            using (var formDataContent = new MultipartFormDataContent())
            {
                string fileName = Path.GetFileName(file);

                FileStream stream = File.OpenRead(file);
                byte[] bytes = new byte[stream.Length];

                int read = stream.Read(bytes, 0, (int)stream.Length);
                int total = read;

                while (total < stream.Length)
                {
                    read = stream.Read(bytes, total, (int)stream.Length);
                }

                stream.Close();

                formDataContent.Add(new ByteArrayContent(bytes), fileName, fileName);
                formDataContent.Add(new StringContent("\"name\":\"ben\"", Encoding.UTF8, "application/json"), "name");

                string message = await _apiService.PostFilmDetails(filmID, fileType, formDataContent);

                if (message.StartsWith("OK"))
                {
                    MessageBox.Show("Successfully Uploaded File", "Success");

                    fileName = message.Substring(2, message.Length - 2);
                }
                else
                {
                    MessageBox.Show("Failed To Upload File: " + message, "Failure");
                    return;
                }
                
                if (fileType == FileType.Poster)
                {
                    poster.Load(basePath + "/Posters/");
                }
                else if (fileType == FileType.Director)
                {
                    director.Load(basePath + "/Directors/" + fileName);
                }
                else if (fileType == FileType.Still)
                {
                    if (stillNo == 1)
                    {
                        still1.Load(basePath + "/Stills/" + fileName);
                    }
                    else if (stillNo == 2)
                    {
                        still2.Load(basePath + "/Stills/" + fileName);
                    }
                    else if (stillNo == 3)
                    {
                        still3.Load(basePath + "/Stills/" + fileName);
                    }
                }
                else if (fileType == FileType.Trailer)
                {
                    TrailerUploaded.Text = "Yes";
                }
            }

            GetFilmDetails(currentFilmID);
        }

        private void selectPosterFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog.ShowDialog();

            string filename = OpenFileDialog.FileName;

            posterFile = filename;

            uploadPosterButton.Enabled = true;
        }

        private void uploadPosterButton_Click(object sender, EventArgs e)
        {
            UploadFile(details.FilmID, posterFile, FileType.Poster);
        }

        private void selectDirectorFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog.ShowDialog();

            string filename = OpenFileDialog.FileName;

            directorFile = filename;

            uploadDirectorButton.Enabled = true;
        }

        private void uploadDirectorButton_Click(object sender, EventArgs e)
        {
            UploadFile(details.FilmID, directorFile, FileType.Director);
        }

        private void saveDirectorButton_Click(object sender, EventArgs e)
        {
            details.DirectorOrigin = Origin.Text;
            details.CountryOfOrigin = Origin.Text;

            details.DirectorBio = Bio.Text;

            UpdateDetails();
        }

        private async void UpdateDetails()
        {
            var resp = await _apiService.PostUpdateFilmDetails(details);

            if (resp)
            {
                MessageBox.Show("Successfully Updated Film Details.", "Success");
            }
            else
            {
                MessageBox.Show("Failed To Update Film Details.", "Failure");
                return;
            }
        }

        private void saveFilmDetailsButton_Click(object sender, EventArgs e)
        {
            try
            {
                details.FilmLength = int.Parse(FilmLength.Text);
            }
            catch
            {
                details.FilmLength = 0;
            }

            details.Synopsis = Synopsis.Text;
            details.DirectorsFirstFilm = FirstFilm.Checked;
            details.Screen = (Models.ApiModels.Screen)Screens.SelectedIndex;

            UpdateDetails();
        }

        private void still1SelectButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog.ShowDialog();

            string filename = OpenFileDialog.FileName;

            still1File = filename;

            still1UploadtButton.Enabled = true;
        }

        private void still2SelectButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog.ShowDialog();

            string filename = OpenFileDialog.FileName;

            still2File = filename;

            still2UploadtButton.Enabled = true;
        }

        private void still3SelectButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog.ShowDialog();

            string filename = OpenFileDialog.FileName;

            still3File = filename;

            still3UploadtButton.Enabled = true;
        }

        private void still1UploadtButton_Click(object sender, EventArgs e)
        {
            UploadFile(details.FilmID, still1File, FileType.Still, 1);
            still2SelectButton.Enabled = true;
        }

        private void still2UploadtButton_Click(object sender, EventArgs e)
        {
            UploadFile(details.FilmID, still2File, FileType.Still, 2);
            still3SelectButton.Enabled = true;
        }

        private void still3UploadtButton_Click(object sender, EventArgs e)
        {
            UploadFile(details.FilmID, still3File, FileType.Still, 3);
        }

        private void selectTrailerButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog.ShowDialog();

            string filename = OpenFileDialog.FileName;

            trailerFile = filename;

            uploadTrailerButton.Enabled = true;
        }

        private void uploadTrailerButton_Click(object sender, EventArgs e)
        {
            UploadFile(details.FilmID, trailerFile, FileType.Trailer);
        }
    }
}
