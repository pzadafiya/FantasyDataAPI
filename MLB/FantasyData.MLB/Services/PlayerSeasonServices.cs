using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.MLB.Entities;

namespace FantasyData.MLB.Services
{
    public interface IPlayerSeasonServices
    {
        PlayerSeasons GetPlayerSeasonStats(string season);

        PlayerSeasons GetBattervsPitcherStats(string hitterid, string pitcherid);

        PlayerSeasons GetPlayerSeasonAwayStats(string season);

        PlayerSeasons GetPlayerSeasonHomeStats(string season);

        PlayerSeasons GetPlayerSeasonSplitStats(string season,string split);

        PlayerSeasons GetPlayerSeasonStatsSplitByTeam(string season);
    }
    public class PlayerSeasonServices : FantasyDataApiBase, IPlayerSeasonServices
    {

        private static readonly string PlayerSeasonStats = "PlayerSeasonStats";
        private static readonly string HitterVsPitcher = "HitterVsPitcher";
        private static readonly string PlayerSeasonAwayStats = "PlayerSeasonAwayStats";
        private static readonly string PlayerSeasonHomeStats = "PlayerSeasonHomeStats";
        private static readonly string PlayerSeasonSplitStats = "PlayerSeasonSplitStats";
        private static readonly string PlayerSeasonStatsSplitByTeam = "PlayerSeasonStatsSplitByTeam";
        

        public PlayerSeasonServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }
        public PlayerSeasons GetPlayerSeasonStats(string season)
        {
            var url = string.Format("/{0}/{1}", PlayerSeasonStats, season);
            return GetRequest<PlayerSeasons>(url);
        }
        public PlayerSeasons GetBattervsPitcherStats(string hitterid, string pitcherid)
        {
            var url = string.Format("/{0}/{1}/{2}", HitterVsPitcher, hitterid, pitcherid);
            return GetRequest<PlayerSeasons>(url);
        }

        public PlayerSeasons GetPlayerSeasonAwayStats(string season)
        {
            var url = string.Format("/{0}/{1}", PlayerSeasonAwayStats, season);
            return GetRequest<PlayerSeasons>(url);
        }

        public PlayerSeasons GetPlayerSeasonHomeStats(string season)
        {
            var url = string.Format("/{0}/{1}", PlayerSeasonHomeStats, season);
            return GetRequest<PlayerSeasons>(url);
        }

        public PlayerSeasons GetPlayerSeasonSplitStats(string season, string split)
        {
            var url = string.Format("/{0}/{1}/{2}", PlayerSeasonSplitStats, season, split);
            return GetRequest<PlayerSeasons>(url);
        }

        public PlayerSeasons GetPlayerSeasonStatsSplitByTeam(string season)
        {
            var url = string.Format("/{0}/{1}", PlayerSeasonStatsSplitByTeam, season);
            return GetRequest<PlayerSeasons>(url);
        }
    }
}

