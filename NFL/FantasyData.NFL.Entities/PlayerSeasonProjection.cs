using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Entities
{
    public class PlayerSeasonProjections : List<PlayerSeasonProjection>
    { }
    public class PlayerSeasonProjection
    {
        public int PlayerID { get; set; }

        public int SeasonType { get; set; }

        public int Season { get; set; }

        public string Team { get; set; }

        public int Number { get; set; }

        public string Name { get; set; }

        public string Position { get; set; }

        public string PositionCategory { get; set; }

        public int Activated { get; set; }

        public int Played { get; set; }

        public int Started { get; set; }

        public decimal PassingAttempts { get; set; }

        public decimal PassingCompletions { get; set; }

        public decimal PassingYards { get; set; }

        public decimal PassingCompletionPercentage { get; set; }

        public decimal PassingYardsPerAttempt { get; set; }

        public decimal PassingYardsPerCompletion { get; set; }

        public decimal PassingTouchdowns { get; set; }

        public decimal PassingInterceptions { get; set; }

        public decimal PassingRating { get; set; }

        public decimal PassingLong { get; set; }

        public decimal PassingSacks { get; set; }

        public decimal PassingSackYards { get; set; }

        public decimal RushingAttempts { get; set; }

        public decimal RushingYards { get; set; }

        public decimal RushingYardsPerAttempt { get; set; }

        public decimal RushingTouchdowns { get; set; }

        public decimal RushingLong { get; set; }

        public decimal? ReceivingTargets { get; set; }

        public decimal Receptions { get; set; }

        public decimal ReceivingYards { get; set; }

        public decimal ReceivingYardsPerReception { get; set; }

        public decimal ReceivingTouchdowns { get; set; }

        public decimal ReceivingLong { get; set; }

        public decimal Fumbles { get; set; }

        public decimal? FumblesLost { get; set; }

        public decimal PuntReturns { get; set; }

        public decimal PuntReturnYards { get; set; }

        public decimal PuntReturnYardsPerAttempt { get; set; }

        public decimal PuntReturnTouchdowns { get; set; }

        public decimal PuntReturnLong { get; set; }

        public decimal KickReturns { get; set; }

        public decimal KickReturnYards { get; set; }

        public decimal KickReturnYardsPerAttempt { get; set; }

        public decimal KickReturnTouchdowns { get; set; }

        public decimal KickReturnLong { get; set; }

        public decimal SoloTackles { get; set; }

        public decimal AssistedTackles { get; set; }

        public decimal? TacklesForLoss { get; set; }

        public decimal Sacks { get; set; }

        public decimal SackYards { get; set; }

        public decimal? QuarterbackHits { get; set; }

        public decimal PassesDefended { get; set; }

        public decimal FumblesForced { get; set; }

        public decimal FumblesRecovered { get; set; }

        public decimal FumbleReturnYards { get; set; }

        public decimal FumbleReturnTouchdowns { get; set; }

        public decimal Interceptions { get; set; }

        public decimal InterceptionReturnYards { get; set; }

        public decimal InterceptionReturnTouchdowns { get; set; }

        public decimal BlockedKicks { get; set; }

        public decimal SpecialTeamsSoloTackles { get; set; }

        public decimal SpecialTeamsAssistedTackles { get; set; }

        public decimal MiscSoloTackles { get; set; }

        public decimal MiscAssistedTackles { get; set; }

        public decimal Punts { get; set; }

        public decimal PuntYards { get; set; }

        public decimal PuntAverage { get; set; }

        public decimal FieldGoalsAttempted { get; set; }

        public decimal FieldGoalsMade { get; set; }

        public decimal FieldGoalsLongestMade { get; set; }

        public decimal ExtraPointsMade { get; set; }

        public decimal TwoPointConversionPasses { get; set; }

        public decimal TwoPointConversionRuns { get; set; }

        public decimal TwoPointConversionReceptions { get; set; }

        public decimal FantasyPoints { get; set; }

        public decimal FantasyPointsPPR { get; set; }

        public decimal ReceptionPercentage { get; set; }

        public decimal ReceivingYardsPerTarget { get; set; }

        public decimal Tackles { get; set; }

        public decimal OffensiveTouchdowns { get; set; }

        public decimal DefensiveTouchdowns { get; set; }

        public decimal SpecialTeamsTouchdowns { get; set; }

        public decimal Touchdowns { get; set; }

        public string FantasyPosition { get; set; }

        public decimal FieldGoalPercentage { get; set; }

        public int PlayerSeasonID { get; set; }

        public decimal? FumblesOwnRecoveries { get; set; }

        public decimal? FumblesOutOfBounds { get; set; }

        public decimal? KickReturnFairCatches { get; set; }

        public decimal? PuntReturnFairCatches { get; set; }

        public decimal? PuntTouchbacks { get; set; }

        public decimal? PuntInside20 { get; set; }

        public decimal? PuntNetAverage { get; set; }

        public decimal? ExtraPointsAttempted { get; set; }

        public decimal? BlockedKickReturnTouchdowns { get; set; }

        public decimal? FieldGoalReturnTouchdowns { get; set; }

        public decimal? Safeties { get; set; }

        public decimal? FieldGoalsHadBlocked { get; set; }

        public decimal? PuntsHadBlocked { get; set; }

        public decimal? ExtraPointsHadBlocked { get; set; }

        public decimal? PuntLong { get; set; }

        public decimal? BlockedKickReturnYards { get; set; }

        public decimal? FieldGoalReturnYards { get; set; }

        public decimal? PuntNetYards { get; set; }

        public decimal? SpecialTeamsFumblesForced { get; set; }

        public decimal? SpecialTeamsFumblesRecovered { get; set; }

        public decimal? MiscFumblesForced { get; set; }

        public decimal? MiscFumblesRecovered { get; set; }

        public string ShortName { get; set; }

        public decimal? SafetiesAllowed { get; set; }

        public int? Temperature { get; set; }

        public int? Humidity { get; set; }

        public int? WindSpeed { get; set; }

        public int? OffensiveSnapsPlayed { get; set; }

        public int? DefensiveSnapsPlayed { get; set; }

        public int? SpecialTeamsSnapsPlayed { get; set; }

        public int? OffensiveTeamSnaps { get; set; }

        public int? DefensiveTeamSnaps { get; set; }

        public int? SpecialTeamsTeamSnaps { get; set; }

        public decimal? AuctionValue { get; set; }

        public decimal? AuctionValuePPR { get; set; }

        public decimal? TwoPointConversionReturns { get; set; }

        public decimal? FantasyPointsFanDuel { get; set; }

        public decimal? FieldGoalsMade0to19 { get; set; }

        public decimal? FieldGoalsMade20to29 { get; set; }

        public decimal? FieldGoalsMade30to39 { get; set; }

        public decimal? FieldGoalsMade40to49 { get; set; }

        public decimal? FieldGoalsMade50Plus { get; set; }

        public decimal? FantasyPointsDraftKings { get; set; }

        public decimal? FantasyPointsYahoo { get; set; }

        public decimal? AverageDraftPosition { get; set; }

        public decimal? AverageDraftPositionPPR { get; set; }

        public int? TeamID { get; set; }

        public int? GlobalTeamID { get; set; }

        public decimal? FantasyPointsFantasyDraft { get; set; }

        public ScoringDetails ScoringDetails { get; set; }

        public decimal? AverageDraftPositionRookie { get; set; }

        public decimal? AverageDraftPositionDynasty { get; set; }

        public decimal? AverageDraftPosition2QB { get; set; }

    }

}
