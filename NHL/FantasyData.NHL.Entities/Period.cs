using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NHL.Entities
{
    public class Periods : List<Period>
    { }
    public class Period
    {
        public int PeriodID { get; set; }

        public int GameID { get; set; }

        public string Name { get; set; }

        public int? AwayScore { get; set; }

        public int? HomeScore { get; set; }
    }
}
