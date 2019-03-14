using FantasyData.Soccer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Soccer.Services
{
    public interface IPlayerServices
    {
        Player Get(string PlayerID);
        Players GetAll();
        Players GetPlayesByTeam(string TeamID);
    }
    public class PlayerServices : FantasyDataApiBase, IPlayerServices
    {
        private static readonly string PlayerKey = "Player";
        private static readonly string PlayersKey = "Players";
        private static readonly string PlayersByTeamKey = "PlayersByTeam";
        

        public PlayerServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }

        public Player Get(string PlayerID)
        {
            var url = string.Format("/{0}/{1}", PlayerKey, PlayerID);
            return GetRequest<Player>(url);
        }

        public Players GetAll()
        {
            var url = string.Format("/{0}", PlayersKey);
            return GetRequest<Players>(url);
        }
        public Players GetPlayesByTeam(string TeamID)
        {
            var url = string.Format("/{0}/{1}", PlayersByTeamKey, TeamID);
            return GetRequest<Players>(url);
        }


    }
}
