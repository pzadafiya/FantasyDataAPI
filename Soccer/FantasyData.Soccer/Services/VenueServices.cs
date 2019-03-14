using FantasyData.Soccer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Soccer.Services
{
    public interface IVenueServices
    {
        Venues Get();
    }
    public class VenueServices : FantasyDataApiBase, IVenueServices
    {
        private static readonly string VenuesKey = "Venues";
        public VenueServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }

        public Venues Get()
        {
            var url = string.Format("/{0}", VenuesKey);
            return GetRequest<Venues>(url);
        }
    }
   
}
