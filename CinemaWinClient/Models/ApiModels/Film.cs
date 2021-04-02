﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWinClient.Models.ApiModels
{
    public enum Rating
    {
        [Description("Universal")]
        Universal,
        [Description("Parental Guidence")]
        ParentalGuidence
    }

    public class Film
    {
        public int FilmID { get; set; }

        public bool Uploaded { get; set; }
        public bool AssetCreated { get; set; }

        public string Title { get; set; }

        public DateTime Showing { get; set; }

        public int? FilmCollectionID { get; set; }
        public FilmCollection FilmCollection { get; set; }

        public Rating Rating { get; set; }

        public int FilmCategoryID { get; set; }
        public FilmCategory FilmCategory { get; set; }

        public string RemoteFileName { get; set; }

        public string AssetName { get; set; }

        public string Source { get; set; }

        public int Booked { get; set; }
        public int Watched { get; set; }
    }
}
