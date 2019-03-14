using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.MLB.Entities;
using FantasyData.Utils;

namespace FantasyData.MLB.Services
{
    public interface IStandingsServices
    {
        Standings GetStandings(string Season);
    }
    public class StandingsServices : FantasyDataApiBase, IStandingsServices
    {
        private static readonly string Standings = "Standings";

        public StandingsServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }
        public Standings GetStandings(string Season)
        {
            var url = string.Format("/{0}/{1}", Standings, Season);
            return GetRequest<Standings>(url);
        }
    }
}
