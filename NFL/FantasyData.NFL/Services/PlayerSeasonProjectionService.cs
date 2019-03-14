using FantasyData.NFL.Entities;
using FantasyData.NFL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Services
{
    public class PlayerSeasonProjectionService : FantasyDataApiBase, IPlayerSeasonProjectionService
    {
        private static readonly string PlayerSeasonProjectionStats = "PlayerSeasonProjectionStats";
        private static readonly string PlayerSeasonProjectionStatsByPlayerID = "PlayerSeasonProjectionStatsByPlayerID";
        private static readonly string PlayerSeasonProjectionStatsByTeam = "PlayerSeasonProjectionStatsByTeam";

        public PlayerSeasonProjectionService(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }
        
        public PlayerSeasonProjections GetProjectedPlayerSeasonStats(string Season)
        {
            var url = string.Format("/{0}/{1}", PlayerSeasonProjectionStats, Season);
            return this.GetRequest<PlayerSeasonProjections>(url);
        }

        public PlayerSeasonProjections GetProjectedPlayerSeasonStatsbyPlayer(string Season, int PlayerID)
        {
            var url = string.Format("/{0}/{1}/{2}", PlayerSeasonProjectionStatsByPlayerID, Season, PlayerID);
            return this.GetRequest<PlayerSeasonProjections>(url);
        }

        public PlayerSeasonProjections GetProjectedPlayerSeasonStatsbyTeam(string Season,  string Team)
        {
            var url = string.Format("/{0}/{1}/{2}", PlayerSeasonProjectionStatsByTeam, Season,Team);
            return this.GetRequest<PlayerSeasonProjections>(url);
        }
    }
}
