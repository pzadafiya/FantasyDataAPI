using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Soccer.Entities
{
    public class SeasonTeams : List<SeasonTeam> { }
    public class SeasonTeam
    {
        public int SeasonTeamId { get; set; }
        public int SeasonId { get; set; }
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public bool Active { get; set; }
        public string Gender { get; set; }
        public string Type { get; set; }
        public Team Team { get; set; }
    }
}
