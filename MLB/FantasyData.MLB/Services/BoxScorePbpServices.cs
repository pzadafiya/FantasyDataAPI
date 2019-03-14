using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.MLB.Entities;
using FantasyData.Utils;

namespace FantasyData.MLB.Services
{
    public interface IBoxScorePbpServices
    {
        PlayByPlays GetPlayByPlay(string gameid);
        PlayByPlays GetPlayByPlayDelta(DateTime date, string minutes);
    }
    public class BoxScorePbpServices : FantasyDataApiBase, IBoxScorePbpServices
    {
        private static readonly string PlayByPlay = "PlayByPlay";
        private static readonly string PlayByPlayDelta = "PlayByPlayDelta";

        public BoxScorePbpServices(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
        { }
        public PlayByPlays GetPlayByPlay(string gameid)
        {
            var url = string.Format("/{0}/{1}", PlayByPlay, gameid);
            return GetRequest<PlayByPlays>(url);
        }
        public PlayByPlays GetPlayByPlayDelta(DateTime date, string minutes)
        {
            var url = string.Format("/{0}/{1}/{2}", PlayByPlayDelta, date.ToApiDate(), minutes);
            return GetRequest<PlayByPlays>(url);
        }
    }
}
