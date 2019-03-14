using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NBA.Entities
{
    public class Standings : List<Standing>
    { }
    public class Standing
    {
        public int Season { get; set; }

        public int SeasonType { get; set; }

        public int TeamID { get; set; }

        public string Key { get; set; }

        public string City { get; set; }

        public string Name { get; set; }

        public string Conference { get; set; }

        public string Division { get; set; }

        public int? Wins { get; set; }

        public int? Losses { get; set; }

        public decimal? Percentage { get; set; }

        public int? ConferenceWins { get; set; }

        public int? ConferenceLosses { get; set; }

        public int? DivisionWins { get; set; }

        public int? DivisionLosses { get; set; }

        public int? HomeWins { get; set; }

        public int? HomeLosses { get; set; }

        public int? AwayWins { get; set; }

        public int? AwayLosses { get; set; }

        public int? LastTenWins { get; set; }

        public int? LastTenLosses { get; set; }

        public decimal? PointsPerGameFor { get; set; }

        public decimal? PointsPerGameAgainst { get; set; }

        public int? Streak { get; set; }

        public decimal? GamesBack { get; set; }

        public string StreakDescription { get; set; }

    }

}
