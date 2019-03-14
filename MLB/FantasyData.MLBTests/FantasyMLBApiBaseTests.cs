using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FantasyData.MLB;

namespace FantasyData.MLBTests
{
    [TestClass]
    public class FantasyMLBApiBaseTests
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        //Are Games In Progress
        [TestMethod]
        public void AreGamesInProgress()
        {
            var client = new FantasyMLBClient();
            Boolean response = client.CommonServices.AnyGamesInProgress();
            Assert.IsTrue(response == false);
            //Assert.IsTrue(response.Count == 31);
        }

        //Current Season
        [TestMethod]
        public void GetCurrentSeason()
        {
            var client = new FantasyMLBClient();
            var response = client.SeasonServices.GetCurrentSeason();
            Assert.IsTrue(response.Count == 1);
        }

        //Games by Date
        [TestMethod]
        public void GamesbyDate()
        {
            var client = new FantasyMLBClient();
            DateTime myDate = Convert.ToDateTime("2017-JUL-31");
            var response = client.GameServices.GamesbyDate(myDate);
            Assert.IsTrue(response.Count == 9);
        }

        //News
        [TestMethod]
        public void News()
        {
            var client = new FantasyMLBClient();
            var response = client.NewsServices.GetNews();
            Assert.IsTrue(response.Count == 25);
        }

        //News by Date
        [TestMethod]
        public void NewsbyDate()
        {
            var client = new FantasyMLBClient();
            DateTime myDate = Convert.ToDateTime("2017-JUL-31");
            var response = client.NewsServices.NewsbyDate(myDate);
            Assert.IsTrue(response.Count == 68);
        }

        //News by Player
        [TestMethod]
        public void NewsbyPlayer()
        {
            var client = new FantasyMLBClient();
            var response = client.NewsServices.NewsbyPlayer("10000001");
            Assert.IsTrue(response.Count == 24);
        }

        //Player Details by Active
        [TestMethod]
        public void GetPlayerDetailsbyActive()
        {
            var client = new FantasyMLBClient();
            var response = client.PlayerServices.GetPlayerDetailsbyActive();
            Assert.IsTrue(response.Count == 4318);
        }

        //Player Details by Free Agent
        [TestMethod]
        public void GetPlayerDetailsbyFreeAgent()
        {
            var client = new FantasyMLBClient();
            var response = client.PlayerServices.GetPlayerDetailsbyFreeAgent();
            Assert.IsTrue(response.Count == 624);
        }

        //Player Details by Player
        [TestMethod]
        public void GetPlayerDetailsbyPlayerID()
        {
            var client = new FantasyMLBClient();
            var response = client.PlayerServices.GetPlayerDetailsbyPlayerID("10000001");
            Assert.IsTrue(response.Count == 1);
        }

        //Players by Team
        [TestMethod]
        public void GetPlayersbyTeam()
        {
            var client = new FantasyMLBClient();
            var response = client.PlayerServices.GetPlayersbyTeam("NYY");
            Assert.IsTrue(response.Count == 142);
        }

        //Schedules
        [TestMethod]
        public void GetSchedules()
        {
            var client = new FantasyMLBClient();
            var response = client.GameServices.GetSchedules("2018");
            Assert.IsTrue(response.Count == 2451);
        }

        //Stadiums
        [TestMethod]
        public void GetStadiums()
        {
            var client = new FantasyMLBClient();
            var response = client.StadiumsServices.GetStadiums();
            Assert.IsTrue(response.Count == 68);
        }

        //Standings
        [TestMethod]
        public void GetStandings()
        {
            var client = new FantasyMLBClient();
            var response = client.StandingsServices.GetStandings("2018");
            Assert.IsTrue(response.Count == 30);
        }

        //Team Game Stats by Date
        [TestMethod]
        public void GetTeamGameStatsbyDate()
        {
            var client = new FantasyMLBClient();
            DateTime myDate = Convert.ToDateTime("2017-JUL-31");
            var response = client.PlayerGameServices.GetTeamGameStatsbyDate(myDate);
            Assert.IsTrue(response.Count == 18);
        }

