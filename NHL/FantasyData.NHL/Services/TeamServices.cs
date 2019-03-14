using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.NHL.Entities;

namespace FantasyData.NHL.Services
{
    public interface ITeamService
    {
        Teams GetTeams(); 
        Teams GetAllTeams();
    }
    public class TeamServices : FantasyDataApiBase, ITeamService
    {        

        private static readonly string TeamsKey = "Teams";
        private static readonly string AllTeams = "AllTeams";

        public TeamServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }    


        public Teams GetTeams()
        {
            var url = string.Format("/{0}", TeamsKey);            
            return GetRequest<Teams>(url);            
        }
        public Teams GetAllTeams()
        {
            var url = string.Format("/{0}", AllTeams);
            return GetRequest<Teams>(url);
        }
    }    
}
