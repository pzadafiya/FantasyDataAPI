using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.MLB.Services;
using FantasyData;

namespace FantasyData.MLB
{
    public class FantasyMLBClient
    {
        #region Accessors       

        public ICommonServices CommonServices { get; private set; }
        public ISeasonServices SeasonServices { get; private set; }
        public IGameServices GameServices { get; private set; }
        public INewsServices NewsServices { get; private set; }
        public IStadiumsServices StadiumsServices { get; private set; }
        public IStandingsServices StandingsServices { get; private set; }
        //public IOpponentSeasonServices OpponentSeasonServices { get; private set; }
        public ITeamServices TeamServices { get; private set; }
        public IBoxScoreServices BoxScoreServices { get; private set; }
        public IDfsSlateServices DfsSlateServices { get; private set; }
        public IPlayerServices PlayerServices { get; private set; }
        public IPlayerGameServices PlayerGameServices { get; private set; }
        public IPlayerSeasonServices PlayerSeasonServices { get; private set; }
        public ITeamSeasonServices TeamSeasonServices { get; private set; }
        public IBoxScorePbpServices BoxScorePbpServices { get; private set; }
        public IProjectionServices ProjectionServices { get; private set; }        


        #endregion

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiBaseUrl"></param>
        /// <param name="primarySubscriptionKey"></param>
        /// <param name="secondarySubscriptionKey"></param>        

        public FantasyMLBClient(string primarySubscriptionKey, string secondarySubscriptionKey)
        {
            Uri statApiBaseUrl = MLBConfig.StateApiBaseUrl;
            Uri scoreApiBaseUrl = MLBConfig.ScoreApiBaseUrl;
            Uri PbpApiBaseUrl = MLBConfig.PbpApiBaseUrl;
            Uri ProjectionApiBaseUrl = MLBConfig.ProjectionApiBaseUrl;


            CommonServices = new CommonServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            SeasonServices = new SeasonServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            GameServices = new GameServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            NewsServices = new NewsServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            StadiumsServices = new StadiumsServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            StandingsServices = new StandingsServices(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            //OpponentSeasonServices = new OpponentSeasonServices(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            TeamServices = new TeamServices(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            BoxScoreServices = new BoxScoreServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            //DfsSlateServices = new DfsSlateServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);            
            PlayerServices = new PlayerServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            PlayerGameServices = new PlayerGameServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            TeamSeasonServices = new TeamSeasonServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            
            PlayerSeasonServices = new PlayerSeasonServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);            

            //Projection
            DfsSlateServices = new DfsSlateServices(ProjectionApiBaseUrl.AbsoluteUri, MLBConfig.ProjectionPrimarySubscriptionKey, MLBConfig.ProjectionSecondarySubscriptionKey);
            ProjectionServices = new ProjectionServices(ProjectionApiBaseUrl.AbsoluteUri, MLBConfig.ProjectionPrimarySubscriptionKey, MLBConfig.ProjectionSecondarySubscriptionKey);

            //Play by Play            
            BoxScorePbpServices = new BoxScorePbpServices(PbpApiBaseUrl.AbsoluteUri, MLBConfig.PlayByPlayPrimarySubscriptionKey, MLBConfig.PlayByPlaySecondarySubscriptionKey);
        }

        /// <summary>
        /// 
        /// </summary>
        public FantasyMLBClient()
      : this(MLBConfig.PrimarySubscriptionKey, MLBConfig.SecondarySubscriptionKey)
        { }

        #endregion
    }
}
