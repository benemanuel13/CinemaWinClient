using CinemaWinClient.Interfaces;
using CinemaWinClient.Models.ApiModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Linq;
using System.Threading.Tasks;
using CinemaWinClient.Extensions;
using Newtonsoft.Json.Linq;
using System.IO;

namespace CinemaWinClient.Forms
{
    public partial class MainForm : Form
    {
        private readonly IApiService _apiService;
        private readonly IConfig _config;

        private BindingList<FilmCategory> catBinding;
        private BindingSource catBindingSource;

        private BindingList<FilmCollection> colBinding;
        private BindingSource colBindingSource;

        private BindingList<FilmCollection> colDropBinding;
        private BindingSource colDropBindingSource;

        private List<Film> theFilms;

        private bool newCategory = false;
        private bool newCollection = false;

        private int filmSortColumn = 0;

        public MainForm(IApiService apiService, IConfig config)
        {
            _apiService = apiService;
            _config = config;

            _apiService.AdminKey = _config.Values.GetSection("AdminKey").Value;

            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            //Film Categories Binding
            catBinding = await _apiService.GetFilmCategories();

            catBindingSource = new BindingSource();
            catBindingSource.DataSource = catBinding;
            
            filmCategories.DataSource = catBindingSource;
            filmCategories.DisplayMember = "Description";

            //Film Collections Binding
            colBinding = await _apiService.GetFilmCollections();

            colBindingSource = new BindingSource();
            colBindingSource.DataSource = colBinding;

            filmCollections.DataSource = colBindingSource;
            filmCollections.DisplayMember = "Name";

            colDropBinding = await _apiService.GetFilmCollections();
            colDropBinding.Insert(0, new FilmCollection() { 
                FilmCollectionID = 0,
                Name = "(none)"
            });

            colDropBindingSource = new BindingSource();
            colDropBindingSource.DataSource = colDropBinding;

            filmCollectionDropdown.DataSource = colDropBindingSource;
            filmCollectionDropdown.DisplayMember = "Name";

            filmCollectionDropdown.SelectedIndex = 0;

            await ShowFilms(0);
        }

        private async Task ShowFilms(int filmCollectionID, int sortColumn = 0)
        {
            theFilms = await _apiService.GetFilms(filmCollectionID);

            if (sortColumn == 1)
            {
                theFilms = theFilms.OrderBy(f => f.Rating).ToList();
            }
            else if (sortColumn == 2)
            {
                theFilms = theFilms.OrderBy(f => f.Showing).ToList();
            }
            else if (sortColumn == 3)
            {
                theFilms = theFilms.OrderBy(f => f.AssetCreated).ToList();
            }

            films.Items.Clear();

            foreach (var film in theFilms)
            {
                var item = films.Items.Add(film.Title);

                item.SubItems.Add(film.Rating.GetDescription());
                item.SubItems.Add(film.Showing.ToString("dd MMM yyyy HH:mm"));
                item.SubItems.Add(film.Uploaded ? "Yes" : "No");
                item.SubItems.Add(film.AssetCreated ? "Yes" : "No");
            }
        }

        private void filmCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox box = (ListBox)sender;

            FilmCategory cat = (FilmCategory)box.SelectedItem;

            filmCategory.Text = cat.Description;
            isViewable.Checked = cat.IsViewable;
            newCategory = false;

            saveCategory.Enabled = false;
            saveCategory.Text = "Update";
        }

        private void newFilmCategory_Click(object sender, EventArgs e)
        {
            filmCategory.Text = "";
            isViewable.Checked = false;
            newCategory = true;

            saveCategory.Enabled = false;
            saveCategory.Text = "Save";
        }

        private void filmCategory_TextChanged(object sender, EventArgs e)
        {
            saveCategory.Enabled = true;
        }

        private void cancelFilmCategory_Click(object sender, EventArgs e)
        {
            filmCategory.Text = "";
            saveCategory.Enabled = false;
        }

        private async void saveCategory_Click(object sender, EventArgs e)
        {
            FilmCategory cat = null;

            if (newCategory)
            {
                cat = new FilmCategory()
                {
                    Description = filmCategory.Text,
                    IsViewable = isViewable.Checked
                };

                catBinding.Add(cat);
            }
            else
            {
                cat = (FilmCategory)filmCategories.SelectedItem;
                cat.Description = filmCategory.Text;
                cat.IsViewable = isViewable.Checked;
            }

            var newcat = await _apiService.PostFilmCategory(cat);

            if (newCategory)
            {
                cat = catBinding.Where(fc => fc.FilmCategoryID == 0).First();

                cat.FilmCategoryID = newcat.FilmCategoryID;
                cat.Description = newcat.Description;

                filmCategories.SelectedIndex = filmCategories.Items.Count - 1;
            }
            else
            {
                catBinding.Where(fc => fc.FilmCategoryID == cat.FilmCategoryID).First().Description = newcat.Description;
                catBindingSource.ResetBindings(true);
            }

            saveCategory.Enabled = false;
        }

        private void newFilmCollection_Click(object sender, EventArgs e)
        {
            filmCollection.Text = "";
            newCollection = true;

            saveCollection.Enabled = false;
            saveCollection.Text = "Save";
        }

