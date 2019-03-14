using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.NBA.Entities;
using FantasyData.Utils;

namespace FantasyData.NBA.Services
{
    public interface IPlayerServices
    {
        Players GetPlayerDetailsbyActive();
        Players GetPlayerDetailsbyFreeAgent();
        Players GetPlayerDetailsbyPlayerID(string playerid);
        Players GetPlayersbyTeam(string team);
    }
    public class PlayerServices : FantasyDataApiBase, IPlayerServices
    {
        private static readonly string Players = "Players";
        private static readonly string FreeAgents = "FreeAgents";
        private static readonly string Player = "Player";

        public PlayerServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }
        public Players GetPlayerDetailsbyActive()
        {
            var url = string.Format("/{0}", Players);
            return GetRequest<Players>(url);
        }
        public Players GetPlayerDetailsbyFreeAgent()
        {
            var url = string.Format("/{0}", FreeAgents);
            return GetRequest<Players>(url);
        }
        public Players GetPlayerDetailsbyPlayerID(string playerid)
        {
            var url = string.Format("/{0}/{1}", Player, playerid);
            return GetRequest<Players>(url);
        }
        public Players GetPlayersbyTeam(string team)
        {
            var url = string.Format("/{0}/{1}", Players, team);
            return GetRequest<Players>(url);
        }
    }
}
