using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.NBA.Entities;
using FantasyData.Utils;

namespace FantasyData.NBA.Services
{

    public interface IGameServices
    {
        Games GamesbyDate(DateTime Date);
        Games GetSchedules(string Season);

    }
    public class GameServices : FantasyDataApiBase, IGameServices
    {
        private static readonly string GamesByDate = "GamesByDate";
        private static readonly string Games = "Games";

        public GameServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }
        public Games GamesbyDate(DateTime Date)
        {
            var url = string.Format("/{0}/{1}", GamesByDate, Date.ToApiDate());
            return GetRequest<Games>(url);
        }
        public Games GetSchedules(string Season)
        {
            var url = string.Format("/{0}/{1}", Games, Season);
            return GetRequest<Games>(url);
        }
    }
}
