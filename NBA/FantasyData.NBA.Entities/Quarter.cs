using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NBA.Entities
{
    public class Quarters : List<Quarter>
    { }
    public class Quarter
    {
        public int QuarterID { get; set; }

        public int GameID { get; set; }

        public int Number { get; set; }

        public string Name { get; set; }

        public int? AwayScore { get; set; }

        public int? HomeScore { get; set; }

    }

}
