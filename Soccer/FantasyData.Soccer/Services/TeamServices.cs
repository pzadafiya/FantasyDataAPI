using FantasyData.Soccer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Soccer.Services
{
    public interface ITeamServices
    {
        Teams Get();
    }
    public class TeamServices : FantasyDataApiBase, ITeamServices
    {
        private static readonly string TeamsKey = "Teams";
        public TeamServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }

        public Teams Get()
        {
            var url = string.Format("/{0}", TeamsKey);
            return GetRequest<Teams>(url);
        }
    }
   
}
