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
  public class DailyFantasyService : FantasyDataApiBase, IDailyFantasyService
  {
    public static readonly string DailyFantasyPlayersKey = "DailyFantasyPlayers";
    public static readonly string DailyFantasyScoringKey = "DailyFantasyPoints";

    public DailyFantasyService(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
      : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
    { }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="date"></param>
    /// <returns></returns>
    public DailyFantasyPlayers GetDailyFantasyPlayers(DateTime date)
    {
      string url = string.Format("/{0}/{1}", DailyFantasyPlayersKey, date.ToApiDate());

      return GetRequest<DailyFantasyPlayers>(url);
    }
    public DailyFantasyScorings GetDailyFantasyScorings(DateTime date)
    {
        string url = string.Format("/{0}/{1}", DailyFantasyScoringKey, date.ToApiDate());

        return GetRequest<DailyFantasyScorings>(url);
    }
  }
}
