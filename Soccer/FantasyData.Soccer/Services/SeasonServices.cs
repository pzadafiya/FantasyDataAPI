using FantasyData.Soccer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Soccer.Services
{
    public interface ISeasonServices
    {
        SeasonTeams Get(string SeasonID);
    }
    public class SeasonServices : FantasyDataApiBase, ISeasonServices
    {
        private static readonly string SeasonTeamKey = "SeasonTeams";

        public SeasonServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }

        public SeasonTeams Get(string SeasonID)
        {
            var url = string.Format("/{0}/{1}", SeasonTeamKey, SeasonID);
            return GetRequest<SeasonTeams>(url);
        }
    }
}
