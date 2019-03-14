using FantasyData.NFL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Contracts
{    
    public interface IPlayerGameProjectionsService
    {
        PlayerGameProjections GetProjectedPlayerGameStatsbyPlayer(string Season,int Week,int PlayerId);

        PlayerGameProjections GetProjectedPlayerGameStatsbyTeam(string Season, int Week, string Team);

        PlayerGameProjections GetProjectedPlayerGameStatsbyWeek(string Season,int Week);
    }
}
