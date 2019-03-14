using FantasyData.Soccer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Soccer.Services
{
    public interface IScheduleServices
    {
        Games Get(int RoundID);
    }
    public class ScheduleServices : FantasyDataApiBase, IScheduleServices
    {
        private static readonly string ScheduleKey = "Schedule";
        public ScheduleServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }

        public Games Get(int RoundID)
        {
            var url = string.Format("/{0}/{1}", ScheduleKey, RoundID);
            return GetRequest<Games>(url);
        }
    }
    
}
