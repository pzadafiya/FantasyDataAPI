
using FantasyData.NFL.Contracts;
using FantasyData.NFL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Services
{
    public class TimeFrameService : FantasyDataApiBase, ITimeFrameService
    {
        private static readonly string TimeFramesKey = "TimeFrames";
        private static readonly string CurrentTimeFrameKey = "current";
        private static readonly string UpcomingTimeFrameKey = "upcoming";
        private static readonly string CompletedTimeFrameKey = "completed";
        private static readonly string RecentTimeFrameKey = "recent";
        private static readonly string AllTimeFrameKey = "all";
        
        public TimeFrameService(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }


        public TimeFrames GetAllTimeFrames()
        {
            string url = string.Format("/{0}/{1}",TimeFramesKey, AllTimeFrameKey);
            return GetRequest<TimeFrames>(url);
        }

        public TimeFrames GetRecentTimeFrames()
        {
            string url = string.Format("/{0}/{1}", TimeFramesKey, RecentTimeFrameKey);
            return GetRequest<TimeFrames>(url);
        }

        public TimeFrames GetCompletedTimeFrames()
        {
            string url = string.Format("/{0}/{1}", TimeFramesKey, CompletedTimeFrameKey);
            return GetRequest<TimeFrames>(url);
        }

        public TimeFrames GetUpcomingTimeFrames()
        {
            string url = string.Format("/{0}/{1}", TimeFramesKey, UpcomingTimeFrameKey);
            return GetRequest<TimeFrames>(url);
        }

        public TimeFrames GetCurrentTimeFrames()
        {
            string url = string.Format("/{0}/{1}", TimeFramesKey, CurrentTimeFrameKey);
            return GetRequest<TimeFrames>(url);
        }


    }
}
