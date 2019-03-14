using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.MLB.Entities
{
    public class PlayerInfos : List<PlayerInfo>
    { }
    public class PlayerInfo
    {
        public int PlayerID { get; set; }

        public string Name { get; set; }

        public int? TeamID { get; set; }

        public string Team { get; set; }

        public string Position { get; set; }

    }
}
