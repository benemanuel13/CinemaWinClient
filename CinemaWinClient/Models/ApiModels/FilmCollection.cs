using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWinClient.Models.ApiModels
{
    public class FilmCollection
    {
        public int FilmCollectionID { get; set; }

        public int FilmID { get; set; }

        public Film Film { get; set; }

        public string Name { get; set; }

        public virtual List<Film> Films { get; set; }
    }
}
