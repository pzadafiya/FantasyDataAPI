using FantasyData.Soccer.Entities;
using FantasyData.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Soccer.Services
{
    public interface ITeamGameServices
    {
        TeamGames Get(DateTime date);
    }
    public class TeamGameServices : FantasyDataApiBase, ITeamGameServices
    {
        private static readonly string TeamGameStatsByDateKey = "TeamGameStatsByDate";
        public TeamGameServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }

        public TeamGames Get(DateTime date)
        {
            var url = string.Format("/{0}/{1}", TeamGameStatsByDateKey, date.ToApiDate());
            return GetRequest<TeamGames>(url);
        }
    }
   
}
