using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FantasyData.NHL;
using FantasyData.NHL.Entities;

namespace FantasyData.NHLTests
{   
    [TestClass]
    public class FantasyNHLApiBaseTests
    {

        [TestMethod]
        public void CheckIfGameInProgress_Return_False()
        {
            var client = new FantasyNHLClient();

            var response = client.GameServices.IsGameInProgress;

            Assert.IsFalse(response);
        }

        [TestMethod]

        //Teams (Active)
        public void GetTeams()
        {
            var client = new FantasyNHLClient();
            var response = client.TeamServices.GetTeams();
            Assert.IsTrue(response.Count == 31);
        }

        //Stadiums
        [TestMethod]
        public void GetStadiums()
        {
            var client = new FantasyNHLClient();
            var response = client.StadiumServices.getStadiums();
            Assert.IsTrue(response.Count == 31);
        }

        //Games by Date
        [TestMethod]
        public void GetGameByDate()
        {
            var client = new FantasyNHLClient();
            DateTime myDate = Convert.ToDateTime("2017-Dec-31");
            var response = client.GameServices.GetGameByDate(myDate);
            Assert.IsTrue(response.Count == 3);
        }


        //Schedules
        [TestMethod]
        public void GetGamseBySeason()
        {
            var client = new FantasyNHLClient();
            var response = client.GameServices.GetGameBySeason("2017");
            Assert.IsTrue(response.Count == 1232);
        }

        //Player Details by Active
        [TestMethod]
        public void GetPlayersDetail()
        {
            var client = new FantasyNHLClient();
            var response = client.PlayerServices.GetPlayersDetail();
            Assert.IsTrue(response.Count == 797);
        }
        [TestMethod]
        public void GetProjectedPlayerGameStatsbyDate()
        {
            var client = new FantasyNHLClient();
            DateTime myDate = Convert.ToDateTime("2017-Nov-28");
            var response = client.ProjectionServices.GetProjectionByDate(myDate);
            Assert.IsTrue(response.Count == 195);
        }

        [TestMethod]
        public void GetProjectedPlayerGameStatsbyDateAndPlayer()
        {
            var client = new FantasyNHLClient();
            DateTime myDate = Convert.ToDateTime("2017-OCT-01");
            var response = client.ProjectionServices.GetProjectionByDateAndPlayer(myDate, "30000378");
            Assert.IsTrue(response.Count == 1);
        }

        [TestMethod]
        public void GetBoxScoresByDate()
        {
            var client = new FantasyNHLClient();
            DateTime myDate = Convert.ToDateTime("2017-NOV-22");
            var response = client.BoxScoreServices.GetBoxScoresByDate(myDate);
            Assert.IsTrue(response == null);
        }
        [TestMethod]
        public void BoxScoresbyDateDelta()
        {
            var client = new FantasyNHLClient();
            DateTime myDate = Convert.ToDateTime("2017-OCT-31");
            var response = client.BoxScoreServices.BoxScoresbyDateDelta(myDate, 1);
            Assert.IsTrue(response.Count == 3);
        }

        [TestMethod]
        public void GetDFSSlatesbyDate()
        {
            var client = new FantasyNHLClient();
            DateTime myDate = Convert.ToDateTime("2017-OCT-13");
            var response = client.DFSSlatesService.GetDFSSlatesbyDate(myDate);
            Assert.IsTrue(response.Count == 7);
        }

        //Player Details by Free Agent
        [TestMethod]
        public void GetPlayerDetailsbyFreeAgent()
        {
            var client = new FantasyNHLClient();
            var response = client.PlayerServices.GetPlayerDetailsbyFreeAgent();
            Assert.IsTrue(response.Count == 1905);
        }

        //Player Details by Player
        [TestMethod]
        public void GetPlayerDetailsbyPlayer()
        {
            var client = new FantasyNHLClient();
            var response = client.PlayerServices.GetPlayerDetailsbyPlayer("30000007");
            Assert.IsTrue(response.Count == 1);
        }

        //Players by Team
        [TestMethod]
        public void GetPlayersbyTeam()
        {
            var client = new FantasyNHLClient();
            var response = client.PlayerServices.GetPlayersbyTeam("BOS");
            Assert.IsTrue(response.Count == 26);
        }

        //Standings

        [TestMethod]
        public void GetStandingsSeason()
        {
            var client = new FantasyNHLClient();
            var response = client.StandingService.GetStandingsSeason("2017");
            Assert.IsTrue(response.Count == 30);
        }

        //Team Game Stats by Date

        [TestMethod]
        public void GetTeamGameStatsbyDate()
        {
            var client = new FantasyNHLClient();
            DateTime myDate = Convert.ToDateTime("2017-OCT-01");
            var response = client.PlayerGameService.GetTeamGameStatsbyDate(myDate);
            Assert.IsTrue(response.Count == 6);
        }

        //Team Season Stats

        [TestMethod]
        public void GetTeamSeasonStats()
        {
            var client = new FantasyNHLClient();
            var response = client.TeamSeasonService.GetTeamSeasonStats("2017");
            Assert.IsTrue(response.Count == 30);
        }

        //Team Stats Allowed by Position
        [TestMethod]
        public void GetTeamStatsAllowedbyPosition()
        {
            var client = new FantasyNHLClient();
            var response = client.TeamSeasonService.GetTeamStatsAllowedbyPosition("2017");
            Assert.IsTrue(response.Count == 150);
        }

        //Teams (All)
        [TestMethod]
        public void GetAllTeams()
        {
            var client = new FantasyNHLClient();
            var response = client.TeamServices.GetAllTeams();
            Assert.IsTrue(response.Count == 35);
        }

        //Are Games In Progress
        [TestMethod]
        public void GetAreGamesInProgress()
        {
            var client = new FantasyNHLClient();
            var response = client.TeamServices.GetAllTeams();
            Assert.IsTrue(response.Count == 35);
        }

        //Current Season
        [TestMethod]
        public void GetCurrentSeason()
        {
            var client = new FantasyNHLClient();
            var response = client.SeasonService.GetCurrentSeason();
            Assert.IsTrue(response.Count == 1);
        }

        //News
        [TestMethod]
        public void GetNews()
        {
            var client = new FantasyNHLClient();
            var response = client.NewsService.GetNews();
            Assert.IsTrue(response.Count == 31);
        }

        //News by Date
        [TestMethod]
        public void GetNewsbyDate()
        {
            var client = new FantasyNHLClient();
            DateTime myDate = Convert.ToDateTime("2017-OCT-01");
            var response = client.NewsService.GetNewsbyDate(myDate);
            Assert.IsTrue(response.Count == 5);
        }

        //News by Player
        [TestMethod]
        public void GetNewsbyPlayer()
        {
            var client = new FantasyNHLClient();
            var response = client.NewsService.GetNewsbyPlayer("30000446");
            Assert.IsTrue(response.Count == 4);
        }
    }
}
