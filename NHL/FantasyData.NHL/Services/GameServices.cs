using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.NHL.Entities;
using FantasyData.Utils;

namespace FantasyData.NHL.Services
{
    public interface IGameService
    {
        Games GetGameByDate(DateTime date);
        Games GetGameBySeason(string Season);
        bool IsGameInProgress { get; }
    }
    public class GameServices : FantasyDataApiBase, IGameService
    {

        private static readonly string GameKey = "GamesByDate";
        private static readonly string SeasonKey = "Games";

        private static readonly string AreGamesInProgressKey = "AreAnyGamesInProgress";

        public GameServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }

        public bool IsGameInProgress
        {
            get
            {
                string url = string.Format("/{0}", AreGamesInProgressKey);
                return GetBool(url);
            }
        }

        public Games GetGameByDate(DateTime date)
        {
            var url = string.Format("/{0}/{1}", GameKey, date.ToApiDate());
            return GetRequest<Games>(url);
        }        
        public Games GetGameBySeason(string Season)
        {
            var url = string.Format("/{0}/{1}", SeasonKey, Season);
            return GetRequest<Games>(url);
        }
        
    }
}
