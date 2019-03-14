using FantasyData.NFL.Contracts;
using FantasyData.NFL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Services
{
    class TeamSeasonService : FantasyDataApiBase, ITeamSeasonService
    {
        private static readonly string TeamSeasonKey = "TeamSeasonStats";

        public TeamSeasonService(string apiBaseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(apiBaseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="season"></param>
        /// <returns></returns>
        public TeamSeasons Get(string season)
        {
            var url = string.Format("/{0}/{1}", TeamSeasonKey, season);
            return GetRequest<TeamSeasons>(url);
        }
    }
}
