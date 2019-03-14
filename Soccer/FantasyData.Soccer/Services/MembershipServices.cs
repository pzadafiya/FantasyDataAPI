using FantasyData.Soccer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Soccer.Services
{
   
    public interface IMembershipServices
    {
        Memberships GetActiveMembership(int TeamID);
        Memberships GetActiveMembership();
        Memberships GetHistoricalMembership(int TeamID);
    }
    public class MembershipServices : FantasyDataApiBase, IMembershipServices
    {
        private static readonly string MembershipsByTeamKey = "MembershipsByTeam";
        private static readonly string HistoricalMembershipsByTeamKey = "HistoricalMembershipsByTeam";
        private static readonly string ActiveMembershipsKey = "ActiveMemberships";

        public MembershipServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date">Game date format : yyyy-MM-dd</param>
        /// <returns></returns>
        public Memberships GetActiveMembership(int TeamID)
        {
            var url = string.Format("/{0}/{1}", MembershipsByTeamKey, TeamID);
            return GetRequest<Memberships>(url);
        }
        public Memberships GetActiveMembership()
        {
            var url = string.Format("/{0}", ActiveMembershipsKey);
            return GetRequest<Memberships>(url);
        }
        public Memberships GetHistoricalMembership(int TeamID)
        {
            var url = string.Format("/{0}/{1}", HistoricalMembershipsByTeamKey, TeamID);
            return GetRequest<Memberships>(url);
        }
    }
}
