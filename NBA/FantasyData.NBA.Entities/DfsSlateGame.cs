using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NBA.Entities
{
    public class DfsSlateGames : List<DfsSlateGame>
    { }
    public class DfsSlateGame
    {
        public DfsSlateGame()
        {
            Game = new Game();
        }
        public int SlateGameID { get; set; }

        public int SlateID { get; set; }

        public int? GameID { get; set; }

        public int? OperatorGameID { get; set; }        
        public Game Game { get; set; }

    }

}
