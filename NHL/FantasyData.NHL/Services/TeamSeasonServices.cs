using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.NHL.Entities;

namespace FantasyData.NHL.Services
{
    public interface ITeamSeasonService
    {
        TeamSeasons GetTeamSeasonStats(string season);
        TeamSeasons GetTeamStatsAllowedbyPosition(string season);
    }
    public class TeamSeasonServices : FantasyDataApiBase, ITeamSeasonService
    {        

        private static readonly string Key = "TeamSeasonStats";
        private static readonly string TeamStatsAllowedByPosition = "TeamStatsAllowedByPosition";

        public TeamSeasonServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }    


        public TeamSeasons GetTeamSeasonStats(string season)
        {
            var url = string.Format("/{0}/{1}", Key,season);            
            return GetRequest<TeamSeasons>(url);            
        }
        public TeamSeasons GetTeamStatsAllowedbyPosition(string season)
        {
            var url = string.Format("/{0}/{1}", TeamStatsAllowedByPosition, season);
            return GetRequest<TeamSeasons>(url);
        }
    }    
}
