using FantasyData.Soccer.Entities;
using FantasyData.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Soccer.Services
{
    public interface IGameServices
    {
        Games Get(DateTime date);
    }
    public class GameServices : FantasyDataApiBase, IGameServices
    {
        private static readonly string GamesByDateKey = "GamesByDate";
       

        public GameServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date">Game date format : yyyy-MM-dd</param>
        /// <returns></returns>
        public Games Get(DateTime date)
        {
            var url = string.Format("/{0}/{1}", GamesByDateKey,date.ToApiDate());
            return GetRequest<Games>(url);
        }
    }
    
}
