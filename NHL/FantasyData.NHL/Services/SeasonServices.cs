using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.NHL.Entities;


namespace FantasyData.NHL.Services
{
    public interface ISeasonService
    {
        Seasons GetCurrentSeason();
    }
    public class SeasonServices : FantasyDataApiBase, ISeasonService
    {

        private static readonly string SeasonKey = "CurrentSeason";        

        public SeasonServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }
                
        public Seasons GetCurrentSeason()
        {
            var url = string.Format("/{0}", SeasonKey);
            return GetRequest<Seasons>(url);
        }       
    }
}
