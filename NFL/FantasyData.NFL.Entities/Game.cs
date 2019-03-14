﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Entities
{
  public class Games : List<Game>
  { }

  public class Game
  {
    public Game()
    {
      StadiumDetails = new StadiumDetails();
    }

    public int AwayAssistedTackles { get; set; }
    public int AwayBlockedKickReturnTouchdowns { get; set; }
    public int AwayBlockedKickReturnYards { get; set; }
    public int AwayBlockedKicks { get; set; }
    public decimal AwayCompletionPercentage { get; set; }
    public int AwayExtraPointKickingAttempts { get; set; }
    public int AwayExtraPointKickingConversions { get; set; }
    public int AwayExtraPointPassingAttempts { get; set; }
    public int AwayExtraPointPassingConversions { get; set; }
    public int AwayExtraPointRushingAttempts { get; set; }
    public int AwayExtraPointRushingConversions { get; set; }
    public int AwayExtraPointsHadBlocked { get; set; }
    public int AwayFieldGoalAttempts { get; set; }
    public int AwayFieldGoalReturnTouchdowns { get; set; }
    public int AwayFieldGoalReturnYards { get; set; }
    public int AwayFieldGoalsHadBlocked { get; set; }
    public int AwayFieldGoalsMade { get; set; }
    public int AwayFirstDowns { get; set; }
    public int AwayFirstDownsByPassing { get; set; }
    public int AwayFirstDownsByPenalty { get; set; }
    public int AwayFirstDownsByRushing { get; set; }
    public int AwayFourthDownAttempts { get; set; }
    public int AwayFourthDownConversions { get; set; }
    public decimal AwayFourthDownPercentage { get; set; }
    public int AwayFumbleReturnTouchdowns { get; set; }
    public int AwayFumbleReturnYards { get; set; }
    public int AwayFumbles { get; set; }
    public int AwayFumblesForced { get; set; }
    public int AwayFumblesLost { get; set; }
    public int AwayFumblesRecovered { get; set; }
    public int AwayGiveaways { get; set; }
    public int AwayGoalToGoAttempts { get; set; }
    public int AwayGoalToGoConversions { get; set; }
    public int AwayInterceptionReturnTouchdowns { get; set; }
    public int AwayInterceptionReturnYards { get; set; }
    public int AwayInterceptionReturns { get; set; }
    public int AwayKickReturnLong { get; set; }
    public int AwayKickReturnTouchdowns { get; set; }
    public int AwayKickReturnYards { get; set; }
    public int AwayKickReturns { get; set; }
    public int AwayKickoffTouchbacks { get; set; }
    public int AwayKickoffs { get; set; }
    public int AwayKickoffsInEndZone { get; set; }
    public int AwayOffensivePlays { get; set; }
    public int AwayOffensiveYards { get; set; }
    public decimal AwayOffensiveYardsPerPlay { get; set; }
    public decimal AwayPasserRating { get; set; }
    public int AwayPassesDefended { get; set; }
    public int AwayPassingAttempts { get; set; }
    public int AwayPassingCompletions { get; set; }
    public int AwayPassingInterceptions { get; set; }
    public int AwayPassingTouchdowns { get; set; }
    public int AwayPassingYards { get; set; }
    public decimal AwayPassingYardsPerAttempt { get; set; }
    public decimal AwayPassingYardsPerCompletion { get; set; }
    public int AwayPenalties { get; set; }
    public int AwayPenaltyYards { get; set; }
    public decimal AwayPuntAverage { get; set; }
    public decimal AwayPuntNetAverage { get; set; }
    public int AwayPuntNetYards { get; set; }
    public int AwayPuntReturnLong { get; set; }
    public int AwayPuntReturnTouchdowns { get; set; }
    public int AwayPuntReturnYards { get; set; }
    public int AwayPuntReturns { get; set; }
    public int AwayPuntYards { get; set; }
    public int AwayPunts { get; set; }
    public int AwayPuntsHadBlocked { get; set; }
    public int AwayQuarterbackHits { get; set; }
    public int AwayRedZoneAttempts { get; set; }
    public int AwayRedZoneConversions { get; set; }
    public int AwayReturnYards { get; set; }
    public int AwayRushingAttempts { get; set; }
    public int AwayRushingTouchdowns { get; set; }
    public int AwayRushingYards { get; set; }
    public decimal AwayRushingYardsPerAttempt { get; set; }
    public int AwaySackYards { get; set; }
    public int AwaySacks { get; set; }
    public int AwaySafeties { get; set; }
    public int AwayScore { get; set; }
    public int AwayScoreOvertime { get; set; }
    public int AwayScoreQuarter1 { get; set; }
    public int AwayScoreQuarter2 { get; set; }
    public int AwayScoreQuarter3 { get; set; }
    public int AwayScoreQuarter4 { get; set; }
    public int AwaySoloTackles { get; set; }
    public int AwayTacklesForLoss { get; set; }
    public int AwayTakeaways { get; set; }
    public string AwayTeam { get; set; }
    public int AwayThirdDownAttempts { get; set; }
    public int AwayThirdDownConversions { get; set; }
    public decimal AwayThirdDownPercentage { get; set; }
    public string AwayTimeOfPossession { get; set; }
    public int AwayTimesSacked { get; set; }
    public int AwayTimesSackedYards { get; set; }
    public int AwayTouchdowns { get; set; }
    public int AwayTurnoverDifferential { get; set; }
    public DateTime Date { get; set; }
    public int GameID { get; set; }
    public long GameKey { get; set; }
    public int HomeAssistedTackles { get; set; }
    public int HomeBlockedKickReturnTouchdowns { get; set; }
    public int HomeBlockedKickReturnYards { get; set; }
    public int HomeBlockedKicks { get; set; }
    public decimal HomeCompletionPercentage { get; set; }
    public int HomeExtraPointKickingAttempts { get; set; }
    public int HomeExtraPointKickingConversions { get; set; }
    public int HomeExtraPointPassingAttempts { get; set; }
    public int HomeExtraPointPassingConversions { get; set; }
    public int HomeExtraPointRushingAttempts { get; set; }
    public int HomeExtraPointRushingConversions { get; set; }
    public int HomeExtraPointsHadBlocked { get; set; }
    public int HomeFieldGoalAttempts { get; set; }
    public int HomeFieldGoalReturnTouchdowns { get; set; }
    public int HomeFieldGoalReturnYards { get; set; }
    public int HomeFieldGoalsHadBlocked { get; set; }
    public int HomeFieldGoalsMade { get; set; }
    public int HomeFirstDowns { get; set; }
    public int HomeFirstDownsByPassing { get; set; }
    public int HomeFirstDownsByPenalty { get; set; }
    public int HomeFirstDownsByRushing { get; set; }
    public int HomeFourthDownAttempts { get; set; }
    public int HomeFourthDownConversions { get; set; }
    public decimal HomeFourthDownPercentage { get; set; }
    public int HomeFumbleReturnTouchdowns { get; set; }
    public int HomeFumbleReturnYards { get; set; }
    public int HomeFumbles { get; set; }
    public int HomeFumblesForced { get; set; }
    public int HomeFumblesLost { get; set; }
    public int HomeFumblesRecovered { get; set; }
    public int HomeGiveaways { get; set; }
    public int HomeGoalToGoAttempts { get; set; }
    public int HomeGoalToGoConversions { get; set; }
    public int HomeInterceptionReturnTouchdowns { get; set; }
    public int HomeInterceptionReturnYards { get; set; }
    public int HomeInterceptionReturns { get; set; }
    public int HomeKickReturnLong { get; set; }
    public int HomeKickReturnTouchdowns { get; set; }
    public int HomeKickReturnYards { get; set; }
    public int HomeKickReturns { get; set; }
    public int HomeKickoffTouchbacks { get; set; }
    public int HomeKickoffs { get; set; }
    public int HomeKickoffsInEndZone { get; set; }
    public int HomeOffensivePlays { get; set; }
    public int HomeOffensiveYards { get; set; }
    public decimal HomeOffensiveYardsPerPlay { get; set; }
    public decimal HomePasserRating { get; set; }
    public int HomePassesDefended { get; set; }
    public int HomePassingAttempts { get; set; }
    public int HomePassingCompletions { get; set; }
    public int HomePassingInterceptions { get; set; }
    public int HomePassingTouchdowns { get; set; }
    public int HomePassingYards { get; set; }
    public decimal HomePassingYardsPerAttempt { get; set; }
    public decimal HomePassingYardsPerCompletion { get; set; }
    public int HomePenalties { get; set; }
    public int HomePenaltyYards { get; set; }
    public decimal HomePuntAverage { get; set; }
    public decimal HomePuntNetAverage { get; set; }
    public int HomePuntNetYards { get; set; }
    public int HomePuntReturnLong { get; set; }
    public int HomePuntReturnTouchdowns { get; set; }
    public int HomePuntReturnYards { get; set; }
    public int HomePuntReturns { get; set; }
    public int HomePuntYards { get; set; }
    public int HomePunts { get; set; }
    public int HomePuntsHadBlocked { get; set; }
    public int HomeQuarterbackHits { get; set; }
    public int HomeRedZoneAttempts { get; set; }
    public int HomeRedZoneConversions { get; set; }
    public int HomeReturnYards { get; set; }
    public int HomeRushingAttempts { get; set; }
    public int HomeRushingTouchdowns { get; set; }
    public int HomeRushingYards { get; set; }
    public decimal HomeRushingYardsPerAttempt { get; set; }
    public int HomeSackYards { get; set; }
    public int HomeSacks { get; set; }
    public int HomeSafeties { get; set; }
    public int HomeScore { get; set; }
    public int HomeScoreOvertime { get; set; }
    public int HomeScoreQuarter1 { get; set; }
    public int HomeScoreQuarter2 { get; set; }
    public int HomeScoreQuarter3 { get; set; }
    public int HomeScoreQuarter4 { get; set; }
    public int HomeSoloTackles { get; set; }
    public int HomeTacklesForLoss { get; set; }
    public int HomeTakeaways { get; set; }
    public string HomeTeam { get; set; }
    public int HomeThirdDownAttempts { get; set; }
    public int HomeThirdDownConversions { get; set; }
    public decimal HomeThirdDownPercentage { get; set; }
    public string HomeTimeOfPossession { get; set; }
    public int HomeTimesSacked { get; set; }
    public int HomeTimesSackedYards { get; set; }
    public int HomeTouchdowns { get; set; }
    public int HomeTurnoverDifferential { get; set; }
    public int Humidity { get; set; }
    public bool IsGameOver { get; set; }
    public decimal OverUnder { get; set; }
    public string PlayingSurface { get; set; }
    public int PointSpread { get; set; }
    public int Season { get; set; }
    public int SeasonType { get; set; }
    public string Stadium { get; set; }
    public int StadiumID { get; set; }
    public int Temperature { get; set; }
    public int TotalScore { get; set; }
    public int Week { get; set; }
    public int WindSpeed { get; set; }

    public StadiumDetails StadiumDetails { get; set; }
  }
}
