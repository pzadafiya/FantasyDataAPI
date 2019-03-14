using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NBA.Entities
{
    public class Stadiums : List<Stadium>
    { }
    public class Stadium
    {
        public int StadiumID { get; set; }

        public bool Active { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public string Country { get; set; }

        public int? Capacity { get; set; }

    }

}