        //Team Season Stats
        [TestMethod]
        public void GetTeamSeasonStats()
        {
            var client = new FantasyMLBClient();
            var response = client.TeamSeasonServices.GetTeamSeasonStats("2018");
            Assert.IsTrue(response.Count == 30);
        }

        //Teams (Active)
        [TestMethod]
        public void GetActiveTeams()
        {
            var client = new FantasyMLBClient();
            var response = client.TeamServices.GetActiveTeams();
            Assert.IsTrue(response.Count == 30);
        }

        //Teams (All)
        [TestMethod]
        public void GetAllTeams()
        {
            var client = new FantasyMLBClient();
            var response = client.TeamServices.GetAllTeams();
            Assert.IsTrue(response.Count == 35);
        }

        //Batter vs. Pitcher Stats
        [TestMethod]
        public void GetBattervsPitcherStats()
        {
            var client = new FantasyMLBClient();
            var response = client.PlayerSeasonServices.GetBattervsPitcherStats("10000031", "10000618");
            Assert.IsTrue(response.Count == 2);
        }

        //Box Score
        [TestMethod]
        public void BoxScore()
        {
            var client = new FantasyMLBClient();
            var response = client.BoxScoreServices.GetBoxScore("14620");
            Assert.IsTrue(response.Count == 1);
        }

        //Box Scores by Date
        [TestMethod]
        public void GetBoxScoresbyDate()
        {
            var client = new FantasyMLBClient();
            DateTime myDate = Convert.ToDateTime("2017-JUL-31");
            var response = client.BoxScoreServices.GetBoxScoresbyDate(myDate);
            Assert.IsTrue(response.Count == 9);
        }

        //Box Scores by Date Delta
        [TestMethod]
        public void GetBoxScoresbyDateDelta()
        {
            var client = new FantasyMLBClient();
            DateTime myDate = Convert.ToDateTime("2017-JUL-31");
            var response = client.BoxScoreServices.GetBoxScoresbyDateDelta(myDate, "1");
            Assert.IsTrue(response.Count == 9);
        }

        //DFS Slates by Date
        [TestMethod]
        public void GetDFSSlatesbyDate()
        {
            var client = new FantasyMLBClient();
            DateTime myDate = Convert.ToDateTime("2017-JUL-31");
            var response = client.DfsSlateServices.GetDFSSlatesbyDate(myDate);
            Assert.IsTrue(response.Count == 15);
        }                
        
        //Player Game Stats by Date
        [TestMethod]
        public void GetPlayerGameStatsbyDate()
        {
            var client = new FantasyMLBClient();
            DateTime myDate = Convert.ToDateTime("2017-JUL-31");
            var response = client.PlayerGameServices.GetPlayerGameStatsbyDate(myDate);
            Assert.IsTrue(response.Count == 245);
        }

        //Player Game Stats by Player
        [TestMethod]
        public void GetPlayerGameStatsbyPlayerID()
        {
            var client = new FantasyMLBClient();
            DateTime myDate = Convert.ToDateTime("2017-JUL-31");
            var response = client.PlayerGameServices.GetPlayerGameStatsbyPlayerID(myDate, "10000001");
            Assert.IsTrue(response.Count == 1);
        }

        //Player Season Away Stats
        [TestMethod]
        public void GetPlayerSeasonAwayStats()
        {
            var client = new FantasyMLBClient();            
            var response = client.PlayerSeasonServices.GetPlayerSeasonAwayStats("2018");
            Assert.IsTrue(response.Count == 873);
        }

        //Player Season Home Stats
        [TestMethod]
        public void GetPlayerSeasonHomeStats()
        {
            var client = new FantasyMLBClient();
            var response = client.PlayerSeasonServices.GetPlayerSeasonHomeStats("2018");
            Assert.IsTrue(response.Count == 887);
        }

