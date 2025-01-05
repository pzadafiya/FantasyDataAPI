using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.Configuration;

namespace FantasyData
{
    /// <summary>
    /// 
    /// </summary>
    public class NFLConfig
    {

        private const string SectionTagName = "fantasyData";       
        public static string PrimarySubscriptionKey
        {
            get
            {
                var config = ConfigurationManager.GetSection(SectionTagName) as FantasyDataSubscriptionRetrieverSection;
                FantasyDataSubscriptionElement section = config.GetFirstOrDefault();
                return section.PrimarySubscriptionKey;
            }
        }        
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

        public static Uri HeadshotApiBaseUrl
        {
            get
            {
                var config = ConfigurationManager.GetSection(SectionTagName) as FantasyDataSubscriptionRetrieverSection;
                FantasyDataSubscriptionElement section = config.GetFirstOrDefault();
                return section.HeadshotApiBaseUrl;
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