        private async void saveCollection_Click(object sender, EventArgs e)
        {
            FilmCollection col = null;

            if (newCategory)
            {
                col = new FilmCollection()
                {
                    Name = filmCollection.Text
                };

                colBinding.Add(col);
            }
            else
            {
                col = (FilmCollection)filmCollections.SelectedItem;
                col.Name = filmCollection.Text;
            }

            var newcol = await _apiService.PostFilmCollection(col);

            if (newCollection)
            {
                col = colBinding.Where(fc => fc.FilmCollectionID == 0).First();

                col.FilmCollectionID = newcol.FilmCollectionID;
                col.Name = newcol.Name;

                filmCollections.SelectedIndex = filmCollections.Items.Count - 1;
            }
            else
            {
                colBinding.Where(fc => fc.FilmCollectionID == col.FilmCollectionID).First().Name = newcol.Name;
                colBindingSource.ResetBindings(true);
            }

            saveCollection.Enabled = false;
        }

        private void cancelFilmCollection_Click(object sender, EventArgs e)
        {
            filmCollection.Text = "";
            saveCollection.Enabled = false;
        }

        private void filmCollection_TextChanged(object sender, EventArgs e)
        {
            saveCollection.Enabled = true;
        }

        private void filmCollections_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox box = (ListBox)sender;

            FilmCollection col = (FilmCollection)box.SelectedItem;

            filmCollection.Text = col.Name;
            newCollection = false;

            saveCollection.Enabled = false;
            saveCollection.Text = "Update";
        }

        private void addFilm_Click(object sender, EventArgs e)
        {
            Film newFilm = new Film() { 
                Rating= Rating.Universal,
                Showing = DateTime.Parse("03/06/2021 17:00"),
                AssetCreated = false
            };

            FilmCollection col = (FilmCollection)filmCollectionDropdown.SelectedItem;

            if (col.FilmCollectionID != 0)
            {
                newFilm.FilmCollectionID = col.FilmCollectionID;
            }

            FilmForm form = new FilmForm(_apiService, this, false, newFilm);
            form.ShowDialog();
        }

        private void films_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView list = (ListView)sender;

            editFilm.Enabled = true;

            Film film = theFilms[list.SelectedItems[0].Index];

            if (!film.Uploaded)
            {
                uploadFilm.Enabled = true;
                createFilmAsset.Enabled = false;
            }
            else if (!film.AssetCreated)
            {
                uploadFilm.Enabled = false;
                createFilmAsset.Enabled = true;
            }
            else
            {
                uploadFilm.Enabled = false;
                createFilmAsset.Enabled = false;
            }
        }

        private async void filmCollectionDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox box = (ComboBox)sender;

            FilmCollection col = (FilmCollection)box.SelectedItem;

            await ShowFilms(col.FilmCollectionID);
        }

        private void editFilm_Click(object sender, EventArgs e)
        {
            Film film = theFilms[films.SelectedItems[0].Index];

            FilmForm form = new FilmForm(_apiService, this, false, film);
            form.ShowDialog();
        }

        private async void films_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            FilmCollection col = (FilmCollection)filmCollectionDropdown.SelectedItem;

            filmSortColumn = e.Column;

            await ShowFilms(col.FilmCollectionID, e.Column);
        }

        public async void UpdateFilmList(Film film)
        {
            FilmCollection col = (FilmCollection)filmCollectionDropdown.SelectedItem;

            await ShowFilms(col.FilmCollectionID, filmSortColumn);
        }

        private async void populateCountries_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\JsonFiles\\json1.json";

            JObject obj = JObject.Parse(File.ReadAllText(path));

            foreach (JProperty prop in obj.Properties())
            {
                await _apiService.PostCountry(new Country() { 
                    CountryCode = prop.Name,
                    Name = prop.Value.ToString()
                });
            }
        }

        private void isViewable_CheckedChanged(object sender, EventArgs e)
        {
            saveCategory.Enabled = true;
        }

        private async void editCollection_Click(object sender, EventArgs e)
        {
            FilmCollection col = (FilmCollection)filmCollectionDropdown.SelectedItem;

            Film film = await _apiService.GetFilm(col.FilmID);

            FilmForm form = new FilmForm(_apiService, this, true, film);
            form.ShowDialog();
        }

        private void uploadFilm_Click(object sender, EventArgs e)
        {
            Film film = theFilms[films.SelectedItems[0].Index];

            UploadFilmForm form = new UploadFilmForm(this, _apiService, film, _config.Values.GetSection("AdminKey").Value);

            form.ShowDialog();
        }

        public async Task UploadedFile(string fileName)
        {
            theFilms[films.SelectedItems[0].Index].Uploaded = true;
            theFilms[films.SelectedItems[0].Index].RemoteFileName = fileName;

            uploadFilm.Enabled = false;
            createFilmAsset.Enabled = true;

            FilmCollection col = (FilmCollection)filmCollectionDropdown.SelectedItem;

            await ShowFilms(col.FilmCollectionID, filmSortColumn);
        }
    }
}
