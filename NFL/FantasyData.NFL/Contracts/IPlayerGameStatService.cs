using FantasyData.NFL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Contracts
{
  public interface IPlayerGameStatService
  {
      PlayerGame GetByGame(int playerId, string season, int week);
      PlayerGames GetByTeamAndWeek(TeamTypes team, string season, int week);
      PlayerGames GetByWeek(string season, int week);
    PlayerGames GetPlayerGameByMinutes(int minutes);
  }
}
