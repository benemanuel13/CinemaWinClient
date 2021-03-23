using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaWinClient.Models.ApiModels
{
    public class SubRegion
    {
        public int SubRegionID { get; set; }

        public int RegionID { get; set; }

        public string Name { get; set; }

        public virtual List<Country> Countries { get; set; }
    }
}
