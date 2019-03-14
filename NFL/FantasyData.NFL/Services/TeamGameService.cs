using FantasyData.NFL.Contracts;
using FantasyData.NFL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Services
{
    class TeamGameService : FantasyDataApiBase, ITeamGameService
    {
        private static readonly string TeamGameKey = "TeamGameStats";

        public TeamGameService(string apiBaseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(apiBaseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="season"></param>
        /// <param name="week"></param>
        /// <returns></returns>
        public TeamGames Get(string season, int week)
        {
            var url = string.Format("/{0}/{1}/{2}", TeamGameKey, season,week);
            return GetRequest<TeamGames>(url);
        }
    }
}
