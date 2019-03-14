using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Soccer.Entities
{
    public class Memberships : List<Membership>
    { }
    public class Membership
    {
        public int MembershipId { get; set; }
        public int TeamId { get; set; }
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public string TeamName { get; set; }
        public string TeamArea { get; set; }
        public bool Active { get; set; }
        public string StartDate { get; set; }
        public object EndDate { get; set; }
        public string Updated { get; set; }
    }
}
