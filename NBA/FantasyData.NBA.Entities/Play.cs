using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NBA.Entities
{
    public class Plays : List<Play>
    { }
    public class Play
    {
        public int PlayID { get; set; }

        public int QuarterID { get; set; }

        public string QuarterName { get; set; }

        public int Sequence { get; set; }

        public int? TimeRemainingMinutes { get; set; }

        public int? TimeRemainingSeconds { get; set; }

        public int? AwayTeamScore { get; set; }

        public int? HomeTeamScore { get; set; }

        public int? PotentialPoints { get; set; }

        public int? Points { get; set; }

        public bool? ShotMade { get; set; }

        public string Category { get; set; }

        public string Type { get; set; }

        public int? TeamID { get; set; }

        public string Team { get; set; }

        public int? OpponentID { get; set; }

        public string Opponent { get; set; }

        public int? ReceivingTeamID { get; set; }

        public string ReceivingTeam { get; set; }

        public string Description { get; set; }

        public int? PlayerID { get; set; }

        public int? AssistedByPlayerID { get; set; }

        public int? BlockedByPlayerID { get; set; }

        public bool? FastBreak { get; set; }

        public string SideOfBasket { get; set; }

        public DateTime? Updated { get; set; }

        public DateTime? Created { get; set; }

        public int? SubstituteInPlayerID { get; set; }

        public int? SubstituteOutPlayerID { get; set; }

    }

}
