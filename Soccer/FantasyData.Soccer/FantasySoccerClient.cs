using FantasyData.Soccer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Soccer
{
    public class FantasySoccerClient
    {
        #region Accessors
        public IAreaServices AreaServices { get; private set; }
        public ICompetitionServices CompetitionServices { get; private set; }
        public ISeasonServices SeasonServices { get; private set; }
        public IBoxScoreService BoxScoreServices { get; private set; }
        public IGameServices GameServices { get; private set; }
        public IMembershipServices MembershipServices { get; private set; }
        public IPlayerGameStatServices PlayerGameStatServices { get; private set; }
        public IPlayerSeasonStatServices PlayerSeasonStatServices { get; private set; }
        public IPlayerServices PlayerServices { get; private set; }
        public IStandingServices StandingServices { get; private set; }
        public IScheduleServices ScheduleServices { get; private set; }
        public ITeamGameServices TeamGameServices { get; private set; }
        public ITeamSeasonService TeamSeasonService { get; private set; }
        public ITeamServices TeamServices { get; private set; }
        public IVenueServices VenueServices { get; private set; }

        public IProjectionServices ProjectionServices { get; private set; }

        #endregion   Accessors

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiBaseUrl"></param>
        /// <param name="primarySubscriptionKey"></param>
        /// <param name="secondarySubscriptionKey"></param>
        public FantasySoccerClient(string primarySubscriptionKey, string secondarySubscriptionKey)
        {
            Uri statApiBaseUrl = SoccerConfig.StateApiBaseUrl;
            Uri scoreApiBaseUrl = SoccerConfig.ScoreApiBaseUrl;
            Uri ProjectionApiBaseUrl = SoccerConfig.ProjectionApiBaseUrl;
            AreaServices = new AreaServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            CompetitionServices = new CompetitionServices(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey); 
            SeasonServices = new SeasonServices(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            BoxScoreServices = new BoxScoreService(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            GameServices = new GameServices(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            MembershipServices = new MembershipServices(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            
            PlayerGameStatServices = new PlayerGameStatServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            PlayerSeasonStatServices = new PlayerSeasonStatServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            PlayerServices = new PlayerServices(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            ScheduleServices = new ScheduleServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            SeasonServices = new SeasonServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            StandingServices = new StandingServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            TeamGameServices = new TeamGameServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            TeamSeasonService = new TeamSeasonService(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            TeamServices = new TeamServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            VenueServices = new VenueServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);

            ProjectionServices = new ProjectionServices(ProjectionApiBaseUrl.AbsoluteUri, SoccerConfig.ProjectionPrimarySubscriptionKey, SoccerConfig.ProjectionSecondarySubscriptionKey);
        }

        /// <summary>
        /// 
        /// </summary>
        public FantasySoccerClient()
      : this(SoccerConfig.PrimarySubscriptionKey, SoccerConfig.SecondarySubscriptionKey)
        { }
        //  public FantasySoccerClient()
        //: this(SoccerConfig.ApiBaseUrl.AbsoluteUri, SoccerConfig.PrimarySubscriptionKey, SoccerConfig.SecondarySubscriptionKey)
        //  { }

        #endregion
    }
}
