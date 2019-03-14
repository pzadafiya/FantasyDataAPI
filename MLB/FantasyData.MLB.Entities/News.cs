using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.MLB.Entities
{
    public class Newses : List<News>
    { }
    public class News
    {
        public int NewsID { get; set; }

        public string Source { get; set; }

        public DateTime Updated { get; set; }

        public string TimeAgo { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Url { get; set; }

        public string TermsOfUse { get; set; }

        public string Author { get; set; }

        public string Categories { get; set; }

        public int? PlayerID { get; set; }

        public int? TeamID { get; set; }

        public string Team { get; set; }

        public int? PlayerID2 { get; set; }

        public int? TeamID2 { get; set; }

        public string Team2 { get; set; }

    }

}
