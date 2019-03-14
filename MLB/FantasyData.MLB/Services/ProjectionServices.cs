using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.MLB.Entities;
using FantasyData.Utils;

namespace FantasyData.MLB.Services
{
    public interface IProjectionServices
    {
        PlayerGameProjections GetProjectedPlayerGameStatsbyDate(DateTime Date);
        PlayerGameProjections GetProjectedPlayerGameStatsbyPlayer(DateTime Date, string playerid);
        PlayerSeasonProjections GetProjectedPlayerSeasonStats(string season);


    }
    public class ProjectionServices : FantasyDataApiBase, IProjectionServices
    {
        private static readonly string PlayerGameProjectionStatsByDate = "PlayerGameProjectionStatsByDate";
        private static readonly string PlayerGameProjectionStatsByPlayer = "PlayerGameProjectionStatsByPlayer";
        private static readonly string PlayerSeasonProjectionStats = "PlayerSeasonProjectionStats";

        public ProjectionServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }
        public PlayerGameProjections GetProjectedPlayerGameStatsbyDate(DateTime Date)
        {
            var url = string.Format("/{0}/{1}", PlayerGameProjectionStatsByDate, Date.ToApiDate());
            return GetRequest<PlayerGameProjections>(url);
        }
        //
        public PlayerGameProjections GetProjectedPlayerGameStatsbyPlayer(DateTime Date, string playerid)
        {
            var url = string.Format("/{0}/{1}/{2}", PlayerGameProjectionStatsByPlayer, Date.ToApiDate(), playerid);
            return GetRequest<PlayerGameProjections>(url);
        }        

        public PlayerSeasonProjections GetProjectedPlayerSeasonStats(string season)
        {
            var url = string.Format("/{0}/{1}", PlayerSeasonProjectionStats, season);
            return GetRequest<PlayerSeasonProjections>(url);
        }

    }
}
