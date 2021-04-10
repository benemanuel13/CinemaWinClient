using CinemaWinClient.Models.ApiModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Linq;
using CinemaWinClient.Interfaces;
using System.Threading.Tasks;

namespace CinemaWinClient.Forms
{
    public partial class FilmForm : Form
    {
        private bool newFilm = true;
        private Film film = null;

        private bool checking = false;

        private IApiService _apiService;
        public MainForm parentForm { get; set; }

        private BindingList<FilmCategory> catBinding;
        private BindingSource catBindingSource;

        private List<Country> BlockedCountries;

        public FilmForm()
        {
            InitializeComponent();
        }

        public FilmForm(IApiService api, MainForm mainForm, bool collection, Film film = null)
        {
            InitializeComponent();

            _apiService = api;
            parentForm = mainForm;

            filmDate.Format = DateTimePickerFormat.Long;

            filmTime.CustomFormat = "HH:mm";
            filmTime.ShowUpDown = true;
            filmTime.Format = DateTimePickerFormat.Custom;

            filmRating.DataSource = Enum.GetValues(typeof(Rating));
            this.film = film;

            GetFilmCategories();

            if (film.FilmID == 0)
            {
                this.Text = "Add New Film";
                newFilm = true;
            }
            else
            {
                this.Text = "Edit Film - " + film.Title;
                newFilm = false;

                filmTitle.Text = film.Title;
                filmDirector.Text = film.Director;
                filmRating.SelectedItem = film.Rating;

                filmDate.Value = film.Showing;
                filmTime.Value = film.Showing;

                var index = filmCategories.Items;

                filmCategories.SelectedItem = catBinding.Where(b => b.FilmCategoryID == film.FilmCategory.FilmCategoryID).First();

                editFilmExtras.Enabled = true;
            }

            if (collection)
            {
                editFilmExtras.Visible = false;
                filmCategories.Enabled = false;
            }

            this.film = film;

            GetBlockedFilms();
        }

        private async void GetBlockedFilms()
        {
            BlockedCountries = await _apiService.GetBlockedFilms(film.FilmID);
        }

        private void GetFilmCategories()
        {
            catBinding = Task.Run(() =>  _apiService.GetFilmCategories()).Result;

            catBindingSource = new BindingSource();
            catBindingSource.DataSource = catBinding;

            filmCategories.DataSource = catBindingSource;
            filmCategories.DisplayMember = "Description";
        }

        private async void FilmForm_Load(object sender, EventArgs e)
        {
            var node = geoBlocks.Nodes.Add("All Regions");
            node.Tag = "ROOTND0";
            geoBlocks.AfterSelect += GeoBlocks_AfterSelect;
            geoBlocks.AfterCheck += GeoBlocks_AfterCheck;
            
            node.Expand();

            List<Models.ApiModels.Region> regions = await _apiService.GetRegions();

            foreach (var region in regions)
            {
                var regionNode = node.Nodes.Add(region.Name);
                regionNode.Tag = "REGION" + region.RegionID;
            }
        }

        private async void GeoBlocks_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (checking)
            {
                return;
            }

            var node = e.Node;

            if (node.Nodes.Count == 0)
            {
                if (node.Tag.ToString().StartsWith("COUNTR"))
                {
                    string idStr = node.Tag.ToString().Substring(6, node.Tag.ToString().Length - 6);
                    int id = int.Parse(idStr);

                    if (e.Node.Checked)
                    {
                        BlockedCountries.Add(new Country() { 
                            CountryID = id
                        });
                    }
                    else
                    {
                        var blocked = BlockedCountries.Where(bc => bc.CountryID == id).FirstOrDefault();

                        BlockedCountries.Remove(blocked);
                    }

                    return;
                }

                await ExpandChildren(node);
            }
            else if (node.Tag.ToString().StartsWith("ROOTND0"))
            {
                await ExpandChildren(node);
            }

            checking = true;

            CheckChildren(node, node.Checked);

            checking = false;
        }

        private async Task ExpandChildren(TreeNode node)
        {
            await SelectNode(node);
            node.Expand();

            foreach (TreeNode child in node.Nodes)
            {
                await ExpandChildren(child);
            }
        }

        private void CheckChildren(TreeNode node, bool check)
        {
            foreach (TreeNode subnode in node.Nodes)
            {
                subnode.Checked = check;

                CheckChildren(subnode, check);
            }
        }

        private async void GeoBlocks_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var node = ((TreeView)sender).SelectedNode;

            await SelectNode(node);
        }

        private async Task SelectNode(TreeNode node)
        {
            if (node.Nodes.Count == 0)
            {
                if (node.Tag.ToString().StartsWith("ROOTNO"))
                {
                    return;
                }
                else if (node.Tag.ToString().StartsWith("REGION"))
                {
                    int id = GetNodeID(node.Tag.ToString());

                    List<SubRegion> subRegions = await _apiService.GetSubRegions(id);

                    foreach (var subRegion in subRegions)
                    {
                        var regionNode = node.Nodes.Add(subRegion.Name);
                        regionNode.Tag = "SUBREG" + subRegion.SubRegionID;
                    }
                }
                else if (node.Tag.ToString().StartsWith("SUBREG"))
                {
                    int id = GetNodeID(node.Tag.ToString());

                    List<Country> countries = await _apiService.GetCountries(id);

                    foreach (var country in countries)
                    {
                        var countryNode = node.Nodes.Add(country.Name);
                        countryNode.Tag = "COUNTR" + country.CountryID;

                        var blocked = BlockedCountries.Where(bc => bc.CountryID == country.CountryID).FirstOrDefault();

                        if (blocked != null)
                        {
                            checking = true;

                            countryNode.Checked = true;

                            checking = false;
                        }
                    }
                }
                else if (node.Tag.ToString().StartsWith("COUNTR"))
                {
                    int id = GetNodeID(node.Tag.ToString());

                }
            }
        }

        private int GetNodeID(string tag)
        {
            string idStr = tag.Substring(6, tag.Length - 6);

            return int.Parse(idStr);
        }

        private async void saveFilmDetails_Click(object sender, EventArgs e)
        {
            film.Title = filmTitle.Text;
            film.Director = filmDirector.Text;
            film.Rating = (Rating)filmRating.SelectedItem;
            film.Showing = filmDate.Value.Date + filmTime.Value.TimeOfDay;
            film.FilmCategoryID = ((FilmCategory)filmCategories.SelectedItem).FilmCategoryID;

            Film newFilm = await _apiService.PostFilm(film);

            parentForm.UpdateFilmList(newFilm);

            this.Close();
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editFilmExtras_Click(object sender, EventArgs e)
        {
            FilmDetails form = new FilmDetails(film.FilmID, _apiService);

            form.ShowDialog();
        }

        private void filmCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox box = (ComboBox)sender;

            FilmCategory cat = (FilmCategory)box.SelectedItem;

            if(cat != null)
                film.FilmCategoryID = cat.FilmCategoryID;
        }

        private async void geoConfirm_Click(object sender, EventArgs e)
        {
            await _apiService.PostBlockedCountries(film.FilmID, BlockedCountries);
        }
    }
}
