using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.MLB.Entities;
using FantasyData.Utils;

namespace FantasyData.MLB.Services
{
    public interface IStadiumsServices
    {
        Stadiums GetStadiums();
    }
    public class StadiumsServices : FantasyDataApiBase, IStadiumsServices
    {
        private static readonly string Stadiums = "Stadiums";

        public StadiumsServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }
        public Stadiums GetStadiums()
        {
            var url = string.Format("/{0}", Stadiums);
            return GetRequest<Stadiums>(url);
        }
    }
}
