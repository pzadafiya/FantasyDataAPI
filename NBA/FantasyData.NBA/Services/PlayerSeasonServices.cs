using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.NBA.Entities;

namespace FantasyData.NBA.Services
{
    public interface IPlayerSeasonServices
    {
        PlayerSeasons GetPlayerSeasonStats(string season);
    }
    public class PlayerSeasonServices : FantasyDataApiBase, IPlayerSeasonServices
    {

        private static readonly string PlayerSeasonStats = "PlayerSeasonStats";

        public PlayerSeasonServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }
        public PlayerSeasons GetPlayerSeasonStats(string season)
        {
            var url = string.Format("/{0}/{1}", PlayerSeasonStats, season);
            return GetRequest<PlayerSeasons>(url);
        }
    }
}
