using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NHL.Entities
{
    public class TeamSeasons : List<TeamSeason>
    { }
    public class TeamSeason
    {
        public int StatID { get; set; }
        public int TeamID { get; set; }
        public int SeasonType { get; set; }
        public int Season { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int OvertimeLosses { get; set; }
        public string OpponentPosition { get; set; }
        public int GlobalTeamID { get; set; }
        public DateTime? Updated { get; set; }
        public int Games { get; set; }
        public double FantasyPoints { get; set; }
        public double FantasyPointsFanDuel { get; set; }
        public double FantasyPointsDraftKings { get; set; }
        public double FantasyPointsYahoo { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public double Goals { get; set; }
        public double Assists { get; set; }
        public double ShotsOnGoal { get; set; }
        public double PowerPlayGoals { get; set; }
        public double ShortHandedGoals { get; set; }
        public double EmptyNetGoals { get; set; }
        public double PowerPlayAssists { get; set; }
        public double ShortHandedAssists { get; set; }
        public double HatTricks { get; set; }
        public double ShootoutGoals { get; set; }
        public double PlusMinus { get; set; }
        public double PenaltyMinutes { get; set; }
        public double Blocks { get; set; }
        public double Hits { get; set; }
        public double Takeaways { get; set; }
        public double Giveaways { get; set; }
        public double FaceoffsWon { get; set; }
        public double FaceoffsLost { get; set; }
        public double Shifts { get; set; }
        public int GoaltendingMinutes { get; set; }
        public int GoaltendingSeconds { get; set; }
        public double GoaltendingShotsAgainst { get; set; }
        public double GoaltendingGoalsAgainst { get; set; }
        public double GoaltendingSaves { get; set; }
        public double GoaltendingWins { get; set; }
        public double GoaltendingLosses { get; set; }
        public double GoaltendingShutouts { get; set; }
        public int Started { get; set; }
        public double BenchPenaltyMinutes { get; set; }
        public double GoaltendingOvertimeLosses { get; set; }
        public double FantasyPointsFantasyDraft { get; set; }
        public TeamSeason OpponentStat { get; set; }
    }
}
