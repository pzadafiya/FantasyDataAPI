using FantasyData.Soccer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Soccer.Services
{
    public interface ICompetitionServices
    {
        Competitions Get();
        CompetitionHierarchies GetCompetitionHierarchy();
        Competitions GetCompetitionFixtures(string Competition);
    }
    public class CompetitionServices : FantasyDataApiBase, ICompetitionServices
    {
        private static readonly string CompetitionKey = "Competitions";
        private static readonly string CompetitionHierarchyKey = "CompetitionHierarchy";
        private static readonly string CompetitionFixturesKey = "CompetitionDetails";
       
        public CompetitionServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }

        public Competitions Get()
        {
            var url = string.Format("/{0}", CompetitionKey);
            return GetRequest<Competitions>(url);
        }
        public CompetitionHierarchies GetCompetitionHierarchy()
        {
            var url = string.Format("/{0}", CompetitionHierarchyKey);
            return GetRequest<CompetitionHierarchies>(url);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Competition">An indication of a soccer competition/league. 
        /// This value can be the CompetitionId or the Competition Key. Possible values include: EPL, 1, MLS, 8, etc.</param>
        /// <returns></returns>
        public Competitions GetCompetitionFixtures(string Competition)
        {
            var url = string.Format("/{0}/{1}", CompetitionFixturesKey, Competition);
            return GetRequest<Competitions>(url);
        }
    }
}
