using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.MLB.Entities;
using FantasyData.Utils;

namespace FantasyData.MLB.Services
{
    public interface IPlayerGameServices
    {
        PlayerGames GetPlayerGameStatsbyDate(DateTime Date);
        PlayerGames GetPlayerGameStatsbyPlayerID(DateTime Date, string PlayerID);
        PlayerGames GetPlayerSeasonStatsByPlayer(string season, string playerid);
        PlayerGames GetPlayerSeasonStatsbyTeam(string season, string team);
        PlayerGames GetTeamGameStatsbyDate(DateTime date);

    }
    public class PlayerGameServices : FantasyDataApiBase, IPlayerGameServices
    {
        private static readonly string PlayerGameStatsByDate = "PlayerGameStatsByDate";
        private static readonly string PlayerGameStatsByPlayer = "PlayerGameStatsByPlayer";
        private static readonly string PlayerSeasonStatsByPlayer = "PlayerSeasonStatsByPlayer";
        private static readonly string PlayerSeasonStatsByTeam = "PlayerSeasonStatsByTeam";
        private static readonly string TeamGameStatsbyDate = "TeamGameStatsByDate";

        public PlayerGameServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }
        public PlayerGames GetPlayerGameStatsbyDate(DateTime Date)
        {
            var url = string.Format("/{0}/{1}", PlayerGameStatsByDate, Date.ToApiDate());
            return GetRequest<PlayerGames>(url);
        }
        public PlayerGames GetPlayerGameStatsbyPlayerID(DateTime Date, string PlayerID)
        {
            var url = string.Format("/{0}/{1}/{2}", PlayerGameStatsByPlayer, Date.ToApiDate(), PlayerID);
            return GetRequest<PlayerGames>(url);
        }
        public PlayerGames GetPlayerSeasonStatsByPlayer(string season, string playerid)
        {
            var url = string.Format("/{0}/{1}/{2}", PlayerSeasonStatsByPlayer, season, playerid);
            return GetRequest<PlayerGames>(url);
        }
        public PlayerGames GetPlayerSeasonStatsbyTeam(string season, string team)
        {
            var url = string.Format("/{0}/{1}/{2}", PlayerSeasonStatsByTeam, season, team);
            return GetRequest<PlayerGames>(url);
        }

        public PlayerGames GetTeamGameStatsbyDate(DateTime date)
        {
            var url = string.Format("/{0}/{1}", TeamGameStatsbyDate, date.ToApiDate());
            return GetRequest<PlayerGames>(url);
        }
    }
}

