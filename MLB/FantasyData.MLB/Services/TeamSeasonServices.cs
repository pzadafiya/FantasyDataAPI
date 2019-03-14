using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.MLB.Entities;
using FantasyData.Utils;

namespace FantasyData.MLB.Services
{
    public interface ITeamSeasonServices
    {
        TeamSeasons GetTeamStatsAllowedbyPosition(string season);

        TeamSeasons GetTeamSeasonStats(string season);
    }
    public class TeamSeasonServices : FantasyDataApiBase, ITeamSeasonServices
    {
        private static readonly string TeamStatsAllowedByPosition = "TeamStatsAllowedByPosition";
        private static readonly string Key = "TeamSeasonStats";

        public TeamSeasonServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }
        public TeamSeasons GetTeamStatsAllowedbyPosition(string season)
        {
            var url = string.Format("/{0}/{1}", TeamStatsAllowedByPosition, season);
            return GetRequest<TeamSeasons>(url);
        }

        public TeamSeasons GetTeamSeasonStats(string season)
        {
            var url = string.Format("/{0}/{1}", Key, season);
            return GetRequest<TeamSeasons>(url);
        }
    }
}
