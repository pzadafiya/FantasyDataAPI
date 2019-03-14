using FantasyData.Soccer.Entities;
using FantasyData.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Soccer.Services
{
    public interface IPlayerGameStatServices
    {
        PlayerGames Get(DateTime date);
        PlayerGame GetPlayerGameByPlayer(DateTime date, string PlayerID);

        //PlayerGames GetProjectionByDate(DateTime date);
        //PlayerGames GetProjectionByCompetition(string Competition, DateTime date);
        //PlayerGames GetProjectionByPlayer(int PlayerID, DateTime date);
    }
    public class PlayerGameStatServices : FantasyDataApiBase, IPlayerGameStatServices
    {
        private static readonly string PlayerGameStatsByPlayerKey = "PlayerGameStatsByPlayer";
        private static readonly string PlayerGameStatsByDateKey = "PlayerGameStatsByDate";

        //private static readonly string ProjectedPlayerGameStatsByDateKey = "PlayerGameProjectionStatsByDate";
        //private static readonly string ProjectedPlayerGameStatsByCompetitionKey = "PlayerGameProjectionStatsByCompetition";
        //private static readonly string ProjectedPlayerGameStatsByPlayerKey = "PlayerGameProjectionStatsByPlayer";

        //private static readonly string PlayerGameStatsByDateKey = "PlayerGameStatsByDate";
        public PlayerGameStatServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }

        public PlayerGame GetPlayerGameByPlayer(DateTime date, string PlayerID)
        {
            var url = string.Format("/{0}/{1}/{2}", PlayerGameStatsByPlayerKey, date.ToApiDate(), PlayerID);
            return GetRequest<PlayerGame>(url);
        }
        public PlayerGames Get(DateTime date)
        {
            var url = string.Format("/{0}/{1}", PlayerGameStatsByDateKey, date.ToApiDate());
            return GetRequest<PlayerGames>(url);
        }

        //public PlayerGames GetProjectionByDate(DateTime date)
        //{
        //    var url = string.Format("/{0}/{1}", ProjectedPlayerGameStatsByDateKey, date.ToApiDate());
        //    return GetRequest<PlayerGames>(url);
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="Competition">An indication of a soccer competition/league.
        ///// This value can be the CompetitionId or the Competition Key. Possible values include: EPL, 1, MLS, 8, etc.</param>
        ///// <param name="date"></param>
        ///// <returns></returns>
        //public PlayerGames GetProjectionByCompetition(string Competition,DateTime date)
        //{
        //    var url = string.Format("/{0}/{1}/{2}", ProjectedPlayerGameStatsByCompetitionKey,Competition, date.ToApiDate());
        //    return GetRequest<PlayerGames>(url);
        //}
        
        //public PlayerGames GetProjectionByPlayer(int PlayerID, DateTime date)
        //{
        //    var url = string.Format("/{0}/{1}/{2}", ProjectedPlayerGameStatsByPlayerKey, date.ToApiDate(),PlayerID);
        //    return GetRequest<PlayerGames>(url);
        //}
    }
}
