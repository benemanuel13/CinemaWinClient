using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaWinClient.Models.ApiModels
{
    public class Country
    {
        public int CountryID { get; set; }

        public int SubRegionID { get; set; }

        public string Name { get; set; }
        public string CountryCode { get; set; }
    }
}
