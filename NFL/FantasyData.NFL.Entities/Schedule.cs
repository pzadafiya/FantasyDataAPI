using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Entities
{
	public class Schedules : List<Schedule>
	{ }

	public class Schedule
	{
		public Schedule()
		{
			StadiumDetails = new StadiumDetails();
		}
		public string AwayTeam { get; set; }
		public string Channel { get; set; }
		public DateTime? Date { get; set; }
		public string GameKey { get; set; }
		public string HomeTeam { get; set; }
		public double OverUnder { get; set; }
		public double PointSpread { get; set; }
		public int Season { get; set; }
		public int SeasonType { get; set; }
		public int StadiumID { get; set; }
		public int Week { get; set; }

		public bool? Canceled { get; set; }
		public double GeoLat { get; set; }
		public double GeoLong { get; set; }
		public int ForecastTempLow { get; set; }
		public int ForecastTempHigh { get; set; }
		public string ForecastDescription { get; set; }
		public int ForecastWindChill { get; set; }
		public int ForecastWindSpeed { get; set; }
		public int AwayTeamMoneyLine { get; set; }
		public int HomeTeamMoneyLine { get; set; }
		public DateTime? Day { get; set; }
		public DateTime? DateTime { get; set; }
		public int GlobalGameID { get; set; }
		public int GlobalAwayTeamID { get; set; }
		public int GlobalHomeTeamID { get; set; }
		public int ScoreID { get; set; }
		public string Status { get; set; }
		public StadiumDetails StadiumDetails { get; set; }

	}
}
