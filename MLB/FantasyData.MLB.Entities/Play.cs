using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.MLB.Entities
{
    public class Plays : List<Play>
    { }
    public class Play
    {
        public int PlayID { get; set; }

        public int InningID { get; set; }

        public int? InningNumber { get; set; }

        public string InningHalf { get; set; }

        public int? PlayNumber { get; set; }

        public int? InningBatterNumber { get; set; }

        public int? AwayTeamRuns { get; set; }

        public int? HomeTeamRuns { get; set; }

        public int? HitterID { get; set; }

        public int? PitcherID { get; set; }

        public int? HitterTeamID { get; set; }

        public int? PitcherTeamID { get; set; }

        public string HitterName { get; set; }

        public string PitcherName { get; set; }

        public string PitcherThrowHand { get; set; }

        public string HitterBatHand { get; set; }

        public string HitterPosition { get; set; }

        public int? Outs { get; set; }

        public int? Balls { get; set; }

        public int? Strikes { get; set; }

        public int? PitchNumberThisAtBat { get; set; }

        public string Result { get; set; }

        public int? NumberOfOutsOnPlay { get; set; }

        public int? RunsBattedIn { get; set; }

        public bool? AtBat { get; set; }

        public bool? Strikeout { get; set; }

        public bool? Walk { get; set; }

        public bool? Hit { get; set; }

        public bool? Out { get; set; }

        public bool? Sacrifice { get; set; }

        public bool? Error { get; set; }

        public DateTime? Updated { get; set; }

        public string Description { get; set; }

        public Pitchs Pitches { get; set; }

    }

}
