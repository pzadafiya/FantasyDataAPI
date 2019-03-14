using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.NHL.Entities;

namespace FantasyData.NHL.Services
{

    public interface IStadiumService
    {
        Stadiums getStadiums();
    }
    public class StadiumServices : FantasyDataApiBase, IStadiumService
    {

        private static readonly string StadiumKey = "Stadiums";

        public StadiumServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }

        public Stadiums getStadiums()
        {
            var url = string.Format("/{0}", StadiumKey);
            return GetRequest<Stadiums>(url);
        }
    }
}
