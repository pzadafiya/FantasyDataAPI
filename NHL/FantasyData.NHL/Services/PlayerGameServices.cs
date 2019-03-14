using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.NHL.Entities;
using FantasyData.Utils;

namespace FantasyData.NHL.Services
{
    public interface IPlayerGameService
    {
        PlayerGames GetTeamGameStatsbyDate(DateTime date);
    }
    public class PlayerGameServices : FantasyDataApiBase, IPlayerGameService
    {

        private static readonly string TeamGameStatsbyDate = "TeamGameStatsByDate";        

        public PlayerGameServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }

        public PlayerGames GetTeamGameStatsbyDate(DateTime date)
        {
            var url = string.Format("/{0}/{1}", TeamGameStatsbyDate, date.ToApiDate());
            return GetRequest<PlayerGames>(url);
        }
    }
}
