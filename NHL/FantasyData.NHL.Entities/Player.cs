﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NHL.Entities
{
    public class Players : List<Player>
    { }
    public class Player
    {
        public int PlayerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Status { get; set; }
        public int TeamID { get; set; }
        public string Team { get; set; }
        public string Position { get; set; }
        public int Jersey { get; set; }
        public string Catches { get; set; }
        public string Shoots { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public DateTime? BirthDate { get; set; }
        public string BirthCity { get; set; }
        public string BirthState { get; set; }
        public string PhotoUrl { get; set; }
        public string SportRadarPlayerID { get; set; }
        public int RotoworldPlayerID { get; set; }
        public int RotoWirePlayerID { get; set; }
        public int FantasyAlarmPlayerID { get; set; }
        public int StatsPlayerID { get; set; }
        public int SportsDirectPlayerID { get; set; }
        public int XmlTeamPlayerID { get; set; }
        public string InjuryStatus { get; set; }
        public string InjuryBodyPart { get; set; }
        public DateTime? InjuryStartDate { get; set; }
        public string InjuryNotes { get; set; }
        public int FanDuelPlayerID { get; set; }
        public int DraftKingsPlayerID { get; set; }
        public int YahooPlayerID { get; set; }
        public string FanDuelName { get; set; }
        public string DraftKingsName { get; set; }
        public string YahooName { get; set; }
        public string DepthChartPosition { get; set; }
        public int DepthChartOrder { get; set; }
        public int GlobalTeamID { get; set; }
        public string FantasyDraftName { get; set; }
        public int FantasyDraftPlayerID { get; set; }
    }
}
