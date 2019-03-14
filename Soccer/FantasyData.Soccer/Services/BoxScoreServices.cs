using FantasyData.Soccer.Entities;
using FantasyData.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Soccer.Services
{
    public interface IBoxScoreService
    {
        BoxScore Get(string GameID);
        BoxScores GetBoxScoreByDate(DateTime GameDate);
        BoxScores GetBoxScoreByCompetition(string Competition, DateTime GameDate);
        BoxScores GetDelta(string season, DateTime date, int minutes);
        BoxScores GetDeltaByCompetition(string Competition, DateTime date, int minutes);
    }
    public class BoxScoreService : FantasyDataApiBase, IBoxScoreService
    {
        private static readonly string BoxScoreKey = "BoxScore";
        private static readonly string BoxScoresKey = "BoxScores";
        private static readonly string BoxScoresByCompetitionKey = "BoxScoresByCompetition";
        private static readonly string DeltaBoxScoresKey = "BoxScoresDelta";
        private static readonly string BoxScoresDeltaByCompetitionKey = "BoxScoresDeltaByCompetition";

        public BoxScoreService(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }

        public BoxScore Get(string GameID)
        {
            var url = string.Format("/{0}/{1}", BoxScoreKey, GameID);
            return this.GetRequest<BoxScore>(url);
        }
        /// <summary>
        /// Game Score by GameDate
        /// </summary>
        /// <param name="GameDate">Game date format : yyyy-MM-dd</param>
        /// <returns></returns>
        public BoxScores GetBoxScoreByDate(DateTime GameDate)
        {
            var url = string.Format("/{0}/{1}", BoxScoresKey, GameDate.ToApiDate());
            return this.GetRequest<BoxScores>(url);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Competition">An indication of a soccer competition/league. 
        /// This value can be the CompetitionId or the Competition Key. Possible values include: EPL, 1, MLS, 8, etc.</param>
        /// <param name="GameDate">Game date format : yyyy-MM-dd</param>
        /// <returns></returns>
        public BoxScores GetBoxScoreByCompetition(string Competition, DateTime GameDate)
        {
            var url = string.Format("/{0}/{1}/{2}", BoxScoresByCompetitionKey, Competition, GameDate.ToApiDate());
            return this.GetRequest<BoxScores>(url);
        }

        public BoxScores GetDelta(string season, DateTime date, int minutes)
        {
            var url = string.Format("/{0}/{1}/{2}", DeltaBoxScoresKey, date.ToApiDate(), minutes);
            return this.GetRequest<BoxScores>(url);
        }

        public BoxScores GetDeltaByCompetition(string Competition, DateTime date, int minutes)
        {
            var url = string.Format("/{0}/{1}/{2}/{3}", BoxScoresDeltaByCompetitionKey, Competition, date.ToApiDate(), minutes);
            return this.GetRequest<BoxScores>(url);
        }
    }
}
