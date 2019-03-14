using FantasyData.NFL.Services;
using FantasyData.NFL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL
{
    public class FantasyDataClient
    {
        #region Accessors

        public IDailyFantasyService DailyFantasyService { get; private set; }
        public ISeasonService SeasonService { get; private set; }
        public INewsService NewsService { get; private set; }
        public IPlayerGameStatService PlayerGameStatService { get; private set; }
        public IPlayerSeasonStatService PlayerSeasonStatService { get; private set; }
        public ITeamDefenseService TeamDefenseService { get; private set; }
        public IGameService GameService { get; private set; }
        public IInjuryService InjuryService { get; private set; }
        public IStadiumService StadiumService { get; private set; }
        public ITeamService TeamService { get; private set; }
        public IBoxScoreService BoxScoreService { get; private set; }
        public IPlayerService PlayerService { get; private set; }

        public IScheduleService ScheduleService { get; private set; }
        public ITimeFrameService TimeFrameService { get; private set; }
        public ITeamSeasonService TeamSeasonService { get; private set; }
        public ITeamGameService TeamGameService { get; private set; }
        public IScoresService ScoresService { get; private set; }
        public IDfsSlateService DfsSlateService { get; private set; }
        public IPlayerGameProjectionsService PlayerGameProjectionsService { get; private set; }

        public IPlayerSeasonProjectionService PlayerSeasonProjectionService { get; private set; }

        #endregion


        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiBaseUrl"></param>
        /// <param name="primarySubscriptionKey"></param>
        /// <param name="secondarySubscriptionKey"></param>
        public FantasyDataClient(string primarySubscriptionKey, string secondarySubscriptionKey)
        {
            Uri statApiBaseUrl = NFLConfig.StateApiBaseUrl;
            Uri scoreApiBaseUrl = NFLConfig.ScoreApiBaseUrl;
            Uri ProjectionApiBaseUrl = NFLConfig.ProjectionApiBaseUrl;

            DailyFantasyService = new DailyFantasyService(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            SeasonService = new SeasonService(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            NewsService = new NewsService(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            PlayerGameStatService = new PlayerGameStatService(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            PlayerSeasonStatService = new PlayerSeasonStatService(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            TeamDefenseService = new TeamDefenseService(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            GameService = new GameService(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            InjuryService = new InjuryService(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            StadiumService = new StadiumService(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            TeamService = new TeamService(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            BoxScoreService = new BoxScoreService(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            PlayerService = new PlayerService(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            ScheduleService = new ScheduleService(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            TimeFrameService = new TimeFrameService(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            TeamSeasonService = new TeamSeasonService(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            TeamGameService = new TeamGameService(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            ScoresService = new ScoresService(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            ScoresService = new ScoresService(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey, secondarySubscriptionKey);
            DfsSlateService = new DfsSlateService(ProjectionApiBaseUrl.AbsoluteUri, NFLConfig.ProjectionPrimarySubscriptionKey, NFLConfig.ProjectionSecondarySubscriptionKey);
            PlayerGameProjectionsService = new PlayerGameProjectionService(ProjectionApiBaseUrl.AbsoluteUri, NFLConfig.ProjectionPrimarySubscriptionKey, NFLConfig.ProjectionSecondarySubscriptionKey);
            PlayerSeasonProjectionService = new PlayerSeasonProjectionService(ProjectionApiBaseUrl.AbsoluteUri, NFLConfig.ProjectionPrimarySubscriptionKey, NFLConfig.ProjectionSecondarySubscriptionKey);
        }

        /// <summary>
        /// 
        /// </summary>
        public FantasyDataClient()
          : this(NFLConfig.PrimarySubscriptionKey, NFLConfig.SecondarySubscriptionKey)
        { }

        #endregion
    }
}
