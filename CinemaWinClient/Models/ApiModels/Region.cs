using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaWinClient.Models.ApiModels
{
    public class Region
    {
        public int RegionID { get; set; }

        public string Name { get; set; }

        public virtual List<SubRegion> SubRegions { get; set; }
    }
}
