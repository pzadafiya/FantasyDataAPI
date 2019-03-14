using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NBA.Entities
{
    public class Games : List<Game>
    { }
    public class Game
    {
        public int GameID { get; set; }

        public int Season { get; set; }

        public int SeasonType { get; set; }

        public string Status { get; set; }

        public DateTime? Day { get; set; }

        public DateTime? DateTime { get; set; }

        public string AwayTeam { get; set; }

        public string HomeTeam { get; set; }

        public int AwayTeamID { get; set; }

        public int HomeTeamID { get; set; }

        public int? StadiumID { get; set; }

        public string Channel { get; set; }

        public int? Attendance { get; set; }

        public int? AwayTeamScore { get; set; }

        public int? HomeTeamScore { get; set; }

        public DateTime? Updated { get; set; }

        public string Quarter { get; set; }

        public int? TimeRemainingMinutes { get; set; }

        public int? TimeRemainingSeconds { get; set; }

        public decimal? PointSpread { get; set; }

        public decimal? OverUnder { get; set; }

        public int? AwayTeamMoneyLine { get; set; }

        public int? HomeTeamMoneyLine { get; set; }

        public int GlobalGameID { get; set; }

        public int GlobalAwayTeamID { get; set; }

        public int GlobalHomeTeamID { get; set; }

        public int? PointSpreadAwayTeamMoneyLine { get; set; }

        public int? PointSpreadHomeTeamMoneyLine { get; set; }

        public string LastPlay { get; set; }

        public bool IsClosed { get; set; }

    }

}
