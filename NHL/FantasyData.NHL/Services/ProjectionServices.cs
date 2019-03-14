using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.NHL.Entities;
using FantasyData.Utils;

namespace FantasyData.NHL.Services
{
    public interface IProjectionService
    {
        Projections GetProjectionByDate(DateTime Date);
        Projections GetProjectionByDateAndPlayer(DateTime Date, string PlayerID);
    }
    public class ProjectionServices : FantasyDataApiBase, IProjectionService
    {

        private static readonly string ProjectKey = "PlayerGameProjectionStatsByDate";
        private static readonly string ProjectKeyForDateAndPlayer = "PlayerGameProjectionStatsByPlayer";

        public ProjectionServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }

        public Projections GetProjectionByDate(DateTime date)
        {
            var url = string.Format("/{0}/{1}", ProjectKey, date.ToApiDate());
            return GetRequest<Projections>(url);
        }
        public Projections GetProjectionByDateAndPlayer(DateTime Date, string PlayerID)
        {
            var url = string.Format("/{0}/{1}/{2}", ProjectKeyForDateAndPlayer, Date.ToApiDate(), PlayerID);
            return GetRequest<Projections>(url);
        }
    }
}

