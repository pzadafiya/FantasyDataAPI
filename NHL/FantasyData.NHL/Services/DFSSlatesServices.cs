using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.NHL.Entities;
using FantasyData.Utils;

namespace FantasyData.NHL.Services
{
    public interface IDFSSlatesService
    {
        DfsSlates GetDFSSlatesbyDate(DateTime Date);
    }
    public class DFSSlatesServices : FantasyDataApiBase, IDFSSlatesService
    {
        
        private static readonly string Key = "DfsSlatesByDate";

        public DFSSlatesServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }
                
        public DfsSlates GetDFSSlatesbyDate(DateTime Date)
        {
            var url = string.Format("/{0}/{1}", Key, Date.ToApiDate());
            return GetRequest<DfsSlates>(url);
        }
    }
}
