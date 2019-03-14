﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Services
{
    using FantasyData;
    using FantasyData.NFL.Entities;
    using FantasyData.NFL.Contracts;

    public class BoxScoreService : FantasyDataApiBase, IBoxScoreService
    {
        private static readonly string BoxScoreKey = "BoxScore";
        private static readonly string BoxScoresKey = "BoxScores";
        private static readonly string FinalBoxScoresKey = "FinalBoxScores";
        private static readonly string ActiveBoxScoresKey = "ActiveBoxScores";
        private static readonly string LiveBoxScoresKey = "LiveBoxScores";
        private static readonly string RecentlyUpdatedBoxScoresKey = "RecentlyUpdatedBoxScores";
        private static readonly string DeltaBoxScoresKey = "BoxScoresDelta";
       
        public BoxScoreService(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="season"></param>
        /// <param name="week"></param>
        /// <param name="homeTeam"></param>
        /// <returns></returns>
        public BoxScore Get(string season, int week, string homeTeam)
        {
            var url = string.Format("/{0}/{1}/{2}/{3}", BoxScoreKey, season, week, homeTeam);
            return this.GetRequest<BoxScore>(url);
        }

        /// <summary>
        /// Returns box scores that have changed in last X minutes.
        /// </summary>
        /// <param name="minutesAgo">Number of minutes. (Must be 1 or 2 )</param>
        /// <returns></returns>
        public BoxScores RecentlyUpdated(int minutesAgo)
        {
            //if (minutesAgo < 1 || minutesAgo > 2)
            //{
            //    throw new FantasyDataException("MinutesAgo must be 1 or 2.");
            //}

            var url = string.Format("/{0}/{1}", RecentlyUpdatedBoxScoresKey, minutesAgo);
            return this.GetRequest<BoxScores>(url);
        }

        /// <summary>
        /// Gets box scores for all games that are either in-progress or have been updated within the last 30 minutes.
        /// </summary>
        /// <returns></returns>
        public BoxScores GetActive()
        {
            var url = string.Format("/{0}", ActiveBoxScoresKey);
            return this.GetRequest<BoxScores>(url);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="season"></param>
        /// <param name="week"></param>
        /// <returns></returns>
        public BoxScores GetForSeasonAndWeek(string season, int week)
        {
            var url = string.Format("/{0}/{1}/{2}", BoxScoresKey, season, week);
            return this.GetRequest<BoxScores>(url);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public BoxScores GetFinal()
        {
            var url = string.Format("/{0}", FinalBoxScoresKey);
            return this.GetRequest<BoxScores>(url);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public BoxScores GetLive()
        {
            var url = string.Format("/{0}", LiveBoxScoresKey);
            return this.GetRequest<BoxScores>(url);
        }

        public BoxScores GetDelta(string season, int week,int minutes)
        {
            var url = string.Format("/{0}/{1}/{2}/{3}", DeltaBoxScoresKey, season, week,minutes);
            return this.GetRequest<BoxScores>(url);
        }

        
    }
}
