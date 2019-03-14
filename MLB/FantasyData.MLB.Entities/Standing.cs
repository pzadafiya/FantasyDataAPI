using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.MLB.Entities
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

        public string League { get; set; }

        public string Division { get; set; }

        public int? Wins { get; set; }

        public int? Losses { get; set; }

        public decimal? Percentage { get; set; }

        public int? DivisionWins { get; set; }

        public int? DivisionLosses { get; set; }

        public decimal? GamesBehind { get; set; }

        public int? LastTenGamesWins { get; set; }

        public int? LastTenGamesLosses { get; set; }

        public string Streak { get; set; }

        public int? WildCardRank { get; set; }

        public decimal? WildCardGamesBehind { get; set; }

        public int? HomeWins { get; set; }

        public int? HomeLosses { get; set; }

        public int? AwayWins { get; set; }

        public int? AwayLosses { get; set; }

        public int? DayWins { get; set; }

        public int? DayLosses { get; set; }

        public int? NightWins { get; set; }

        public int? NightLosses { get; set; }

    }

}
