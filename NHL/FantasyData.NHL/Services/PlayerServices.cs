using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.NHL.Entities;

namespace FantasyData.NHL.Services
{
    public interface IPlayerService
    {
        Players GetPlayersDetail();
        Players GetPlayerDetailsbyFreeAgent();
        Players GetPlayerDetailsbyPlayer(string PlayerID);
        Players GetPlayersbyTeam(string Team);
    }
    public class PlayerServices : FantasyDataApiBase, IPlayerService
    {

        private static readonly string PlayersKey = "Players";
        private static readonly string PlayerDetailsbyFreeAgent = "FreeAgents";
        private static readonly string PlayerDetailsbyPlayer = "Player";

        public PlayerServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }

        public Players GetPlayersDetail()
        {
            var url = string.Format("/{0}", PlayersKey);
            return GetRequest<Players>(url);
        }

        public Players GetPlayerDetailsbyFreeAgent()
        {
            var url = string.Format("/{0}", PlayerDetailsbyFreeAgent);
            return GetRequest<Players>(url);
        }
        public Players GetPlayerDetailsbyPlayer(string PlayerID)
        {
            var url = string.Format("/{0}/{1}", PlayerDetailsbyPlayer, PlayerID);
            return GetRequest<Players>(url);
        }
        public Players GetPlayersbyTeam(string Team)
        {
            var url = string.Format("/{0}/{1}", PlayersKey, Team);
            return GetRequest<Players>(url);
        }
    }
}
