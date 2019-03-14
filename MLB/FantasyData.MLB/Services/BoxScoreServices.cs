using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.MLB.Entities;
using FantasyData.Utils;

namespace FantasyData.MLB.Services
{
    public interface IBoxScoreServices
    {
        BoxScores GetBoxScore(string gameid);
        BoxScores GetBoxScoresbyDate(DateTime date);
        BoxScores GetBoxScoresbyDateDelta(DateTime date, string minutes);
    }
    public class BoxScoreServices : FantasyDataApiBase, IBoxScoreServices
    {
        private static readonly string BoxScore = "BoxScore";
        private static readonly string BoxScores = "BoxScores";
        private static readonly string BoxScoresDelta = "BoxScoresDelta";

        public BoxScoreServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }
        public BoxScores GetBoxScore(string gameid)
        {
            var url = string.Format("/{0}/{1}", BoxScore, gameid);
            return GetRequest<BoxScores>(url);
        }
        public BoxScores GetBoxScoresbyDate(DateTime date)
        {
            var url = string.Format("/{0}/{1}", BoxScores, date.ToApiDate());
            return GetRequest<BoxScores>(url);
        }
        public BoxScores GetBoxScoresbyDateDelta(DateTime date, string minutes)
        {
            var url = string.Format("/{0}/{1}/{2}", BoxScoresDelta, date.ToApiDate(), minutes);
            return GetRequest<BoxScores>(url);
        }
    }
}
