using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.NBA.Entities;
using FantasyData.Utils;

namespace FantasyData.NBA.Services
{   
    public interface INewsServices
    {
        Newses GetNews();
        Newses NewsbyDate(DateTime Date);
        Newses NewsbyPlayer(string PlayerID);
    }
    public class NewsServices : FantasyDataApiBase, INewsServices
    {
        private static readonly string News = "News";
        private static readonly string NewsByDate = "NewsByDate";
        private static readonly string NewsByPlayerID = "NewsByPlayerID";

        public NewsServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }
        public Newses GetNews()
        {
            var url = string.Format("/{0}", News);
            return GetRequest<Newses>(url);
        }
        public Newses NewsbyDate(DateTime Date)
        {
            var url = string.Format("/{0}/{1}", NewsByDate, Date.ToApiDate());
            return GetRequest<Newses>(url);
        }

        public Newses NewsbyPlayer(string PlayerID)
        {
            var url = string.Format("/{0}/{1}", NewsByPlayerID, PlayerID);
            return GetRequest<Newses>(url);
        }
    }
}
