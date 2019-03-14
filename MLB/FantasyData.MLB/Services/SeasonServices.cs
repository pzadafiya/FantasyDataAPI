using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.MLB.Entities;
using FantasyData.Utils;

namespace FantasyData.MLB.Services
{
    public interface ISeasonServices
    {
        Seasons GetCurrentSeason();
    }
    public class SeasonServices : FantasyDataApiBase, ISeasonServices
    {
        private static readonly string CurrentSeason = "CurrentSeason";

        public SeasonServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }
        public Seasons GetCurrentSeason()
        {
            var url = string.Format("/{0}", CurrentSeason);
            return GetRequest<Seasons>(url);
        }
    }
}
