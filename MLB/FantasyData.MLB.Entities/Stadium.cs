using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.MLB.Entities
{
    public class Stadiums : List<Stadium>
    { }
    public class Stadium
    {
        public int StadiumID { get; set; }

        public bool Active { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public int? Capacity { get; set; }

        public string Surface { get; set; }

        public int? LeftField { get; set; }

        public int? MidLeftField { get; set; }

        public int? LeftCenterField { get; set; }

        public int? MidLeftCenterField { get; set; }

        public int? CenterField { get; set; }

        public int? MidRightCenterField { get; set; }

        public int? RightCenterField { get; set; }

        public int? MidRightField { get; set; }

        public int? RightField { get; set; }

        public decimal? GeoLat { get; set; }

        public decimal? GeoLong { get; set; }

        public int? Altitude { get; set; }

        public int? HomePlateDirection { get; set; }

        public string Type { get; set; }

    }

}
