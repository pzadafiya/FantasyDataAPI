using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Soccer.Entities
{
    public class Areas : List<Area>
    { }

    public class Area
    {
        public int AreaId { get; set; }
        public string CountryCode { get; set; }
        public string Name { get; set; }
        public List<Competition> Competitions { get; set; }
    }
}
