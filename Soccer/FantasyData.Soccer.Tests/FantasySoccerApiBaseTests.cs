using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace FantasyData.Soccer.Tests
{
    /// <summary>
    /// Summary description for FantasySoccerApiBaseTests
    /// </summary>
    [TestClass]
    public class FantasySoccerApiBaseTests
    {
        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion
        [TestMethod]
        public void GetAllActiveMembership()
        {
            var client = new FantasySoccerClient();
            var results = client.MembershipServices.GetActiveMembership();
            Assert.IsTrue(results.Count > 0);
        }
        [TestMethod]
        public void GetAllAreas()
        {
            var client = new FantasySoccerClient();
            var results = client.AreaServices.Get();
            Assert.IsTrue(results.Count > 0);
        }

        [TestMethod]
        public void GetAllCompetitions()
        {
            var client = new FantasySoccerClient();
            var results = client.CompetitionServices.GetCompetitionHierarchy();
            Assert.IsTrue(results.Count > 0);
        }

        [TestMethod]
        public void GetSeasonTeam()
        {
            var client = new FantasySoccerClient();
            var results = client.SeasonServices.Get("31");
            Assert.IsTrue(results.Count > 0);
        }

        [TestMethod]
        public void GetPlayers()
        {
            var client = new FantasySoccerClient();
            var results = client.PlayerServices.GetAll();
            Assert.IsTrue(results.Count > 0);
        }

        [TestMethod]
        public void GetTeams()
        {
            var client = new FantasySoccerClient();
            var results = client.TeamServices.Get();
            Assert.IsTrue(results.Count > 0);
        }

        [TestMethod]
        public void GetVenues()
        {
            var client = new FantasySoccerClient();
            var results = client.VenueServices.Get();
            Assert.IsTrue(results.Count > 0);
        }

        [TestMethod]
        public void GetDateFormat()
        {
            var client = new FantasySoccerClient();
            var results = client.BoxScoreServices.GetBoxScoreByDate(DateTime.Now);
            Assert.IsTrue(results.Count > 0);
        }

        [TestMethod]
        public void GetActiveMembership()
        {
            var client = new FantasySoccerClient();
            var results = client.MembershipServices.GetActiveMembership(512);
            Assert.IsTrue(results.Count > 0);
        }

        [TestMethod]
        public void GetHistoricMembership()
        {
            var client = new FantasySoccerClient();
            var results = client.MembershipServices.GetHistoricalMembership(512);
            Assert.IsTrue(results.Count > 0);
        }

        [TestMethod]
        public void GetPlayerProjectionByDate()
        {
            var client = new FantasySoccerClient();
            DateTime dtDate = DateTime.Now.AddDays(4);
            var results = client.ProjectionServices.GetProjectionByDate(dtDate);
            Assert.IsTrue(results.Count > 0);
        }

        [TestMethod]
        public void GetPlayerProjectionByCompetitions()
        {
            var client = new FantasySoccerClient();
            var results = client.ProjectionServices.GetProjectionByCompetition("1", DateTime.Now.AddDays(1));
            Assert.IsTrue(results.Count > 0);
        }

        [TestMethod]
        public void GetPlayerProjectionByPlayers()
        {
            var client = new FantasySoccerClient();
            var results = client.ProjectionServices.GetProjectionByPlayer(90037343, DateTime.Now.AddDays(4));
            Assert.IsTrue(results.Count > 0);
        }


    }
}
