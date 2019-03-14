﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Entities
{
    public class DailyFantasyPlayers : List<DailyFantasyPlayer>
    { }

    public class DailyFantasyPlayer
    {
        public DateTime Date { get; set; }
        public decimal LastGameFantasyPoints { get; set; }
        public string Name { get; set; }
        public string Opponent { get; set; }
        public int OpponentPositionRank { get; set; }
        public int OpponentRank { get; set; }
        public int PlayerID { get; set; }
        public string Position { get; set; }
        public decimal ProjectedFantasyPoints { get; set; }
        public int Salary { get; set; }
        public string ShortName { get; set; }
        public string Status { get; set; }
        public string StatusCode { get; set; }
        public string StatusColor { get; set; }
        public string Team { get; set; }
        public int? FanDuelSalary { get; set; }
        public int? FantasyDraftSalary { get; set; }
        public int? DraftKingsSalary { get; set; }
        public int? YahooSalary { get; set; }
        public int? FantasyDataSalary { get; set; }
    }
}
