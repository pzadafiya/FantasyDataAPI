using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.MLB.Entities
{
    public class Seasons : List<Season>
    { }
    public class Season
    {
        public int season { get; set; }

        public DateTime? RegularSeasonStartDate { get; set; }

        public DateTime? PostSeasonStartDate { get; set; }

        public string SeasonType { get; set; }

        public string ApiSeason { get; set; }

    }

}
