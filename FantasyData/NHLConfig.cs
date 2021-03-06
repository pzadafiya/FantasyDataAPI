﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using FantasyData.Configuration;

namespace FantasyData
{
    public class NHLConfig
    {
        private const string SectionTagName = "fantasyDataNHL";
        /// <summary>
        /// 
        /// </summary>
        public static string PrimarySubscriptionKey
        {
            get
            {
                var config = ConfigurationManager.GetSection(SectionTagName) as FantasyDataSubscriptionRetrieverSection;
                FantasyDataSubscriptionElement section = config.GetFirstOrDefault();
                return section.PrimarySubscriptionKey;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static string SecondarySubscriptionKey
        {
            get
            {
                var config = ConfigurationManager.GetSection(SectionTagName) as FantasyDataSubscriptionRetrieverSection;
                FantasyDataSubscriptionElement section = config.GetFirstOrDefault();
                return section.SecondarySubscriptionKey;
            }
        }

        public static Uri ApiBaseUrl
        {
            get
            {
                var config = ConfigurationManager.GetSection(SectionTagName) as FantasyDataSubscriptionRetrieverSection;
                FantasyDataSubscriptionElement section = config.GetFirstOrDefault();
                return section.ApiBaseUrl;
            }
        }
        public static Uri StateApiBaseUrl
        {
            get
            {
                var config = ConfigurationManager.GetSection(SectionTagName) as FantasyDataSubscriptionRetrieverSection;
                FantasyDataSubscriptionElement section = config.GetFirstOrDefault();
                return section.StatApiBaseUrl;
            }
        }

        public static Uri ScoreApiBaseUrl
        {
            get
            {
                var config = ConfigurationManager.GetSection(SectionTagName) as FantasyDataSubscriptionRetrieverSection;
                FantasyDataSubscriptionElement section = config.GetFirstOrDefault();
                return section.ScoreApiBaseUrl;
            }
        }
        public static Uri ProjectionApiBaseUrl
        {
            get
            {
                var config = ConfigurationManager.GetSection(SectionTagName) as FantasyDataSubscriptionRetrieverSection;
                FantasyDataSubscriptionElement section = config.GetFirstOrDefault();
                return section.ProjectionApiBaseUrl;
            }
        }

        public static string ProjectionPrimarySubscriptionKey
        {
            get
            {
                var config = ConfigurationManager.GetSection(SectionTagName) as FantasyDataSubscriptionRetrieverSection;
                FantasyDataSubscriptionElement section = config.GetFirstOrDefault();
                return section.ProjectionPrimarySubscriptionKey;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static string ProjectionSecondarySubscriptionKey
        {
            get
            {
                var config = ConfigurationManager.GetSection(SectionTagName) as FantasyDataSubscriptionRetrieverSection;
                FantasyDataSubscriptionElement section = config.GetFirstOrDefault();
                return section.ProjectionSecondarySubscriptionKey;
            }
        }
    }
}
