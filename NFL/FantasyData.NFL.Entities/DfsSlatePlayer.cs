using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Entities
{
    public class DfsSlatePlayers : List<DfsSlatePlayer>
    { }
    public class DfsSlatePlayer
    {
        public int SlatePlayerID { get; set; }

        public int SlateID { get; set; }

        public int? SlateGameID { get; set; }

        public int? PlayerID { get; set; }

        public int? PlayerGameProjectionStatID { get; set; }

        public int? FantasyDefenseProjectionStatID { get; set; }

        public string OperatorPlayerID { get; set; }

        public string OperatorSlatePlayerID { get; set; }

        public string OperatorPlayerName { get; set; }

        public string OperatorPosition { get; set; }

        public string OperatorRosterSlots { get; set; }

        public int? OperatorSalary { get; set; }

        public string Team { get; set; }

        public int? TeamID { get; set; }

        public bool? RemovedByOperator { get; set; }

    }

}
