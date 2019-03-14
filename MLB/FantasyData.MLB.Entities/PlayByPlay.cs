using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.MLB.Entities
{
    public class PlayByPlays : List<PlayByPlay>
    { }
    public class PlayByPlay
    {
        public PlayByPlay()
        {
            Game = new Game();
        }
        public Game Game { get; set; }
        public List<Play> Plays { get; set; }
    }
}
