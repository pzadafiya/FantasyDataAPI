﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Entities
{
    public class TeamSeasons : List<TeamSeason>
    {
    }
    public class TeamSeason
    {
        public int AssistedTackles { get; set; }
        public int BlockedKickReturnTouchdowns { get; set; }
        public int BlockedKickReturnYards { get; set; }
        public int BlockedKicks { get; set; }
        public double CompletionPercentage { get; set; }
        public int ExtraPointKickingAttempts { get; set; }
        public int ExtraPointKickingConversions { get; set; }
        public int ExtraPointPassingAttempts { get; set; }
        public int ExtraPointPassingConversions { get; set; }
        public int ExtraPointRushingAttempts { get; set; }
        public int ExtraPointRushingConversions { get; set; }
        public int ExtraPointsHadBlocked { get; set; }
        public int FieldGoalAttempts { get; set; }
        public int FieldGoalReturnTouchdowns { get; set; }
        public int FieldGoalReturnYards { get; set; }
        public int FieldGoalsHadBlocked { get; set; }
        public int FieldGoalsMade { get; set; }
        public int FirstDowns { get; set; }
        public int FirstDownsByPassing { get; set; }
        public int FirstDownsByPenalty { get; set; }
        public int FirstDownsByRushing { get; set; }
        public int FourthDownAttempts { get; set; }
        public int FourthDownConversions { get; set; }
        public double FourthDownPercentage { get; set; }
        public int FumbleReturnTouchdowns { get; set; }
        public int FumbleReturnYards { get; set; }
        public int Fumbles { get; set; }
        public int FumblesForced { get; set; }
        public int FumblesLost { get; set; }
        public int FumblesRecovered { get; set; }
        public int Games { get; set; }
        public int Giveaways { get; set; }
        public int GoalToGoAttempts { get; set; }
        public int GoalToGoConversions { get; set; }
        public double GoalToGoPercentage { get; set; }
        public int Humidity { get; set; }
        public int InterceptionReturnTouchdowns { get; set; }
        public int InterceptionReturnYards { get; set; }
        public int InterceptionReturns { get; set; }
        public int KickReturnLong { get; set; }
        public int KickReturnTouchdowns { get; set; }
        public int KickReturnYards { get; set; }
        public int KickReturns { get; set; }
        public int KickoffTouchbacks { get; set; }
        public int Kickoffs { get; set; }
        public int KickoffsInEndZone { get; set; }
        public int OffensivePlays { get; set; }
        public int OffensiveYards { get; set; }
        public double OffensiveYardsPerPlay { get; set; }
        public int OpponentAssistedTackles { get; set; }
        public int OpponentBlockedKickReturnTouchdowns { get; set; }
        public int OpponentBlockedKickReturnYards { get; set; }
        public int OpponentBlockedKicks { get; set; }
        public double OpponentCompletionPercentage { get; set; }
        public int OpponentExtraPointKickingAttempts { get; set; }
        public int OpponentExtraPointKickingConversions { get; set; }
        public int OpponentExtraPointPassingAttempts { get; set; }
        public int OpponentExtraPointPassingConversions { get; set; }
        public int OpponentExtraPointRushingAttempts { get; set; }
        public int OpponentExtraPointRushingConversions { get; set; }
        public int OpponentExtraPointsHadBlocked { get; set; }
        public int OpponentFieldGoalAttempts { get; set; }
        public int OpponentFieldGoalReturnTouchdowns { get; set; }
        public int OpponentFieldGoalReturnYards { get; set; }
        public int OpponentFieldGoalsHadBlocked { get; set; }
        public int OpponentFieldGoalsMade { get; set; }
        public int OpponentFirstDowns { get; set; }
        public int OpponentFirstDownsByPassing { get; set; }
        public int OpponentFirstDownsByPenalty { get; set; }
        public int OpponentFirstDownsByRushing { get; set; }
        public int OpponentFourthDownAttempts { get; set; }
        public int OpponentFourthDownConversions { get; set; }
        public double OpponentFourthDownPercentage { get; set; }
        public int OpponentFumbleReturnTouchdowns { get; set; }
        public int OpponentFumbleReturnYards { get; set; }
        public int OpponentFumbles { get; set; }
        public int OpponentFumblesForced { get; set; }
        public int OpponentFumblesLost { get; set; }
        public int OpponentFumblesRecovered { get; set; }
        public int OpponentGiveaways { get; set; }
        public int OpponentGoalToGoAttempts { get; set; }
        public int OpponentGoalToGoConversions { get; set; }
        public double OpponentGoalToGoPercentage { get; set; }
        public int OpponentInterceptionReturnTouchdowns { get; set; }
        public int OpponentInterceptionReturnYards { get; set; }
        public int OpponentInterceptionReturns { get; set; }
        public int OpponentKickReturnLong { get; set; }
        public int OpponentKickReturnTouchdowns { get; set; }
        public int OpponentKickReturnYards { get; set; }
        public int OpponentKickReturns { get; set; }
        public int OpponentKickoffTouchbacks { get; set; }
        public int OpponentKickoffs { get; set; }
        public int OpponentKickoffsInEndZone { get; set; }
        public int OpponentOffensivePlays { get; set; }
        public int OpponentOffensiveYards { get; set; }
        public double OpponentOffensiveYardsPerPlay { get; set; }
        public double OpponentPasserRating { get; set; }
        public int OpponentPassesDefended { get; set; }
        public int OpponentPassingAttempts { get; set; }
        public int OpponentPassingCompletions { get; set; }
        public int OpponentPassingDropbacks { get; set; }
        public int OpponentPassingInterceptions { get; set; }
        public int OpponentPassingTouchdowns { get; set; }
        public int OpponentPassingYards { get; set; }
        public double OpponentPassingYardsPerAttempt { get; set; }
        public double OpponentPassingYardsPerCompletion { get; set; }
        public int OpponentPenalties { get; set; }
        public int OpponentPenaltyYards { get; set; }
        public double OpponentPuntAverage { get; set; }
        public double OpponentPuntNetAverage { get; set; }
        public int OpponentPuntNetYards { get; set; }
        public int OpponentPuntReturnLong { get; set; }
        public int OpponentPuntReturnTouchdowns { get; set; }
        public int OpponentPuntReturnYards { get; set; }
        public int OpponentPuntReturns { get; set; }
        public int OpponentPuntYards { get; set; }
        public int OpponentPunts { get; set; }
        public int OpponentPuntsHadBlocked { get; set; }
        public int OpponentQuarterbackHits { get; set; }
        public int OpponentQuarterbackHitsDifferential { get; set; }
        public double OpponentQuarterbackHitsPercentage { get; set; }
        public int OpponentQuarterbackSacksDifferential { get; set; }
        public int OpponentRedZoneAttempts { get; set; }
        public int OpponentRedZoneConversions { get; set; }
        public double OpponentRedZonePercentage { get; set; }
        public int OpponentReturnYards { get; set; }
        public int OpponentRushingAttempts { get; set; }
        public int OpponentRushingTouchdowns { get; set; }
        public int OpponentRushingYards { get; set; }
        public double OpponentRushingYardsPerAttempt { get; set; }
        public int OpponentSackYards { get; set; }
        public int OpponentSacks { get; set; }
        public int OpponentSafeties { get; set; }
        public int OpponentScore { get; set; }
        public int OpponentScoreOvertime { get; set; }
        public int OpponentScoreQuarter1 { get; set; }
        public int OpponentScoreQuarter2 { get; set; }
        public int OpponentScoreQuarter3 { get; set; }
        public int OpponentScoreQuarter4 { get; set; }
        public int OpponentSoloTackles { get; set; }
        public int OpponentTacklesForLoss { get; set; }
        public int OpponentTacklesForLossDifferential { get; set; }
        public double OpponentTacklesForLossPercentage { get; set; }
        public int OpponentTakeaways { get; set; }
        public int OpponentThirdDownAttempts { get; set; }
        public int OpponentThirdDownConversions { get; set; }
        public double OpponentThirdDownPercentage { get; set; }
        public string OpponentTimeOfPossession { get; set; }
        public int OpponentTimesSacked { get; set; }
        public double OpponentTimesSackedPercentage { get; set; }
        public int OpponentTimesSackedYards { get; set; }
        public int OpponentTouchdowns { get; set; }
        public int OpponentTurnoverDifferential { get; set; }
        public double OverUnder { get; set; }
        public double PasserRating { get; set; }
        public int PassesDefended { get; set; }
        public int PassingAttempts { get; set; }
        public int PassingCompletions { get; set; }
        public int PassingDropbacks { get; set; }
        public int PassingInterceptions { get; set; }
        public int PassingTouchdowns { get; set; }
        public int PassingYards { get; set; }
        public double PassingYardsPerAttempt { get; set; }
        public double PassingYardsPerCompletion { get; set; }
        public int Penalties { get; set; }
        public int PenaltyYards { get; set; }
        public double PointSpread { get; set; }
        public double PuntAverage { get; set; }
        public double PuntNetAverage { get; set; }
        public int PuntNetYards { get; set; }
        public int PuntReturnLong { get; set; }
        public int PuntReturnTouchdowns { get; set; }
        public int PuntReturnYards { get; set; }
        public int PuntReturns { get; set; }
        public int PuntYards { get; set; }
        public int Punts { get; set; }
        public int PuntsHadBlocked { get; set; }
        public int QuarterbackHits { get; set; }
        public int QuarterbackHitsDifferential { get; set; }
        public double QuarterbackHitsPercentage { get; set; }
        public int QuarterbackSacksDifferential { get; set; }
        public int RedZoneAttempts { get; set; }
        public int RedZoneConversions { get; set; }
        public double RedZonePercentage { get; set; }
        public int ReturnYards { get; set; }
        public int RushingAttempts { get; set; }
        public int RushingTouchdowns { get; set; }
        public int RushingYards { get; set; }
        public double RushingYardsPerAttempt { get; set; }
        public int SackYards { get; set; }
        public int Sacks { get; set; }
        public int Safeties { get; set; }
        public int Score { get; set; }
        public int ScoreOvertime { get; set; }
        public int ScoreQuarter1 { get; set; }
        public int ScoreQuarter2 { get; set; }
        public int ScoreQuarter3 { get; set; }
        public int ScoreQuarter4 { get; set; }
        public int Season { get; set; }
        public int SeasonType { get; set; }
        public int SoloTackles { get; set; }
        public int TacklesForLoss { get; set; }
        public int TacklesForLossDifferential { get; set; }
        public double TacklesForLossPercentage { get; set; }
        public int Takeaways { get; set; }
        public string Team { get; set; }
        public string TeamName { get; set; }
        public int TeamSeasonID { get; set; }
        public int Temperature { get; set; }
        public int ThirdDownAttempts { get; set; }
        public int ThirdDownConversions { get; set; }
        public double ThirdDownPercentage { get; set; }
        public string TimeOfPossession { get; set; }
        public int TimesSacked { get; set; }
        public double TimesSackedPercentage { get; set; }
        public int TimesSackedYards { get; set; }
        public int TotalScore { get; set; }
        public int Touchdowns { get; set; }
        public int TurnoverDifferential { get; set; }
        public int WindSpeed { get; set; }
    }
}