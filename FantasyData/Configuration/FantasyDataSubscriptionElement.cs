using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Configuration
{
    public class FantasyDataSubscriptionElement : ConfigurationElement
    {
        [ConfigurationProperty("name", IsRequired = true, IsKey = true)]
        public string Name
        {
            get
            {
                return (string)this["name"];
            }
            set
            {
                this["name"] = value;
            }
        }

        [ConfigurationProperty("baseUrl", IsRequired = true, DefaultValue = "http://api.nfldata.apiphany.com/developer/")]
        public Uri ApiBaseUrl
        {
            get
            {
                return (Uri)this["baseUrl"];
            }
            set
            {
                this["baseUrl"] = value;
            }
        }

        public Uri StatApiBaseUrl
        {
            get
            {
                return new Uri(ApiBaseUrl + "/stats/");
            }
        }
        public Uri ScoreApiBaseUrl
        {
            get
            {
                return new Uri(ApiBaseUrl + "/scores/");
            }
        }
        public Uri HeadshotApiBaseUrl
        {
            get
            {
                return new Uri(ApiBaseUrl + "/headshots/");
            }
        }
        public Uri PbpApiBaseUrl
        {
            get
            {
                return new Uri(ApiBaseUrl + "/pbp/");
            }
        }

        public Uri ProjectionApiBaseUrl
        {
            get
            {
                return new Uri(ApiBaseUrl + "/projections/");
            }
        }


        [ConfigurationProperty("primarySubscriptionKey", IsRequired = true, DefaultValue = "NotSet")]
        public string PrimarySubscriptionKey
        {
            get
            {
                return (string)this["primarySubscriptionKey"];
            }
            set
            {
                this["primarySubscriptionKey"] = value;
            }
        }

        [ConfigurationProperty("secondarySubscriptionKey", IsRequired = false, DefaultValue = "NotSet")]
        public string SecondarySubscriptionKey
        {
            get
            {
                return (string)this["secondarySubscriptionKey"];
            }
            set
            {
                this["secondarySubscriptionKey"] = value;
            }
        }

        [ConfigurationProperty("projectionPrimarySubscriptionKey", IsRequired = false, DefaultValue = "NotSet")]
        public string ProjectionPrimarySubscriptionKey
        {
            get
            {
                return (string)this["projectionPrimarySubscriptionKey"];
            }
            set
            {
                this["projectionPrimarySubscriptionKey"] = value;
            }
        }

        [ConfigurationProperty("projectionSecondarySubscriptionKey", IsRequired = false, DefaultValue = "NotSet")]
        public string ProjectionSecondarySubscriptionKey
        {
            get
            {
                return (string)this["projectionSecondarySubscriptionKey"];
            }
            set
            {
                this["projectionSecondarySubscriptionKey"] = value;
            }
        }

        [ConfigurationProperty("PlayByPlayPrimarySubscriptionKey", IsRequired = false, DefaultValue = "NotSet")]
        public string PlayByPlayPrimarySubscriptionKey
        {
            get
            {
                return (string)this["PlayByPlayPrimarySubscriptionKey"];
            }
            set
            {
                this["PlayByPlayPrimarySubscriptionKey"] = value;
            }
        }

        [ConfigurationProperty("PlayByPlaySecondarySubscriptionKey", IsRequired = false, DefaultValue = "NotSet")]
        public string PlayByPlaySecondarySubscriptionKey
        {
            get
            {
                return (string)this["PlayByPlaySecondarySubscriptionKey"];
            }
            set
            {
                this["PlayByPlaySecondarySubscriptionKey"] = value;
            }
        }
    }
}
