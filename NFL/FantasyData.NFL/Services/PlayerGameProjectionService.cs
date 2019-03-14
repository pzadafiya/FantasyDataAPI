using FantasyData.NFL.Entities;
using FantasyData.NFL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Services
{
    public class PlayerGameProjectionService : FantasyDataApiBase, IPlayerGameProjectionsService
    {
        private static readonly string PlayerGameProjectionStatsByPlayerID = "PlayerGameProjectionStatsByPlayerID";
        private static readonly string IdpPlayerGameProjectionStatsByTeam = "IdpPlayerGameProjectionStatsByTeam";
        private static readonly string IdpPlayerGameProjectionStatsByWeek = "IdpPlayerGameProjectionStatsByWeek";

        public PlayerGameProjectionService(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }
        
        public PlayerGameProjections GetProjectedPlayerGameStatsbyPlayer(string Season, int Week, int PlayerId)
        {
            var url = string.Format("/{0}/{1}/{2}/{3}", PlayerGameProjectionStatsByPlayerID, Season, Week, PlayerId);
            return this.GetRequest<PlayerGameProjections>(url);
        }

        public PlayerGameProjections GetProjectedPlayerGameStatsbyTeam(string Season, int Week, string Team)
        {
            var url = string.Format("/{0}/{1}/{2}/{3}", IdpPlayerGameProjectionStatsByTeam, Season, Week, Team);
            return this.GetRequest<PlayerGameProjections>(url);
        }

        public PlayerGameProjections GetProjectedPlayerGameStatsbyWeek(string Season, int Week)
        {
            var url = string.Format("/{0}/{1}/{2}", IdpPlayerGameProjectionStatsByWeek, Season, Week);
            return this.GetRequest<PlayerGameProjections>(url);
        }
    }
}
