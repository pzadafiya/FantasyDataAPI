using FantasyData.NFL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Contracts
{    
    public interface IPlayerSeasonProjectionService
    {
        PlayerSeasonProjections GetProjectedPlayerSeasonStats(string Season);

        PlayerSeasonProjections GetProjectedPlayerSeasonStatsbyPlayer(string Season, int PlayerID);

        PlayerSeasonProjections GetProjectedPlayerSeasonStatsbyTeam(string Season, string Team);
    }
}
