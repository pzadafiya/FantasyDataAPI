using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.NHL.Entities;
using FantasyData.Utils;

namespace FantasyData.NHL.Services
{
    public interface IBoxScoreService
    {
        BoxScores BoxScoresbyDateDelta(DateTime Date, int Minutes);
        BoxScores GetBoxScoresByDate(DateTime Date);        
    }

    public class BoxScoreServices : FantasyDataApiBase, IBoxScoreService
    {
        
        private static readonly string BoxScoresDelta = "BoxScoresDelta";
        private static readonly string BoxScores = "BoxScores";        

        public BoxScoreServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }
                
        public BoxScores BoxScoresbyDateDelta(DateTime Date, int Minutes)
        {
            var url = string.Format("/{0}/{1}/{2}", BoxScoresDelta, Date.ToApiDate(), Minutes);
            return GetRequest<BoxScores>(url);
        }

        public BoxScores GetBoxScoresByDate(DateTime Date)
        {
            var url = string.Format("/{0}/{1}", BoxScores, Date.ToApiDate());
            return GetRequest<BoxScores>(url);
        }        
    }
}
