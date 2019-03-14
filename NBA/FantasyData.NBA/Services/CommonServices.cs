using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.Utils;
using FantasyData;
using FantasyData.Utils;

namespace FantasyData.NBA.Services
{
    public interface ICommonServices
    {
        Boolean AnyGamesInProgress();
    }
    public class CommonServices : FantasyDataApiBase, ICommonServices
    {
        private static readonly string AreAnyGamesInProgress = "AreAnyGamesInProgress";

        public CommonServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }
        public Boolean AnyGamesInProgress()
        {
            var url = string.Format("/{0}", AreAnyGamesInProgress);
            return GetBool(url);
        }
    }
}
