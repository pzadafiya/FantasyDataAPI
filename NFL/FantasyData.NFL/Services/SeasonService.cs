﻿using FantasyData.NFL.Entities;
using FantasyData.NFL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Services
{
    public class SeasonService : FantasyDataApiBase, ISeasonService
    {
        private static readonly string AreGamesInProgressKey = "AreAnyGamesInProgress";
        private static readonly string UpcomingSeasonKey = "UpcomingSeason";
        private static readonly string UpcomingWeekKey = "UpcomingWeek";
        private static readonly string CurrentSeasonKey = "CurrentSeason";
        private static readonly string CurrentWeekKey = "CurrentWeek";
        private static readonly string LastCompletedSeasonKey = "LastCompletedSeason";
        private static readonly string LastCompletedWeekKey = "LastCompletedWeek";
        private static readonly string ByesKey = "Byes";
        private static readonly string ScoresKey = "Scores";
        private static readonly string NFLTeamScoreByWeek = "ScoresByWeek";

        public SeasonService(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }


        /// <summary>
        /// Returns true if there is at least one game being played at the time of the request or false if there are none.
        /// </summary>
        public bool IsGameInProgress
        {
            get
            {
                string url = string.Format("/{0}", AreGamesInProgressKey);

                return GetBool(url);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int UpcomingSeason
        {
            get
            {
                string url = string.Format("/{0}", UpcomingSeasonKey);

                var season = GetInt(url);

                return Convert.ToInt32(season);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int UpcomingWeek
        {
            get
            {
                string url = string.Format("/{0}", UpcomingWeekKey);

                var week = GetInt(url);

                return Convert.ToInt32(week);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int CurrentSeason
        {
            get
            {
                var url = string.Format("/{0}", CurrentSeasonKey);

                var season = GetInt(url);

                return Convert.ToInt32(season);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int CurrentWeek
        {
            get
            {
                var url = string.Format("/{0}", CurrentWeekKey);

                var week = GetInt(url);

                return Convert.ToInt32(week);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int LastCompletedSeason
        {
            get
            {
                var url = string.Format("/{0}", LastCompletedSeasonKey);

                var season = GetInt(url);

                return Convert.ToInt32(season);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int LastCompletedWeek
        {
            get
            {
                var url = string.Format("/{0}", LastCompletedWeekKey);

                var week = GetInt(url);

                return Convert.ToInt32(week);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="season"></param>
        /// <returns></returns>
        public TeamByeWeeks GetByeWeeks(string season)
        {
            var url = string.Format("/{0}/{1}", ByesKey, season);

            return GetRequest<TeamByeWeeks>(url);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="season"></param>
        /// <returns></returns>
        public Scores GetScores(string season)
        {
            var url = string.Format("/{0}/{1}", ScoresKey, season);
            return this.GetRequest<Scores>(url);
        }

        public Scores GetNFLTeamScoreByWeek(string season, int week)
        {
            var url = string.Format("/{0}/{1}/{2}", NFLTeamScoreByWeek, season, week);
            return this.GetRequest<Scores>(url);
        }
    }
}
