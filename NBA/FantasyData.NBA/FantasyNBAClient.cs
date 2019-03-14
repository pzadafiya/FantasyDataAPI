using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.NBA.Services;
using FantasyData;

namespace FantasyData.NBA
{
    public class FantasyNBAClient
    {
        #region Accessors       

        public ICommonServices CommonServices { get; private set; }
        public ISeasonServices SeasonServices { get; private set; }
        public IGameServices GameServices { get; private set; }
        public INewsServices NewsServices { get; private set; }
        public IStadiumsServices StadiumsServices { get; private set; }
        public IStandingsServices StandingsServices { get; private set; }
        public IOpponentSeasonServices OpponentSeasonServices { get; private set; }
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

        public FantasyNBAClient(string primarySubscriptionKey, string secondarySubscriptionKey)
        {
            Uri statApiBaseUrl = NBAConfig.StateApiBaseUrl;
            Uri scoreApiBaseUrl = NBAConfig.ScoreApiBaseUrl;
            Uri PbpApiBaseUrl = NBAConfig.PbpApiBaseUrl;
            Uri ProjectionApiBaseUrl = NBAConfig.ProjectionApiBaseUrl;


            CommonServices = new CommonServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            SeasonServices = new SeasonServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            GameServices = new GameServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            NewsServices = new NewsServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            StadiumsServices = new StadiumsServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            StandingsServices = new StandingsServices(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            OpponentSeasonServices = new OpponentSeasonServices(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            TeamServices = new TeamServices(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            BoxScoreServices = new BoxScoreServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            //DfsSlateServices = new DfsSlateServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);            
            PlayerServices = new PlayerServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            PlayerGameServices = new PlayerGameServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);            
            TeamSeasonServices = new TeamSeasonServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            BoxScorePbpServices = new BoxScorePbpServices(PbpApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);            
            PlayerSeasonServices = new PlayerSeasonServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);

            DfsSlateServices = new DfsSlateServices(ProjectionApiBaseUrl.AbsoluteUri, NBAConfig.ProjectionPrimarySubscriptionKey, NBAConfig.ProjectionSecondarySubscriptionKey);
            ProjectionServices = new ProjectionServices(ProjectionApiBaseUrl.AbsoluteUri, NBAConfig.ProjectionPrimarySubscriptionKey, NBAConfig.ProjectionSecondarySubscriptionKey);
        }

        /// <summary>
        /// 
        /// </summary>
        public FantasyNBAClient()
      : this(NBAConfig.PrimarySubscriptionKey, NBAConfig.SecondarySubscriptionKey)
        { }

        #endregion
    }
}

