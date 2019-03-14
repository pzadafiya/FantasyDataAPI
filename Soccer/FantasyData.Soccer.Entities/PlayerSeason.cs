﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Soccer.Entities
{
    public class PlayerSeasons : List<PlayerSeason> { }
    public class PlayerSeason
    {
        public int StatId { get; set; }
        public int SeasonType { get; set; }
        public int Season { get; set; }
        public int RoundId { get; set; }
        public int TeamId { get; set; }
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Team { get; set; }
        public string PositionCategory { get; set; }
        public string Position { get; set; }
        public int Started { get; set; }
        public DateTime? Updated { get; set; }
        public int Games { get; set; }
        public decimal FantasyPoints { get; set; }
        public decimal FantasyPointsFanDuel { get; set; }
        public decimal FantasyPointsDraftKings { get; set; }
        public decimal FantasyPointsYahoo { get; set; }
        public decimal FantasyPointsMondogoal { get; set; }
        public decimal Minutes { get; set; }
        public decimal Goals { get; set; }
        public decimal Assists { get; set; }
        public decimal Shots { get; set; }
        public decimal ShotsOnGoal { get; set; }
        public decimal YellowCards { get; set; }
        public decimal RedCards { get; set; }
        public decimal YellowRedCards { get; set; }
        public decimal Crosses { get; set; }
        public decimal TacklesWon { get; set; }
        public decimal Interceptions { get; set; }
        public decimal OwnGoals { get; set; }
        public decimal Fouls { get; set; }
        public decimal Fouled { get; set; }
        public decimal Offsides { get; set; }
        public decimal Passes { get; set; }
        public decimal PassesCompleted { get; set; }
        public decimal LastManTackle { get; set; }
        public decimal CornersWon { get; set; }
        public decimal BlockedShots { get; set; }
        public decimal DefenderCleanSheets { get; set; }
        public decimal GoalkeeperSaves { get; set; }
        public decimal GoalkeeperGoalsAgainst { get; set; }
        public decimal GoalkeeperSingleGoalAgainst { get; set; }
        public decimal GoalkeeperCleanSheets { get; set; }
        public decimal GoalkeeperWins { get; set; }
        public decimal PenaltyKickGoals { get; set; }
        public decimal PenaltyKickMisses { get; set; }
        public decimal PenaltyKickSaves { get; set; }
    }
}
