using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.NBA.Entities;
using FantasyData.Utils;

namespace FantasyData.NBA.Services
{    
    public interface IBoxScorePbpServices
    {        
        BoxScores GetPlayByPlay(string gameid);
        BoxScores GetPlayByPlayDelta(DateTime date, string minutes);
    }
    public class BoxScorePbpServices : FantasyDataApiBase, IBoxScorePbpServices
    {        
        private static readonly string PlayByPlay = "PlayByPlay";
        private static readonly string PlayByPlayDelta = "PlayByPlayDelta";

        public BoxScorePbpServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }        
        public BoxScores GetPlayByPlay(string gameid)
        {
            var url = string.Format("/{0}/{1}", PlayByPlay, gameid);
            return GetRequest<BoxScores>(url);
        }
        public BoxScores GetPlayByPlayDelta(DateTime date, string minutes)
        {
            var url = string.Format("/{0}/{1}/{2}", PlayByPlayDelta, date.ToApiDate(), minutes);
            return GetRequest<BoxScores>(url);
        }
    }
}
