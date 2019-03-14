using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FantasyData.NBA;
using FantasyData.NBA.Entities;

namespace FantasyData.NBATests
{
    [TestClass]
    public class FantasyNBAApiBaseTests
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        //Are Games In Progress
        [TestMethod]
        public void AreGamesInProgress()
        {
            var client = new FantasyNBAClient();
            Boolean response = client.CommonServices.AnyGamesInProgress();
            Assert.IsTrue(response == false);
            //Assert.IsTrue(response.Count == 31);
        }

        //Current Season
        [TestMethod]
        public void GetCurrentSeason()
        {
            var client = new FantasyNBAClient();
            var response = client.SeasonServices.GetCurrentSeason();
            Assert.IsTrue(response.Count == 1);
        }

        //Games by Date
        [TestMethod]
        public void GamesbyDate()
        {
            var client = new FantasyNBAClient();
            DateTime myDate = Convert.ToDateTime("2018-JAN-19");
            var response = client.GameServices.GamesbyDate(myDate);
            Assert.IsTrue(response.Count == 7);
        }

        //News
        [TestMethod]
        public void News()
        {
            var client = new FantasyNBAClient();
            var response = client.NewsServices.GetNews();
            Assert.IsTrue(response.Count == 25);
        }

        //News by Date
        [TestMethod]
        public void NewsbyDate()
        {
            var client = new FantasyNBAClient();
            DateTime myDate = Convert.ToDateTime("2018-JAN-15");
            var response = client.NewsServices.NewsbyDate(myDate);
            Assert.IsTrue(response.Count == 52);
        }

        //News by Player
        [TestMethod]
        public void NewsbyPlayer()
        {
            var client = new FantasyNBAClient();
            var response = client.NewsServices.NewsbyPlayer("20000641");
            Assert.IsTrue(response.Count == 2);
        }

        //Schedules
        [TestMethod]
        public void GetSchedules()
        {
            var client = new FantasyNBAClient();
            var response = client.GameServices.GetSchedules("2018");
            Assert.IsTrue(response.Count == 1230);
        }

        //Stadiums
        [TestMethod]
        public void GetStadiums()
        {
            var client = new FantasyNBAClient();
            var response = client.StadiumsServices.GetStadiums();
            Assert.IsTrue(response.Count == 29);
        }
        //Standings
        [TestMethod]
        public void GetStandings()
        {
            var client = new FantasyNBAClient();
            var response = client.StandingsServices.GetStandings("2017");
            Assert.IsTrue(response.Count == 30);
        }

        //Team Game Stats by Date
        [TestMethod]
        public void GetTeamGameStatsbyDate()
        {
            var client = new FantasyNBAClient();
            DateTime myDate = Convert.ToDateTime("2017-DEC-31");
            var response = client.OpponentSeasonServices.GetTeamGameStatsbyDate(myDate);
            Assert.IsTrue(response.Count == 16);
        }

        //Team Season Stats
        [TestMethod]
        public void GetTeamSeasonStats()
        {
            var client = new FantasyNBAClient();
            var response = client.OpponentSeasonServices.GetTeamSeasonStats("2016");
            Assert.IsTrue(response.Count == 30);
        }
        //Teams (Active)
        [TestMethod]
        public void GetActiveTeams()
        {
            var client = new FantasyNBAClient();
            var response = client.TeamServices.GetActiveTeams();
            Assert.IsTrue(response.Count == 30);
        }

        //Teams (All)
        [TestMethod]
        public void GetAllTeams()
        {
            var client = new FantasyNBAClient();
            var response = client.TeamServices.GetAllTeams();
            Assert.IsTrue(response.Count == 32);
        }

        //Box Score
        [TestMethod]
        public void BoxScore()
        {
            var client = new FantasyNBAClient();
            var response = client.BoxScoreServices.GetBoxScore("11814");
            Assert.IsTrue(response.Count == 1);
        }

        //Box Scores by Date
        [TestMethod]
        public void GetBoxScoresbyDate()
        {
            var client = new FantasyNBAClient();
            DateTime myDate = Convert.ToDateTime("2017-DEC-31");
            var response = client.BoxScoreServices.GetBoxScoresbyDate(myDate);
            Assert.IsTrue(response.Count == 8);
        }

        //Box Scores by Date Delta
        [TestMethod]
        public void GetBoxScoresbyDateDelta()
        {
            var client = new FantasyNBAClient();
            DateTime myDate = Convert.ToDateTime("2017-DEC-31");
            var response = client.BoxScoreServices.GetBoxScoresbyDateDelta(myDate, "1");
            Assert.IsTrue(response.Count == 8);
        }
        //DFS Slates by Date
        [TestMethod]
        public void GetDFSSlatesbyDate()
        {
            var client = new FantasyNBAClient();
            DateTime myDate = Convert.ToDateTime("2017-DEC-01");
            var response = client.DfsSlateServices.GetDFSSlatesbyDate(myDate);
            Assert.IsTrue(response.Count == 12);
        }
        //Player Details by Active
        [TestMethod]
        public void GetPlayerDetailsbyActive()
        {
            var client = new FantasyNBAClient();
            var response = client.PlayerServices.GetPlayerDetailsbyActive();
            Assert.IsTrue(response.Count == 500);
        }

