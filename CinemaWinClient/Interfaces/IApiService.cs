using CinemaWinClient.Forms;
using CinemaWinClient.Models.ApiModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CinemaWinClient.Interfaces
{
    public interface IApiService
    {
        string BasePath { get; set; }

        string AdminKey { get; set; }

        Task<Film> GetFilm(int id);
        Task<BindingList<FilmCategory>> GetFilmCategories();
        Task<FilmCategory> PostFilmCategory(FilmCategory cat);

        Task<Film> PostFilm(Film film);

        Task<BindingList<FilmCollection>> GetFilmCollections();
        Task<FilmCollection> PostFilmCollection(FilmCollection col);

        Task<List<Film>> GetFilms(int filmCollectionID);

        Task<bool> PostCountry(Country cou);

        Task<List<Region>> GetRegions();
        Task<List<SubRegion>> GetSubRegions(int id);
        Task<List<Country>> GetCountries(int id);

        Task<Models.ApiModels.FilmDetails> GetFilmDetails(int id);

        Task DeleteFilmFile(int filmID);

        Task<string> PostFilmDetails(int filmID, FileType fileType, MultipartFormDataContent content);

        Task<bool> PostUpdateFilmDetails(Models.ApiModels.FilmDetails details);

        Task<List<Country>> GetBlockedFilms(int id);
        Task<bool> PostBlockedCountries(int id, List<Country> countries);
    }
}
