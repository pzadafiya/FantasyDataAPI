using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.MLB.Entities
{
    public class Pitchs : List<Pitch>
    { }
    public class Pitch
    {
        public int PitchID { get; set; }

        public int PlayID { get; set; }

        public int? PitchNumberThisAtBat { get; set; }

        public int? PitcherID { get; set; }

        public int? HitterID { get; set; }

        public int? Outs { get; set; }

        public int? BallsBeforePitch { get; set; }

        public int? StrikesBeforePitch { get; set; }

        public bool? Strike { get; set; }

        public bool? Ball { get; set; }

        public bool? Foul { get; set; }

        public bool? Swinging { get; set; }

        public bool? Looking { get; set; }

    }

}
