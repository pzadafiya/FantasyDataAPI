using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.NFL.Entities;
using FantasyData.NFL.Contracts;

namespace FantasyData.NFL.Services
{    
    
    public class ScoresService : FantasyDataApiBase, IScoresService
    {

        private static readonly string Scores = "Scores";

        public ScoresService(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }

        public Scores GetScoresForSeason(string Season)
        {
            var url = string.Format("/{0}/{1}", Scores, Season);
            return GetRequest<Scores>(url);
        }
    }
}
