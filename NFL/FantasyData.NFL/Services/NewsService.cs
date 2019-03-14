﻿using FantasyData.NFL.Entities;
using FantasyData.NFL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyData.Utils;

namespace FantasyData.NFL.Services
{
    public class NewsService : FantasyDataApiBase, INewsService
    {
        private static readonly string NewsKey = "News";
        private static readonly string NewsByTeamKey = "NewsByTeam";
        private static readonly string NewsByPlayerIDKey = "NewsByPlayerID";
        private static readonly string NewsByDate = "NewsByDate";

        public NewsService(string baseUrl, string primarySusbscriptionKey, string secondarySubscriptionKey)
          : base(baseUrl, primarySusbscriptionKey, secondarySubscriptionKey)
        { }


        public News GetNews()
        {
            var url = string.Format("/{0}", NewsKey);

            return GetRequest<News>(url);
        }


        public News GetForTeam(TeamTypes team)
        {
            var url = string.Format("/{0}/{1}", NewsByTeamKey, team.ToString());

            return GetRequest<News>(url);
        }


        public News GetForPlayer(int playerId)
        {
            var url = string.Format("/{0}/{1}", NewsByPlayerIDKey, playerId);

            return GetRequest<News>(url);
        }
        public News GetNewsbyDate(DateTime date)
        { 
        var url = string.Format("/{0}/{1}", NewsByDate, date.ToApiDate());

            return GetRequest<News>(url);
        }

    }
}
