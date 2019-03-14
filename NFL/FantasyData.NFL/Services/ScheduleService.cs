using FantasyData.NFL.Contracts;
using FantasyData.NFL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Services
{
    public class ScheduleService : FantasyDataApiBase, IScheduleService
    {
        private static readonly string SchedulesKey = "Schedules";

        public ScheduleService(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }


        public Schedules GetSchedulesForSeason(string season)
        {
            var url = string.Format("/{0}/{1}", SchedulesKey, season);
            return GetRequest<Schedules>(url);
        }

    }

}
