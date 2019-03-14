﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NBA.Entities
{
    public class Articles : List<Article>
    { }
    public class Article
    {
        public int ArticleID { get; set; }

        public string Title { get; set; }

        public string Source { get; set; }

        public DateTime Updated { get; set; }

        public string Content { get; set; }

        public string Url { get; set; }

        public string TermsOfUse { get; set; }

        public string Author { get; set; }

    }


}
