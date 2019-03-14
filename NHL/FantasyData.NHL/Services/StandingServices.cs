using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.NHL.Entities;


namespace FantasyData.NHL.Services
{
    public interface IStandingService
    {
        Standings GetStandingsSeason(string Season);
    }
    public class StandingServices : FantasyDataApiBase, IStandingService
    {        

        private static readonly string StandingsSeason = "Standings";

        public StandingServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }


        public Standings GetStandingsSeason(string Season)
        {
            var url = string.Format("/{0}/{1}", StandingsSeason, Season);
            return GetRequest<Standings>(url);
        }
    }    
}
