using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Entities
{

    public class Headshots : List<Headshot>
    { }
    public class Headshot
    {
            public int PlayerID { get; set; }
            public string Name { get; set; }
            public int? TeamID { get; set; }
            public string Team { get; set; }
            public string Position { get; set; }
            public string PreferredHostedHeadshotUrl { get; set; }
            public DateTime? PreferredHostedHeadshotUpdated { get; set; }
            public string HostedHeadshotWithBackgroundUrl { get; set; }
            public DateTime? HostedHeadshotWithBackgroundUpdated { get; set; }
            public string HostedHeadshotNoBackgroundUrl { get; set; }
            public DateTime? HostedHeadshotNoBackgroundUpdated { get; set; }
       

    }
}
