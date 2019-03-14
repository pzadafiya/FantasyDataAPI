using FantasyData.Soccer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Soccer.Services
{
    public interface IStandingServices
    {
        Standings Get(string RoundID);
    }
    public class StandingServices : FantasyDataApiBase, IStandingServices
    {
        private static readonly string StandingsKey = "Standings";
        public StandingServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }

        public Standings Get(string RoundID)
        {
            var url = string.Format("/{0}/{1}", StandingsKey, RoundID);
            return GetRequest<Standings>(url);
        }
    }
  
}
