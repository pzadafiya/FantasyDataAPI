using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.NBA.Entities;
using FantasyData.Utils;

namespace FantasyData.NBA.Services
{
    public interface ITeamServices
    {
        Teams GetActiveTeams();
        Teams GetAllTeams();
    }
    public class TeamServices : FantasyDataApiBase, ITeamServices
    {
        private static readonly string teams = "teams";
        private static readonly string AllTeams = "AllTeams";

        public TeamServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }
        public Teams GetActiveTeams()
        {
            var url = string.Format("/{0}", teams);
            return GetRequest<Teams>(url);
        }
        public Teams GetAllTeams()
        {
            var url = string.Format("/{0}", AllTeams);
            return GetRequest<Teams>(url);
        }
    }

}