        //Player Season Split Stats
        [TestMethod]
        public void GetPlayerSeasonSplitStats()
        {
            var client = new FantasyMLBClient();
            var response = client.PlayerSeasonServices.GetPlayerSeasonSplitStats("2018","L");
            Assert.IsTrue(response.Count == 925);
        }

        //Player Season Stats
        [TestMethod]
        public void GetPlayerSeasonStats() 
        {
            var client = new FantasyMLBClient();
            var response = client.PlayerSeasonServices.GetPlayerSeasonStats("2018");
            Assert.IsTrue(response.Count == 925);
        }

        //Player Season Stats By Player
        [TestMethod]
        public void GetPlayerSeasonStatsByPlayer()
        {
            var client = new FantasyMLBClient();
            var response = client.PlayerGameServices.GetPlayerSeasonStatsByPlayer("2017", "10000507");
            Assert.IsTrue(response.Count == 1);
        }

        //Player Season Stats by Team
        [TestMethod]
        public void GetPlayerSeasonStatsbyTeam()
        {
            var client = new FantasyMLBClient();
            var response = client.PlayerGameServices.GetPlayerSeasonStatsbyTeam("2018", "NYY");
            Assert.IsTrue(response.Count == 31);
        }

        //Player Season Stats Split By Team
        [TestMethod]
        public void GetPlayerSeasonStatsSplitByTeam()
        {
            var client = new FantasyMLBClient();
            var response = client.PlayerSeasonServices.GetPlayerSeasonStatsSplitByTeam("2018");
            Assert.IsTrue(response.Count == 925);
        }

        //Team Stats Allowed by Position
        //[TestMethod]
        //public void GetTeamStatsAllowedbyPosition()
        //{
        //    var client = new FantasyMLBClient();
        //    var response = client.TeamSeasonServices.GetTeamStatsAllowedbyPosition("2017");
        //    Assert.IsTrue(response.Count == 210);
        //}

        //Play By Play
        [TestMethod]
        public void PlayByPlay()
        {
            var client = new FantasyMLBClient();
            var response = client.BoxScorePbpServices.GetPlayByPlay("16905");
            Assert.IsTrue(response.Count == 1);
        }

        //Play By Play Delta
        [TestMethod]
        public void GetPlayByPlayDelta()
        {
            var client = new FantasyMLBClient();
            DateTime myDate = Convert.ToDateTime("2017-SEP-01");
            var response = client.BoxScorePbpServices.GetPlayByPlayDelta(myDate, "1");
            Assert.IsTrue(response.Count == 16);
        }

        //Projected Player Game Stats by Date (w/ Injuries, Lineups, DFS Salaries)
        [TestMethod]
        public void GetProjectedPlayerGameStatsbyDate()
        {
            var client = new FantasyMLBClient();
            DateTime myDate = Convert.ToDateTime("2018-APR-25");
            var response = client.ProjectionServices.GetProjectedPlayerGameStatsbyDate(myDate);
            Assert.IsTrue(response.Count == 1602);
        }

        //Projected Player Game Stats by Player (w/ Injuries, Lineups, DFS Salaries)
        [TestMethod]
        public void GetProjectedPlayerGameStatsbyPlayer()
        {
            var client = new FantasyMLBClient();
            DateTime myDate = Convert.ToDateTime("2018-APR-25");
            var response = client.ProjectionServices.GetProjectedPlayerGameStatsbyPlayer(myDate, "10000001");
            Assert.IsTrue(response.Count == 1);
        }

        //Projected Player Season Stats (with ADP)
        [TestMethod]
        public void GetProjectedPlayerSeasonStats()
        {
            var client = new FantasyMLBClient();            
            var response = client.ProjectionServices.GetProjectedPlayerSeasonStats("2018");
            Assert.IsTrue(response.Count == 1642);
        }
    }
}
