using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.MLB.Entities
{
    public class DfsSlates : List<DfsSlate>
    { }
    public class DfsSlate
    {
        public int SlateID { get; set; }

        public string Operator { get; set; }

        public int? OperatorSlateID { get; set; }

        public string OperatorName { get; set; }

        public DateTime? OperatorDay { get; set; }

        public DateTime? OperatorStartTime { get; set; }

        public int? NumberOfGames { get; set; }

        public bool? IsMultiDaySlate { get; set; }

        public bool? RemovedByOperator { get; set; }

        public string OperatorGameType { get; set; }

        public DfsSlateGames DfsSlateGames { get; set; }

        public DfsSlatePlayers DfsSlatePlayers { get; set; }

    }

}
