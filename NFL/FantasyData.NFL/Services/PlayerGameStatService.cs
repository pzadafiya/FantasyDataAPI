using FantasyData.NFL.Entities;
using FantasyData.NFL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Services
{
  public class PlayerGameStatService : FantasyDataApiBase, IPlayerGameStatService
  {
    private static readonly string PlayerGameStatsByPlayerKey = "PlayerGameStatsByPlayerID";
    private static readonly string PlayerGameStatsByTeamKey = "PlayerGameStatsByTeam";
    private static readonly string PlayerGameStatsByWeekKey = "PlayerGameStatsByWeek";
    private static readonly string PlayerGameStatsByMinuteKey = "PlayerGameStatsDelta";
      

    public PlayerGameStatService(string baseUrl, string primarySubscriptionKey, string secondarySubscriptionKey)
      : base(baseUrl, primarySubscriptionKey, secondarySubscriptionKey)
    { }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="playerId"></param>
    /// <param name="week"></param>
    /// <param name="season"></param>
    /// <returns></returns>
    public PlayerGame GetByGame(int playerId, string season, int week)
    {
      string url = string.Format("/{0}/{1}/{2}/{3}", PlayerGameStatsByPlayerKey, season, week, playerId);

      return GetRequest<PlayerGame>(url);
    }
      /// <summary>
      /// return palyer game Data of Recently updated
      /// </summary>
      /// <param name="minutes"></param>
      /// <returns></returns>
    public PlayerGames GetPlayerGameByMinutes(int minutes)
    {
        string url = string.Format("/{0}/{1}", PlayerGameStatsByMinuteKey, minutes);

      return GetRequest<PlayerGames>(url);
    } 
    /// <summary>
    /// 
    /// </summary>
    /// <param name="team"></param>
    /// <param name="week"></param>
    /// <param name="season"></param>
    /// <returns></returns>
    public PlayerGames GetByTeamAndWeek(TeamTypes team, string season, int week)
    {
      string url = string.Format("/{0}/{1}/{2}/{3}", PlayerGameStatsByTeamKey, season, week, team.ToString());

      return GetRequest<PlayerGames>(url);
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="week"></param>
    /// <param name="season"></param>
    /// <returns></returns>
    public PlayerGames GetByWeek(string season, int week)
    {
      string url = string.Format("/{0}/{1}/{2}", PlayerGameStatsByWeekKey, season, week);

      return GetRequest<PlayerGames>(url);
    }
  }
}
