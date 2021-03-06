﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NBA.Entities
{    
    public class BoxScores : List<BoxScore>
    { }
    public class BoxScore
    {
        public BoxScore()
        {
            Game = new Game();
        }
        public Game Game { get; set; }
        public List<Quarter> Quarters { get; set; }        
        public List<TeamGame> TeamGames { get; set; }
        public List<PlayerGame> PlayerGames { get; set; }
    }
}
