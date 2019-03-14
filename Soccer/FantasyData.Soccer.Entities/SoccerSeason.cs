using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Soccer.Entities
{
   
    public class SoccerSeasons : List<SoccerSeason>
    {
    }
    public class SoccerSeason
    {
        public int SeasonId { get; set; }
        public int CompetitionId { get; set; }
        public int Season { get; set; }
        public string Name { get; set; }
        public string CompetitionName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool CurrentSeason { get; set; }
        public Rounds Rounds { get; set; }
    }
}
