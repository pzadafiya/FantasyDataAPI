using FantasyData.NFL.Contracts;
using FantasyData.NFL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Services
{
    public class HeadShotService : FantasyDataApiBase, IHeadShotService
    {
        public static readonly string HeadshotsKey = "Headshots";


        public HeadShotService(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
          : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }

        public Headshots Get()
        {
            var url = string.Format("/{0}", HeadshotsKey);
            return this.GetRequest<Headshots>(url);
        }
    }
}
