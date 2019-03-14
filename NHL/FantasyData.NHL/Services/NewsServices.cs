using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.NHL.Entities;
using FantasyData.Utils;

namespace FantasyData.NHL.Services
{
    public interface INewsService
    {
        Newses GetNews();
        Newses GetNewsbyDate(DateTime date);
        Newses GetNewsbyPlayer(string PlayerID);
    }
    public class NewsServices : FantasyDataApiBase, INewsService
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

        public Newses GetNewsbyDate(DateTime date)
        {
            var url = string.Format("/{0}/{1}", NewsByDate,date.ToApiDate());
            return GetRequest<Newses>(url);
        }

        public Newses GetNewsbyPlayer(string PlayerID)
        {
            var url = string.Format("/{0}/{1}", NewsByPlayerID, PlayerID);
            return GetRequest<Newses>(url);
        }
    }    
}
