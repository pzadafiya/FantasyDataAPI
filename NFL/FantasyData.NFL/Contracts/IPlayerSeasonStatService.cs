using FantasyData.NFL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Contracts
{
  public interface IPlayerSeasonStatService
  {
      PlayerSeasons GetByPlayer(int playerId, string season);
      PlayerSeasons GetByTeam(TeamTypes team, string season);
  }
}
