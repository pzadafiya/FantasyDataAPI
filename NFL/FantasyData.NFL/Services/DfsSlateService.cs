using FantasyData.NFL.Entities;
using FantasyData.NFL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.Utils;

namespace FantasyData.NFL.Services
{
    public class DfsSlateService : FantasyDataApiBase, IDfsSlateService
    {
        public static readonly string DfsSlatesByDate = "DfsSlatesByDate";
        public static readonly string DfsSlatesByWeek = "DfsSlatesByWeek";

        public DfsSlateService(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }        
        public DfsSlates GetDFSSlatesbyDate(DateTime date)
        {
            string url = string.Format("/{0}/{1}", DfsSlatesByDate, date.ToApiDate());

            return GetRequest<DfsSlates>(url);
        }
        public DfsSlates GetDFSSlatesbyWeek(string Season, int week)
        {
            string url = string.Format("/{0}/{1}/{2}", DfsSlatesByWeek, Season, week);

            return GetRequest<DfsSlates>(url);
        }
    }
}
