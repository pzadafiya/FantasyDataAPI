using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.NBA.Entities;
using FantasyData.Utils;

namespace FantasyData.NBA.Services
{    
    public interface IOpponentSeasonServices
    {
        OpponentSeasons GetTeamGameStatsbyDate(DateTime Date);        
        OpponentSeasons GetTeamSeasonStats(string season);

    }
    public class OpponentSeasonServices : FantasyDataApiBase, IOpponentSeasonServices
    {
        private static readonly string TeamGameStatsByDate = "TeamGameStatsByDate";
        private static readonly string TeamSeasonStats = "TeamSeasonStats";        

        public OpponentSeasonServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }
        public OpponentSeasons GetTeamGameStatsbyDate(DateTime Date)
        {
            var url = string.Format("/{0}/{1}", TeamGameStatsByDate, Date.ToApiDate());
            return GetRequest<OpponentSeasons>(url);
        }
        public OpponentSeasons GetTeamSeasonStats(string season)
        {
            var url = string.Format("/{0}/{1}", TeamSeasonStats, season);
            return GetRequest<OpponentSeasons>(url);
        }
    }
}

