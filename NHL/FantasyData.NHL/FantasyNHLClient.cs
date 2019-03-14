using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.NHL.Services;

namespace FantasyData.NHL
{
    public class FantasyNHLClient
    {
        #region Accessors

        public ITeamService TeamServices { get; private set; }
        public IStadiumService StadiumServices { get; private set; }
        public IGameService GameServices { get; private set; }
        public IPlayerService PlayerServices { get; private set; }
        public IProjectionService ProjectionServices { get; private set; }
        public IBoxScoreService BoxScoreServices { get; private set; }
        public ISeasonService SeasonService { get; private set; }
        public IDFSSlatesService DFSSlatesService { get; private set; }
        public IStandingService StandingService { get; private set; }
        public IPlayerGameService PlayerGameService { get; private set; }
        public ITeamSeasonService TeamSeasonService { get; private set; }
        public INewsService NewsService { get; private set; }

        #endregion   Accessors

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiBaseUrl"></param>
        /// <param name="primarySubscriptionKey"></param>
        /// <param name="secondarySubscriptionKey"></param>        

        public FantasyNHLClient(string primarySubscriptionKey, string secondarySubscriptionKey)
        {
            Uri statApiBaseUrl = NHLConfig.StateApiBaseUrl;
            Uri scoreApiBaseUrl = NHLConfig.ScoreApiBaseUrl;
            Uri ProjectionApiBaseUrl = NHLConfig.ProjectionApiBaseUrl;
           
            TeamServices = new TeamServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            StadiumServices = new StadiumServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            GameServices = new GameServices(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            PlayerServices = new PlayerServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            ProjectionServices = new ProjectionServices(ProjectionApiBaseUrl.AbsoluteUri, NHLConfig.ProjectionPrimarySubscriptionKey, NHLConfig.ProjectionSecondarySubscriptionKey);
            BoxScoreServices = new BoxScoreServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            SeasonService = new SeasonServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            DFSSlatesService = new DFSSlatesServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            StandingService = new StandingServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            PlayerGameService = new PlayerGameServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            TeamSeasonService = new TeamSeasonServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            NewsService = new NewsServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
        }

        /// <summary>
        /// 
        /// </summary>
        public FantasyNHLClient()
      : this(NHLConfig.PrimarySubscriptionKey, NHLConfig.SecondarySubscriptionKey)
        { }

        #endregion
    }
}
