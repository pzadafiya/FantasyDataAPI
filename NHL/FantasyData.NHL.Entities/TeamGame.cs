using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NHL.Entities
{
    public class TeamGames : List<TeamGame>
    { }
    public class TeamGame
    {
        public int StatID { get; set; }

        public int? TeamID { get; set; }

        public int? SeasonType { get; set; }

        public int? Season { get; set; }

        public string Name { get; set; }

        public string Team { get; set; }

        public int? Wins { get; set; }

        public int? Losses { get; set; }

        public int? OvertimeLosses { get; set; }

        public int? GlobalTeamID { get; set; }

        public int? GameID { get; set; }

        public int? OpponentID { get; set; }

        public string Opponent { get; set; }

        public DateTime? Day { get; set; }

        public DateTime? DateTime { get; set; }

        public string HomeOrAway { get; set; }

        public bool IsGameOver { get; set; }

        public int? GlobalGameID { get; set; }

        public int? GlobalOpponentID { get; set; }

        public DateTime? Updated { get; set; }

        public int? Games { get; set; }

        public decimal? FantasyPoints { get; set; }

        public decimal? FantasyPointsFanDuel { get; set; }

        public decimal? FantasyPointsDraftKings { get; set; }

        public decimal? FantasyPointsYahoo { get; set; }

        public int? Minutes { get; set; }

        public int? Seconds { get; set; }

        public decimal? Goals { get; set; }

        public decimal? Assists { get; set; }

        public decimal? ShotsOnGoal { get; set; }

        public decimal? PowerPlayGoals { get; set; }

        public decimal? ShortHandedGoals { get; set; }

        public decimal? EmptyNetGoals { get; set; }

        public decimal? PowerPlayAssists { get; set; }

        public decimal? ShortHandedAssists { get; set; }

        public decimal? HatTricks { get; set; }

        public decimal? ShootoutGoals { get; set; }

        public decimal? PlusMinus { get; set; }

        public decimal? PenaltyMinutes { get; set; }

        public decimal? Blocks { get; set; }

        public decimal? Hits { get; set; }

        public decimal? Takeaways { get; set; }

        public decimal? Giveaways { get; set; }

        public decimal? FaceoffsWon { get; set; }

        public decimal? FaceoffsLost { get; set; }

        public decimal? Shifts { get; set; }

        public int? GoaltendingMinutes { get; set; }

        public int? GoaltendingSeconds { get; set; }

        public decimal? GoaltendingShotsAgainst { get; set; }

        public decimal? GoaltendingGoalsAgainst { get; set; }

        public decimal? GoaltendingSaves { get; set; }

        public decimal? GoaltendingWins { get; set; }

        public decimal? GoaltendingLosses { get; set; }

        public decimal? GoaltendingShutouts { get; set; }

        public int? Started { get; set; }

        public decimal? BenchPenaltyMinutes { get; set; }

        public decimal? GoaltendingOvertimeLosses { get; set; }

        public decimal? FantasyPointsFantasyDraft { get; set; }
    }
}
