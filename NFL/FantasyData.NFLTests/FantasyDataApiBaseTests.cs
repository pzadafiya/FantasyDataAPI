﻿using FantasyData.NFL.Entities;
using FantasyData.NFL.Contracts;
using FantasyData.NFL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace FantasyDataTests
{
    [TestClass]
    public class FantasyDataApiBaseTests
    {
        [TestMethod]
        public void Headshot_Get()
        {
            var client = new FantasyDataClient();

            var response = client.HeadShotService.Get();

            Assert.IsTrue(response.Any());
        }

        [TestMethod]
        public void Injury_Week_Get()
        {
            var client = new FantasyDataClient();

            var response = client.InjuryService.GetByWeek(2024 + "POST",1);

            Assert.IsTrue(response.Any());
        }

        /// <summary>
        /// Check If Games In Progress integration test
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/5484ddab35491a1278264f26/operations/5484ddab35491a0fa8f59f70/console</url>
        [TestMethod]
        public void CheckIfGameInProgress_Return_False()
        {
            var client = new FantasyDataClient();

            var response = client.SeasonService.IsGameInProgress;

            Assert.IsFalse(response);
        }

        /// <summary>
        /// Get Daily Fantasy Players integration test
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/5484ddab35491a1278264f26/operations/5484ddab35491a0fa8f59fa5/console</url>
        [TestMethod]
        public void DailyFantasyPlayers_2014_SEP_21_Count_Equals_514()
        {
            var client = new FantasyDataClient();
            var results = client.DailyFantasyService.GetDailyFantasyPlayers(new DateTime(2017, 9, 13));
            Debug.WriteLine(results.ToList().Count);
            Assert.IsTrue(results.Count == 514);
        }

        /// <summary>
        /// Get Active Box Scores integration test.
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/5484ddab35491a1278264f26/operations/5484ddab35491a0fa8f59f96/console</url>
        [TestMethod]
        public void GetActiveBoxScores_Count_Equals_Zero()
        {
            var client = new FantasyDataClient();
            var results = client.BoxScoreService.GetActive();
            Debug.WriteLine(results.ToList().Count);
            Assert.IsTrue(results.Count == 0);
        }

        /// <summary>
        /// Get Active Teams integration test.
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/5484ddab35491a1278264f26/operations/5484ddab35491a0fa8f59f9c/console</url>
        [TestMethod]
        public void GetActiveTeams_Count_Equals_32()
        {
            var client = new FantasyDataClient();
            var results = client.TeamService.Get();
            Assert.IsTrue(results.Count == 32);
        }

        /// <summary>
        /// Get Box Score integration test
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/5484ddab35491a1278264f26/operations/5484ddab35491a0fa8f59f8f/console</url>
        [TestMethod]
        public void GetBoxScore_2014_Week1_WAS_AwayAssistedTackles_Equals_10()
        {
            var client = new FantasyDataClient();
            var result = client.BoxScoreService.Get("2014", 1, "WAS");
            Assert.IsTrue(result.Game.AwayAssistedTackles == 10);
        }

        /// <summary>
        /// Get Box Scores for Season for Week integration test.
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/5484ddab35491a1278264f26/operations/5484ddab35491a0fa8f59f97/console</url>
        [TestMethod]
        public void GetBoxScoresForSeasonWeek_2014_Week1_Count_Equals_16()
        {
            var client = new FantasyDataClient();
            var result = client.BoxScoreService.GetForSeasonAndWeek("2014", 1);
            Assert.IsTrue(result.Count == 16);
        }

        /// <summary>
        /// Get Bye Week for Season integration test.
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/5484ddab35491a1278264f26/operations/5484ddab35491a0fa8f59f79/console</url>
        [TestMethod]
        public void GetByWeekForSeason_2014_Count_Equals_32()
        {
            var client = new FantasyDataClient();
            var result = client.SeasonService.GetByeWeeks("2014");
            Assert.IsTrue(result.Count == 32);
        }


        /// <summary>
        /// Get Current Season integration test.
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/5484ddab35491a1278264f26/operations/5484ddab35491a0fa8f59f72/console</url>
        [TestMethod]
        public void CurrentSeason_Is_2014()
        {
            var client = new FantasyDataClient();
            var response = client.SeasonService.CurrentSeason;
            Assert.IsTrue(response == 2014);
        }

        /// <summary>
        /// Get Current Week integration test.
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/5484ddab35491a1278264f26/operations/5484ddab35491a0fa8f59f75/console</url>
        [TestMethod]
        public void CurrentWeek_Is_0()
        {
            var client = new FantasyDataClient();
            var response = client.SeasonService.CurrentWeek;
            Assert.IsTrue(response == 0);
        }

        /// <summary>
        /// Get Delta Box Scores integration test.
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/5484ddab35491a1278264f26/operations/5484ddab35491a0fa8f59fa4/console</url>
        [TestMethod]
        public void GetDeltaBoxScores_Last_1_Minutes_Count_Equals_Zero()
        {
            var client = new FantasyDataClient();
            var response = client.BoxScoreService.RecentlyUpdated(1);
            Assert.IsTrue(response.Count == 0);
        }


        /// <summary>
        /// Get Fantasy Defense By Game integration test.
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/5484ddab35491a1278264f26/operations/5484ddab35491a0fa8f59f88/console</url>
        [TestMethod]
        public void GetFantasyDefenseByGame_2014_Week_1_Count_Equals_32()
        {
            var client = new FantasyDataClient();
            var response = client.TeamDefenseService.GetGames("2014", 1);
            Assert.IsTrue(response.Count == 32);
        }

        /// <summary>
        /// Get Fantasy Defense for Season integration test.
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/5484ddab35491a1278264f26/operations/5484ddab35491a0fa8f59f89/console</url>
        [TestMethod]
        public void GetFantasyDefenseForSeason_2014_Count_Equals_32()
        {
            var client = new FantasyDataClient();
            var response = client.TeamDefenseService.GetSeasons("2014");
            Assert.IsTrue(response.Count == 32);
        }

        /// <summary>
        /// Get Final Box Scores integration test.
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/5484ddab35491a1278264f26/operations/5484ddab35491a0fa8f59f89/console</url>
        [TestMethod]
        public void GetFinalBoxScores_Count_Equals_Zero()
        {
            var client = new FantasyDataClient();
            var response = client.BoxScoreService.GetFinal();
            Assert.IsTrue(response.Count == 0);
        }

        /// <summary>
        /// Get Free Agents integration test
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/5484ddab35491a1278264f26/operations/5484ddab35491a0fa8f59f81/console</url>
        [TestMethod]
        public void GetFreeAgents_Count_Greater_Than_Zero()
        {
            var client = new FantasyDataClient();
            var response = client.PlayerService.GetFreeAgents();
            Assert.IsTrue(response.Count > 0);
        }

        /// <summary>
        /// Get Game Scores for Season integration test
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/5484ddab35491a1278264f26/operations/5484ddab35491a0fa8f59f7a/console</url>
        [TestMethod]
        public void GetGameScoresForSeason_2014_Count_Equals_256()
        {
            var client = new FantasyDataClient();
            var response = client.SeasonService.GetScores("2014");
            Assert.IsTrue(response.Count == 256);
        }

        /// <summary>
        /// Get Game Stats for Season integration test
        /// </summary> 
        /// <url>https://developer.fantasydata.com/docs/services/5484ddab35491a1278264f26/operations/5484ddab35491a0fa8f59f92/console</url>
        [TestMethod]
        public void GetGameStatsForSeason_2014_Count_Equals_256()
        {
            var client = new FantasyDataClient();
            var response = client.GameService.GetBySeason("2014");
            Assert.IsTrue(response.Count == 256);
        }

        /// <summary>
        /// Get Game Stats for Week integration test
        /// </summary> 
        /// <url>https://developer.fantasydata.com/docs/services/5484ddab35491a1278264f26/operations/5484ddab35491a0fa8f59f93/console</url>
        [TestMethod]
        public void GetGameStatsForSeason_2014_Week1_Count_Equals_16()
        {
            var client = new FantasyDataClient();
            var response = client.GameService.GetByWeek("2014", 1);
            Assert.IsTrue(response.Count == 16);
        }

        /// <summary>
        /// Get Injuries for Season for Week integration test
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/5484ddab35491a1278264f26/operations/5484ddab35491a0fa8f59f8a/console</url>
        [TestMethod]
        public void GetInjuriesForSeasonAndWeek_2014_Week1_Count_Equals_308()
        {
            var client = new FantasyDataClient();
            var response = client.InjuryService.GetByWeek("2014", 1);
            Assert.IsTrue(response.Count == 308);
        }

        /// <summary>
        /// Get Injuries for Season for Week for Team integration test
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/5484ddab35491a1278264f26/operations/5484ddab35491a0fa8f59f8a/console</url>
        [TestMethod]
        public void GetInjuriesForSeasonAndWeekForTeam_2014_Week1_DEN_Count_Equals_10()
        {
            var client = new FantasyDataClient();
            var response = client.InjuryService.GetByWeekAndTeam(TeamTypes.DEN, "2014", 1);
            Assert.IsTrue(response.Count == 10);
        }

        /// <summary>
        /// Get Last Completed Season integration test.
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/5484ddab35491a1278264f26/operations/5484ddab35491a0fa8f59f71/console</url>
        [TestMethod]
        public void LastCompletedSeason_Is_2014()
        {
            var client = new FantasyDataClient();
            var response = client.SeasonService.LastCompletedSeason;
            Assert.IsTrue(response == 2014);
        }

        /// <summary>
        /// Get Last Completed Week integration test.
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/5484ddab35491a1278264f26/operations/5484ddab35491a0fa8f59f74/console</url>
        [TestMethod]
        public void LastCompletedWeek_Is_4()
        {
            var client = new FantasyDataClient();
            var response = client.SeasonService.LastCompletedWeek;
            Assert.IsTrue(response == 4);
        }

        /// <summary>
        /// Get Live Box Scores integration test.
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/5484ddab35491a1278264f26/operations/5484ddab35491a0fa8f59f90/console</url>
        [TestMethod]
        public void GetLiveBoxScores_Count_Equals_Zero()
        {
            var client = new FantasyDataClient();
            var response = client.BoxScoreService.GetLive();
            Assert.IsTrue(response.Count == 0);
        }

        /// <summary>
        /// Get News integration test
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/5484ddab35491a1278264f26/operations/5484ddab35491a0fa8f59f8c/console</url>
        [TestMethod]
        public void Get_News_Count_GreaterThanZero()
        {
            var client = new FantasyDataClient();
            var response = client.NewsService.GetNews();
            Assert.IsTrue(response.Count > 0);
        }

        /// <summary>
        /// Get News For Team integration test
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/5484ddab35491a1278264f26/operations/5484ddab35491a0fa8f59f8e/console</url>
        [TestMethod]
        public void Get_News_Count_For_Denver_GreaterThanZero()
        {
            var client = new FantasyDataClient();
            var response = client.NewsService.GetForTeam(TeamTypes.DEN);
            Assert.IsTrue(response.Count > 0);
        }

        /// <summary>
        /// Get News For Player integration test
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/5484ddab35491a1278264f26/operations/5484ddab35491a0fa8f59f8c/console</url>
        [TestMethod]
        public void Get_News_Count_For_PlayerID4631_GreaterThanZero()
        {
            var client = new FantasyDataClient();
            var response = client.NewsService.GetForPlayer(11056);
            Assert.IsTrue(response.Count > 0);
        }


        /// <summary>
        /// Get News For Player by date integration test
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/57a0190935491a1858749954/operations/59699de735491a16c40cc119/console</url>
        [TestMethod]
        public void Get_News_Count_For_PlayerbyDate_GreaterThanZero()
        {
            var client = new FantasyDataClient();
            DateTime myDate = Convert.ToDateTime("2018-SEP-15");
            var response = client.NewsService.GetNewsbyDate(myDate);
            Assert.IsTrue(response.Count > 0);
        }

        /// <summary>
        /// Get Player Game Stats for Season for Week integration test
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/5484ddab35491a1278264f26/operations/5484ddab35491a0fa8f59f84/console</url>
        [TestMethod]
        public void Get_PlayerGameStats_ForPeytonManning_Week1_2014_PassingTouchdowns_Equals_3()
        {
            var client = new FantasyDataClient();
            var response = client.PlayerGameStatService.GetByGame(7328, "1", 2014);
            Assert.IsTrue(response.PassingTouchdowns == 3);
        }

        /// <summary>
        /// Get Player Season Stats integration test
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/5484ddab35491a1278264f26/operations/5484ddab35491a0fa8f59f85/console</url>
        [TestMethod]
        public void GetPlayerSeasonStats_PeytonManning_2014_PassingTouchdowns_Equals_39()
        {
            var client = new FantasyDataClient();
            var response = client.PlayerSeasonStatService.GetByPlayer(7328, "2014");
            Assert.IsTrue(response[0].PassingTouchdowns == 39);
        }

        /// <summary>
        /// Get Player Stats and News integration test
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/5484ddab35491a1278264f26/operations/5484ddab35491a0fa8f59f80/console</url>
        [TestMethod]
        public void GetPlayerStatsAndNews_PeytonManning_2014_IsNotNull()
        {
            var client = new FantasyDataClient();
            var response = client.PlayerService.Get(7328);
            Assert.IsNotNull(response);
        }

        /// <summary>
        /// Get Players Game Stats by Team for Season for Week integration test
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/5484ddab35491a1278264f26/operations/5484ddab35491a0fa8f59f82/console</url>
        [TestMethod]
        public void GetPlayersGameStatsByTeamForSeasonAndWeek_2014_Week1_DEN_Count_Equals_53()
        {
            var client = new FantasyDataClient();
            var response = client.PlayerGameStatService.GetByTeamAndWeek(TeamTypes.DEN, "2014", 1);
            Assert.IsTrue(response.Count == 53);
        }


        /// <summary>
        /// Get Players Game Stats for Season for Week integration test
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/5484ddab35491a1278264f26/operations/5484ddab35491a0fa8f59f91/console</url>
        [TestMethod]
        public void GetPlayersGameStatsForSeasonAndWeek_2014_Week1_Count_Equals_1696()
        {
            var client = new FantasyDataClient();
            var response = client.PlayerGameStatService.GetByWeek("2018", 1);
            Assert.IsTrue(response.Count == 1696);
        }


        /// <summary>
        /// Get Players Season Stats by Team integration test
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/5484ddab35491a1278264f26/operations/5484ddab35491a0fa8f59f83/console</url>
        [TestMethod]
        public void GetPlayersSeasonStatsByTeam_DEN_Count_Equals_59()
        {
            var client = new FantasyDataClient();
            var response = client.PlayerSeasonStatService.GetByTeam(TeamTypes.DEN, "2014");
            Assert.IsTrue(response.Count == 59);
        }


        /// <summary>
        /// Get Players Season Stats by Team integration test
        /// </summary>
        /// <url>https://developer.fantasydata.com/docs/services/5484ddab35491a1278264f26/operations/5484ddab35491a0fa8f59f83/console</url>
        [TestMethod]
        public void GetScedule_Equals_59()
        {
            var client = new FantasyDataClient();
            var response = client.ScheduleService.GetSchedulesForSeason("2018");
            Assert.IsTrue(response.Count == 59);
        }

        //Scores by Season
        [TestMethod]
        public void GetScoresForSeason()
        {
            var client = new FantasyDataClient();
            var response = client.ScoresService.GetScoresForSeason("2018");
            Assert.IsTrue(response.Count == 59);
        }

        //Schedule  by Season
        [TestMethod]
        public void GetScheduleForSeason()
        {
            var client = new FantasyDataClient();
            var response = client.ScheduleService.GetSchedulesForSeason("2018");
            Assert.IsTrue(response.Count == 288);
        }

        //DFS Slates by Date
        [TestMethod]
        public void GetDFSSlatesbyDate()
        {
            var client = new FantasyDataClient();
            DateTime myDate = Convert.ToDateTime("2017-SEP-25");
            var response = client.DfsSlateService.GetDFSSlatesbyDate(myDate);
            Assert.IsTrue(response.Count == 4);
        }

        //DFS Slates by Week
        [TestMethod]
        public void GetDFSSlatesbyWeek()
        {
            var client = new FantasyDataClient();
            var response = client.DfsSlateService.GetDFSSlatesbyWeek("2018PRE", 1);
            Assert.IsTrue(response.Count == 19);
        }



        //added on 18082018

        //Projected Player Game Stats by Player (w/ Injuries, Lineups, DFS Salaries)
        [TestMethod]
        public void GetProjectedPlayerGameStatsbyPlayer()
        {
            var client = new FantasyDataClient();
            var response = client.PlayerGameProjectionsService.GetProjectedPlayerGameStatsbyPlayer("2018", 10, 20696);
            Assert.IsTrue(response.Count == 1);
        }

        //Projected Player Game Stats by Team (w/ Injuries, Lineups, DFS Salaries)
        [TestMethod]
        public void GetProjectedPlayerGameStatsbyTeam()
        {
            var client = new FantasyDataClient();
            var response = client.PlayerGameProjectionsService.GetProjectedPlayerGameStatsbyTeam("2018", 10, "WAS");
            Assert.IsTrue(response.Count == 42);
        }

        //Projected Player Game Stats by Week (w/ Injuries, Lineups, DFS Salaries)   
        [TestMethod]
        public void GetProjectedPlayerGameStatsbyWeek()
        {
            var client = new FantasyDataClient();
            var response = client.PlayerGameProjectionsService.GetProjectedPlayerGameStatsbyWeek("2018", 10);
            Assert.IsTrue(response.Count == 1210);
        }


        //Projected Player Season Stats(w/ Bye Week, ADP)
        [TestMethod]
        public void GetProjectedPlayerSeasonStats()
        {
            var client = new FantasyDataClient();
            var response = client.PlayerSeasonProjectionService.GetProjectedPlayerSeasonStats("2018");
            Assert.IsTrue(response.Count == 1151);
        }

        //Projected Player Season Stats by Player(w/ Bye Week, ADP)
        [TestMethod]
        public void GetProjectedPlayerSeasonStatsbyPlayer()
        {
            var client = new FantasyDataClient();
            var response = client.PlayerSeasonProjectionService.GetProjectedPlayerSeasonStatsbyPlayer("2018", 14257);
            Assert.IsTrue(response.Count == 1);
        }


        //Projected Player Season Stats by Team(w/ Bye Week, ADP)
        [TestMethod]
        public void GetProjectedPlayerSeasonStatsbyTeam()
        {
            var client = new FantasyDataClient();
            var response = client.PlayerSeasonProjectionService.GetProjectedPlayerSeasonStatsbyTeam("2018", "WAS");
            Assert.IsTrue(response.Count == 1151);
        }
    }
}
