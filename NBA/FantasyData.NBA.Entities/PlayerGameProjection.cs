﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NBA.Entities
{
    public class PlayerGameProjections : List<PlayerGameProjection>
    { }
    public class PlayerGameProjection
    {
        public int StatID { get; set; }

        public int? TeamID { get; set; }

        public int? PlayerID { get; set; }

        public int? SeasonType { get; set; }

        public int? Season { get; set; }

        public string Name { get; set; }

        public string Team { get; set; }

        public string Position { get; set; }

        public int? Started { get; set; }

        public int? FanDuelSalary { get; set; }

        public int? DraftKingsSalary { get; set; }

        public int? FantasyDataSalary { get; set; }

        public int? YahooSalary { get; set; }

        public string InjuryStatus { get; set; }

        public string InjuryBodyPart { get; set; }

        public DateTime? InjuryStartDate { get; set; }

        public string InjuryNotes { get; set; }

        public string FanDuelPosition { get; set; }

        public string DraftKingsPosition { get; set; }

        public string YahooPosition { get; set; }

        public int? OpponentRank { get; set; }

        public int? OpponentPositionRank { get; set; }

        public int? GlobalTeamID { get; set; }

        public int? FantasyDraftSalary { get; set; }

        public string FantasyDraftPosition { get; set; }

        public int? GameID { get; set; }

        public int? OpponentID { get; set; }

        public string Opponent { get; set; }

        public DateTime? Day { get; set; }

        public DateTime? DateTime { get; set; }

        public string HomeOrAway { get; set; }

        public bool IsGameOver { get; set; }

        public int? GlobalGameID { get; set; }

        public int? GlobalOpponentID { get; set; }

        public DateTime? Updated { get; set; }

        public int? Games { get; set; }

        public decimal? FantasyPoints { get; set; }

        public int? Minutes { get; set; }

        public int? Seconds { get; set; }

        public decimal? FieldGoalsMade { get; set; }

        public decimal? FieldGoalsAttempted { get; set; }

        public decimal? FieldGoalsPercentage { get; set; }

        public decimal? EffectiveFieldGoalsPercentage { get; set; }

        public decimal? TwoPointersMade { get; set; }

        public decimal? TwoPointersAttempted { get; set; }

        public decimal? TwoPointersPercentage { get; set; }

        public decimal? ThreePointersMade { get; set; }

        public decimal? ThreePointersAttempted { get; set; }

        public decimal? ThreePointersPercentage { get; set; }

        public decimal? FreeThrowsMade { get; set; }

        public decimal? FreeThrowsAttempted { get; set; }

        public decimal? FreeThrowsPercentage { get; set; }

        public decimal? OffensiveRebounds { get; set; }

        public decimal? DefensiveRebounds { get; set; }

        public decimal? Rebounds { get; set; }

        public decimal? OffensiveReboundsPercentage { get; set; }

        public decimal? DefensiveReboundsPercentage { get; set; }

        public decimal? TotalReboundsPercentage { get; set; }

        public decimal? Assists { get; set; }

        public decimal? Steals { get; set; }

        public decimal? BlockedShots { get; set; }

        public decimal? Turnovers { get; set; }

        public decimal? PersonalFouls { get; set; }

        public decimal? Points { get; set; }

        public decimal? TrueShootingAttempts { get; set; }

        public decimal? TrueShootingPercentage { get; set; }

        public decimal? PlayerEfficiencyRating { get; set; }

        public decimal? AssistsPercentage { get; set; }

        public decimal? StealsPercentage { get; set; }

        public decimal? BlocksPercentage { get; set; }

        public decimal? TurnOversPercentage { get; set; }

        public decimal? UsageRatePercentage { get; set; }

        public decimal? FantasyPointsFanDuel { get; set; }

        public decimal? FantasyPointsDraftKings { get; set; }

        public decimal? FantasyPointsYahoo { get; set; }

        public decimal? PlusMinus { get; set; }

        public decimal? DoubleDoubles { get; set; }

        public decimal? TripleDoubles { get; set; }

        public decimal? FantasyPointsFantasyDraft { get; set; }

    }

}
