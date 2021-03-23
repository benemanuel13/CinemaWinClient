using CinemaWinClient.Forms;
using CinemaWinClient.Interfaces;
using CinemaWinClient.Models.ApiModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CinemaWinClient.Services
{
    public class ApiService : IApiService
    {
        public string AdminKey { get; set; }

#if DEBUG
        //public string BasePath { get; set; } = "https://6a8071e3c424.ngrok.io/";
        public string BasePath { get; set; } = "https://ramsgatedigitalcinema.co.uk/";
#else
        public string BasePath { get; set; } = "https://ramsgatedigitalcinema.co.uk/";
#endif

        #region ExternalMethods

        public async Task<Film> GetFilm(int id)
        {
            Film film = await ApiGet<Film>(BasePath + "api/Admin/GetFilm", id);

            return film;
        }

        public async Task<BindingList<FilmCategory>> GetFilmCategories()
        {
            BindingList<FilmCategory> cats = await ApiGet<BindingList<FilmCategory>>(BasePath + "api/Admin/GetFilmCategories");

            return cats;
        }

        public async Task<BindingList<FilmCollection>> GetFilmCollections()
        {
            BindingList<FilmCollection> cols = await ApiGet<BindingList<FilmCollection>>(BasePath + "api/Admin/GetFilmCollections");

            return cols;
        }

        public async Task<Film> PostFilm(Film film)
        {
            Film newFilm = await ApiComplexPost<Film, Film>(BasePath + "api/Admin/PostFilm", film);

            return newFilm;
        }

        public async Task<FilmCategory> PostFilmCategory(FilmCategory cat)
        {
            FilmCategory newCat = await ApiComplexPost<FilmCategory, FilmCategory>(BasePath + "api/Admin/PostFilmCategory", cat);

            return newCat;
        }

        public async Task<FilmCollection> PostFilmCollection(FilmCollection col)
        {
            FilmCollection newCol = await ApiComplexPost<FilmCollection, FilmCollection>(BasePath + "api/Admin/PostFilmCollection", col);

            return newCol;
        }

        public async Task<List<Film>> GetFilms(int filmCollectionID = 0)
        {
            List<Film> films = await ApiGet<List<Film>>(BasePath + "api/Admin/GetFilms?id=" + filmCollectionID);

            return films;
        }

        public async Task<bool> PostCountry(Country cou)
        {
            bool res = await ApiSimplePost<Country>(BasePath + "api/Values/PostCountry", cou);

            return res;
        }

        public async Task<List<Region>> GetRegions()
        {
            List<Region> res = await ApiGet<List<Region>>(BasePath + "api/Admin/GetRegions");

            return res;
        }

        public async Task<List<SubRegion>> GetSubRegions(int id)
        {
            List<SubRegion> res = await ApiGet<List<SubRegion>>(BasePath + "api/Admin/GetSubRegions", id);

            return res;
        }

        public async Task<List<Country>> GetCountries(int id)
        {
            List<Country> res = await ApiGet<List<Country>>(BasePath + "api/Admin/GetCountries", id);

            return res;
        }

        public async Task<Models.ApiModels.FilmDetails> GetFilmDetails(int id)
        {
            Models.ApiModels.FilmDetails details = await ApiGet<Models.ApiModels.FilmDetails>(BasePath + "api/Admin/GetFilmDetails", id);

            return details;
        }

        public async Task<string> PostFilmDetails(int filmID, FileType fileType, MultipartFormDataContent content)
        {
            string message = await ApiFilePost(BasePath + "api/Admin/PostFile", filmID, fileType, content);

            return message;
        }

        public async Task<bool> PostUpdateFilmDetails(Models.ApiModels.FilmDetails details)
        {
            var resp = await ApiSimplePost<Models.ApiModels.FilmDetails>(BasePath + "api/Admin/UpdateFilmDetails", details);

            return resp;
        }



        #endregion

        #region ApiCalls

        private async Task<T> ApiGet<T>(string url)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", AdminKey);

            var resp = await client.GetAsync(url);

            if (resp.IsSuccessStatusCode)
            {
                string json = await resp.Content.ReadAsStringAsync();

                T ret = JsonConvert.DeserializeObject<T>(json);
                return ret;
            }

            return default(T);
        }

        private async Task<T> ApiGet<T>(string url, int id)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", AdminKey);

            var resp = await client.GetAsync(url + "?id=" + id);

            if (resp.IsSuccessStatusCode)
            {
                string json = await resp.Content.ReadAsStringAsync();

                T ret = JsonConvert.DeserializeObject<T>(json);
                return ret;
            }

            return default(T);
        }

        private async Task<string> ApiFilePost(string url, int filmID, FileType fileType, MultipartFormDataContent formDataContent)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", AdminKey);

            client.Timeout = System.Threading.Timeout.InfiniteTimeSpan;

            HttpResponseMessage response = await client.PostAsync(url + "?id=" + filmID + "&fileType=" + (int)fileType, formDataContent);
            string message = response.Content.ReadAsStringAsync().Result;

            return message;
        }

        private async Task<T> ApiComplexPost<T, V>(string url, V obj)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", AdminKey);

            string objjson = JsonConvert.SerializeObject(obj);
            StringContent content = new StringContent(objjson, Encoding.UTF8, "application/json");

            var resp = await client.PostAsync(url, content);

            if (resp.IsSuccessStatusCode)
            {
                string json = await resp.Content.ReadAsStringAsync();

                T ret = JsonConvert.DeserializeObject<T>(json);
                return ret;
            }

            return default(T);
        }

        private async Task<bool> ApiSimplePost<V>(string url, V obj)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", AdminKey);

            string objjson = JsonConvert.SerializeObject(obj);
            StringContent content = new StringContent(objjson, Encoding.UTF8, "application/json");

            var resp = await client.PostAsync(url, content);

            if (resp.IsSuccessStatusCode)
            {
                return true;
            }

            return false;
        }

        #endregion
    }
}
