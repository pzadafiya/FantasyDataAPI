using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.NBA.Entities;
using FantasyData.Utils;

namespace FantasyData.NBA.Services
{    
    public interface IDfsSlateServices
    {
        DfsSlates GetDFSSlatesbyDate(DateTime Date);
    }
    public class DfsSlateServices : FantasyDataApiBase, IDfsSlateServices
    {
        private static readonly string DfsSlatesByDate = "DfsSlatesByDate";        
        public DfsSlateServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }
        public DfsSlates GetDFSSlatesbyDate(DateTime Date)
        {
            var url = string.Format("/{0}/{1}", DfsSlatesByDate, Date.ToApiDate());
            return GetRequest<DfsSlates>(url);
        }       
    }
}
