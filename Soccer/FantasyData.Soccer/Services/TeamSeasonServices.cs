using FantasyData.Soccer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Soccer.Services
{
    public interface ITeamSeasonService
    {
        TeamSeasons Get(string RoundID);
    }
    class TeamSeasonService : FantasyDataApiBase, ITeamSeasonService
    {
        private static readonly string TeamSeasonStatsKey = "TeamSeasonStats";

        public TeamSeasonService(string apiBaseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(apiBaseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="season"></param>
        /// <returns></returns>
        public TeamSeasons Get(string RoundID)
        {
            var url = string.Format("/{0}/{1}", TeamSeasonStatsKey, RoundID);
            return GetRequest<TeamSeasons>(url);
        }
    }
}