        //Player Details by Free Agent

        [TestMethod]
        public void GetPlayerDetailsbyFreeAgent()
        {
            var client = new FantasyNBAClient();
            var response = client.PlayerServices.GetPlayerDetailsbyFreeAgent();
            Assert.IsTrue(response.Count == 266);
        }

        //Player Details by Player
        [TestMethod]
        public void GetPlayerDetailsbyPlayerID()
        {
            var client = new FantasyNBAClient();
            var response = client.PlayerServices.GetPlayerDetailsbyPlayerID("20000571");
            Assert.IsTrue(response.Count == 1);
        }
        //Player Game Stats by Date
        [TestMethod]
        public void GetPlayerGameStatsbyDate()
        {
            var client = new FantasyNBAClient();
            DateTime myDate = Convert.ToDateTime("2017-DEC-31");
            var response = client.PlayerGameServices.GetPlayerGameStatsbyDate(myDate);
            Assert.IsTrue(response.Count == 261);
        }

        //Player Game Stats by Player
        [TestMethod]
        public void GetlayerGameStatsbyPlayerID()
        {
            var client = new FantasyNBAClient();
            DateTime myDate = Convert.ToDateTime("12-25-2017");
            var response = client.PlayerGameServices.GetPlayerGameStatsbyPlayerID(myDate, "20000571");
            Assert.IsTrue(response.Count == 1);
        }

        //Player Season Stats
        [TestMethod]
        public void GetPlayerSeasonStats()
        {
            var client = new FantasyNBAClient();
            var response = client.PlayerSeasonServices.GetPlayerSeasonStats("2016");
            Assert.IsTrue(response.Count == 486);
        }
        //Player Season Stats By Player

        [TestMethod]
        public void GetPlayerSeasonStatsByPlayer()
        {
            var client = new FantasyNBAClient();
            var response = client.PlayerGameServices.GetPlayerSeasonStatsByPlayer("2016", "20000571");
            Assert.IsTrue(response.Count == 1);
        }

        //Player Season Stats by Team
        [TestMethod]
        public void GetPlayerSeasonStatsbyTeam()
        {
            var client = new FantasyNBAClient();
            var response = client.PlayerGameServices.GetPlayerSeasonStatsbyTeam("2016", "WAS");
            Assert.IsTrue(response.Count == 17);
        }

        //Players by Team
        [TestMethod]
        public void GetPlayersbyTeam()
        {
            var client = new FantasyNBAClient();
            var response = client.PlayerServices.GetPlayersbyTeam("WAS");
            Assert.IsTrue(response.Count == 15);
        }

        //Team Stats Allowed by Position
        [TestMethod]
        public void GetTeamStatsAllowedbyPosition()
        {
            var client = new FantasyNBAClient();
            var response = client.TeamSeasonServices.GetTeamStatsAllowedbyPosition("2017");
            Assert.IsTrue(response.Count == 210);
        }

        //Play By Play
        [TestMethod]
        public void PlayByPlay()
        {
            var client = new FantasyNBAClient();
            var response = client.BoxScorePbpServices.GetPlayByPlay("11814");
            Assert.IsTrue(response.Count == 1);
        }
        //Play By Play
        [TestMethod]
        public void GetPlayByPlayDelta()
        {
            var client = new FantasyNBAClient();
            DateTime myDate = Convert.ToDateTime("2016-OCT-31");
            var response = client.BoxScorePbpServices.GetPlayByPlayDelta(myDate, "1");
            Assert.IsTrue(response.Count == 4);
        }

        //Projected Player Game Stats by Date (w/ Injuries, DFS Salaries)
        [TestMethod]
        public void GetProjectedPlayerGameStatsbyDate()
        {
            var client = new FantasyNBAClient();
            DateTime myDate = Convert.ToDateTime("2017-DEC-31");
            var response = client.ProjectionServices.GetProjectedPlayerGameStatsbyDate(myDate);
            Assert.IsTrue(response.Count == 262);
        }

        //Projected Player Game Stats by Player
        [TestMethod]
        public void GetProjectedPlayerGameStatsbyPlayer()
        {
            var client = new FantasyNBAClient();
            DateTime myDate = Convert.ToDateTime("2018-JAN-31");
            var response = client.ProjectionServices.GetProjectedPlayerGameStatsbyPlayer(myDate, "20000571");
            Assert.IsTrue(response.Count == 1);
        }
    }
}
