using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NHL.Entities
{
    public class Schedules : List<Schedule>
    { }
    public class Schedule
    {
        public int GameID { get; set; }
        public int Season { get; set; }
        public int SeasonType { get; set; }
        public string Status { get; set; }
        public DateTime? Day { get; set; }
        public DateTime? DateTime { get; set; }
        public DateTime? Updated { get; set; }
        public bool IsClosed { get; set; }
        public string AwayTeam { get; set; }
        public string HomeTeam { get; set; }
        public int AwayTeamID { get; set; }
        public int HomeTeamID { get; set; }
        public int StadiumID { get; set; }
        public string Channel { get; set; }
        public string Attendance { get; set; }
        public int AwayTeamScore { get; set; }
        public int HomeTeamScore { get; set; }
        public string Period { get; set; }
        public string TimeRemainingMinutes { get; set; }
        public string TimeRemainingSeconds { get; set; }
        public int AwayTeamMoneyLine { get; set; }
        public int HomeTeamMoneyLine { get; set; }
        public double PointSpread { get; set; }
        public double OverUnder { get; set; }
        public int GlobalGameID { get; set; }
        public int GlobalAwayTeamID { get; set; }
        public int GlobalHomeTeamID { get; set; }
        public string PointSpreadAwayTeamMoneyLine { get; set; }
        public string PointSpreadHomeTeamMoneyLine { get; set; }
        public string LastPlay { get; set; }
    }
}
