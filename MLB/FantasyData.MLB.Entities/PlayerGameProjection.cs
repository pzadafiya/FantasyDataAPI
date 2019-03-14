using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.MLB.Entities
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

        public string PositionCategory { get; set; }

        public int? Started { get; set; }

        public int? BattingOrder { get; set; }

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

        public decimal? AtBats { get; set; }

        public decimal? Runs { get; set; }

        public decimal? Hits { get; set; }

        public decimal? Singles { get; set; }

        public decimal? Doubles { get; set; }

        public decimal? Triples { get; set; }

        public decimal? HomeRuns { get; set; }

        public decimal? RunsBattedIn { get; set; }

        public decimal? BattingAverage { get; set; }

        public decimal? Outs { get; set; }

        public decimal? Strikeouts { get; set; }

        public decimal? Walks { get; set; }

        public decimal? HitByPitch { get; set; }

        public decimal? Sacrifices { get; set; }

        public decimal? SacrificeFlies { get; set; }

        public decimal? GroundIntoDoublePlay { get; set; }

        public decimal? StolenBases { get; set; }

        public decimal? CaughtStealing { get; set; }

        public decimal? PitchesSeen { get; set; }

        public decimal? OnBasePercentage { get; set; }

        public decimal? SluggingPercentage { get; set; }

        public decimal? OnBasePlusSlugging { get; set; }

        public decimal? Errors { get; set; }

        public decimal? Wins { get; set; }

        public decimal? Losses { get; set; }

        public decimal? Saves { get; set; }

        public decimal? InningsPitchedDecimal { get; set; }

        public decimal? TotalOutsPitched { get; set; }

        public decimal? InningsPitchedFull { get; set; }

        public decimal? InningsPitchedOuts { get; set; }

        public decimal? EarnedRunAverage { get; set; }

        public decimal? PitchingHits { get; set; }

        public decimal? PitchingRuns { get; set; }

        public decimal? PitchingEarnedRuns { get; set; }

        public decimal? PitchingWalks { get; set; }

        public decimal? PitchingStrikeouts { get; set; }

        public decimal? PitchingHomeRuns { get; set; }

        public decimal? PitchesThrown { get; set; }

        public decimal? PitchesThrownStrikes { get; set; }

        public decimal? WalksHitsPerInningsPitched { get; set; }

        public decimal? PitchingBattingAverageAgainst { get; set; }

        public decimal? GrandSlams { get; set; }

        public decimal? FantasyPointsFanDuel { get; set; }

        public decimal? FantasyPointsDraftKings { get; set; }

        public decimal? FantasyPointsYahoo { get; set; }

        public decimal? PlateAppearances { get; set; }

        public decimal? TotalBases { get; set; }

        public decimal? FlyOuts { get; set; }

        public decimal? GroundOuts { get; set; }

        public decimal? LineOuts { get; set; }

        public decimal? PopOuts { get; set; }

        public decimal? IntentionalWalks { get; set; }

        public decimal? ReachedOnError { get; set; }

        public decimal? BallsInPlay { get; set; }

        public decimal? BattingAverageOnBallsInPlay { get; set; }

        public decimal? WeightedOnBasePercentage { get; set; }

        public decimal? PitchingSingles { get; set; }

        public decimal? PitchingDoubles { get; set; }

        public decimal? PitchingTriples { get; set; }

        public decimal? PitchingGrandSlams { get; set; }

        public decimal? PitchingHitByPitch { get; set; }

        public decimal? PitchingSacrifices { get; set; }

        public decimal? PitchingSacrificeFlies { get; set; }

        public decimal? PitchingGroundIntoDoublePlay { get; set; }

        public decimal? PitchingCompleteGames { get; set; }

        public decimal? PitchingShutOuts { get; set; }

        public decimal? PitchingNoHitters { get; set; }

        public decimal? PitchingPerfectGames { get; set; }

        public decimal? PitchingPlateAppearances { get; set; }

        public decimal? PitchingTotalBases { get; set; }

        public decimal? PitchingFlyOuts { get; set; }

        public decimal? PitchingGroundOuts { get; set; }

        public decimal? PitchingLineOuts { get; set; }

        public decimal? PitchingPopOuts { get; set; }

        public decimal? PitchingIntentionalWalks { get; set; }

        public decimal? PitchingReachedOnError { get; set; }

        public decimal? PitchingCatchersInterference { get; set; }

        public decimal? PitchingBallsInPlay { get; set; }

        public decimal? PitchingOnBasePercentage { get; set; }

        public decimal? PitchingSluggingPercentage { get; set; }

        public decimal? PitchingOnBasePlusSlugging { get; set; }

        public decimal? PitchingStrikeoutsPerNineInnings { get; set; }

        public decimal? PitchingWalksPerNineInnings { get; set; }

        public decimal? PitchingBattingAverageOnBallsInPlay { get; set; }

        public decimal? PitchingWeightedOnBasePercentage { get; set; }

        public decimal? DoublePlays { get; set; }

        public decimal? PitchingDoublePlays { get; set; }

        public bool? BattingOrderConfirmed { get; set; }

        public decimal? IsolatedPower { get; set; }

        public decimal? FieldingIndependentPitching { get; set; }

        public decimal? PitchingQualityStarts { get; set; }

        public int? PitchingInningStarted { get; set; }

        public decimal? LeftOnBase { get; set; }

        public decimal? PitchingHolds { get; set; }

        public decimal? PitchingBlownSaves { get; set; }

        public int? SubstituteBattingOrder { get; set; }

        public int? SubstituteBattingOrderSequence { get; set; }

        public decimal? FantasyPointsFantasyDraft { get; set; }

    }

}
