using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWinClient.Models.ApiModels
{
    public class FilmCategory
    {
        public int FilmCategoryID { get; set; }

        public string Description { get; set; }

        public bool IsViewable { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
