using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Entities
{
    public class DailyFantasyScorings : List<DailyFantasyScoring>
    {
    }
    public class DailyFantasyScoring
    {
        public int PlayerID { get; set; }
        public string Name { get; set; }
        public double FantasyPoints { get; set; }
        public bool HasStarted { get; set; }
        public bool IsInProgress { get; set; }
        public bool IsOver { get; set; }
        public DateTime? Date { get; set; }
    }
}
