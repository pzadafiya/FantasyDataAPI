using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.MLB.Entities
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

        public int? RescheduledGameID { get; set; }

        public int? StadiumID { get; set; }

        public string Channel { get; set; }

        public int? Inning { get; set; }

        public string InningHalf { get; set; }

        public int? AwayTeamRuns { get; set; }

        public int? HomeTeamRuns { get; set; }

        public int? AwayTeamHits { get; set; }

        public int? HomeTeamHits { get; set; }

        public int? AwayTeamErrors { get; set; }

        public int? HomeTeamErrors { get; set; }

        public int? WinningPitcherID { get; set; }

        public int? LosingPitcherID { get; set; }

        public int? SavingPitcherID { get; set; }

        public int? Attendance { get; set; }

        public int? AwayTeamProbablePitcherID { get; set; }

        public int? HomeTeamProbablePitcherID { get; set; }

        public int? Outs { get; set; }

        public int? Balls { get; set; }

        public int? Strikes { get; set; }

        public int? CurrentPitcherID { get; set; }

        public int? CurrentHitterID { get; set; }

        public int? AwayTeamStartingPitcherID { get; set; }

        public int? HomeTeamStartingPitcherID { get; set; }

        public int? CurrentPitchingTeamID { get; set; }

        public int? CurrentHittingTeamID { get; set; }

        public decimal? PointSpread { get; set; }

        public decimal? OverUnder { get; set; }

        public int? AwayTeamMoneyLine { get; set; }

        public int? HomeTeamMoneyLine { get; set; }

        public int? ForecastTempLow { get; set; }

        public int? ForecastTempHigh { get; set; }

        public string ForecastDescription { get; set; }

        public int? ForecastWindChill { get; set; }

        public int? ForecastWindSpeed { get; set; }

        public int? ForecastWindDirection { get; set; }

        public int? RescheduledFromGameID { get; set; }

        public bool? RunnerOnFirst { get; set; }

        public bool? RunnerOnSecond { get; set; }

        public bool? RunnerOnThird { get; set; }

        public string AwayTeamStartingPitcher { get; set; }

        public string HomeTeamStartingPitcher { get; set; }

        public string CurrentPitcher { get; set; }

        public string CurrentHitter { get; set; }

        public string WinningPitcher { get; set; }

        public string LosingPitcher { get; set; }

        public string SavingPitcher { get; set; }

        public int? DueUpHitterID1 { get; set; }

        public int? DueUpHitterID2 { get; set; }

        public int? DueUpHitterID3 { get; set; }

        public int GlobalGameID { get; set; }

        public int GlobalAwayTeamID { get; set; }

        public int GlobalHomeTeamID { get; set; }

        public int? PointSpreadAwayTeamMoneyLine { get; set; }

        public int? PointSpreadHomeTeamMoneyLine { get; set; }

        public string LastPlay { get; set; }

        public bool IsClosed { get; set; }

        public DateTime? Updated { get; set; }

    }

}
