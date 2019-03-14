using FantasyData.Soccer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Soccer.Services
{

    public interface IPlayerSeasonStatServices
    {
        PlayerSeason Get(string RoundID, string PlayerID);
        PlayerSeasons GetPlayerSeasonByRound(string RoundID);
        PlayerSeasons GetPlayerSeasonByTeam(string RoundID, string TeamID);

    }
    public class PlayerSeasonStatServices : FantasyDataApiBase, IPlayerSeasonStatServices
    {
        private static readonly string PlayerSeasonStatsKey = "PlayerSeasonStats";
        private static readonly string PlayerSeasonStatsByPlayerKey = "PlayerSeasonStatsByPlayer";
        private static readonly string PlayerSeasonStatsByTeamKey = "PlayerSeasonStatsByTeam";
        public PlayerSeasonStatServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }

        public PlayerSeason Get(string RoundID, string PlayerID)
        {
            var url = string.Format("/{0}/{1}", PlayerSeasonStatsByPlayerKey, RoundID, PlayerID);
            return GetRequest<PlayerSeason>(url);
        }
        public PlayerSeasons GetPlayerSeasonByRound(string RoundID)
        {
            var url = string.Format("/{0}/{1}", PlayerSeasonStatsKey, RoundID);
            return GetRequest<PlayerSeasons>(url);
        }
        public PlayerSeasons GetPlayerSeasonByTeam(string RoundID, string TeamID)
        {
            var url = string.Format("/{0}/{1}/{2}", PlayerSeasonStatsByTeamKey, RoundID, TeamID);
            return GetRequest<PlayerSeasons>(url);
        }
    }
   
}
