using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.MLB.Entities
{
    public class Innings : List<Inning>
    { }
    public class Inning
    {
        public int InningID { get; set; }

        public int GameID { get; set; }

        public int InningNumber { get; set; }

        public int? AwayTeamRuns { get; set; }

        public int? HomeTeamRuns { get; set; }

    }

}
