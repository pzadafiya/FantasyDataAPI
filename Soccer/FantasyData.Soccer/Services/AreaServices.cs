using FantasyData;
using FantasyData.Soccer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Soccer.Services
{
    public interface IAreaServices
    {
        Areas Get();
    }
    public class AreaServices : FantasyDataApiBase, IAreaServices
    {
        private static readonly string AreasKey = "Areas";
        public AreaServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }

        public Areas Get()
        {
            var url = string.Format("/{0}", AreasKey);
            return GetRequest<Areas>(url);
        }
    }
}
