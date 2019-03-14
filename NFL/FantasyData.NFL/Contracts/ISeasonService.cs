using FantasyData.NFL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Contracts
{
    public interface ISeasonService
    {
        bool IsGameInProgress { get; }
        int UpcomingSeason { get; }
        int UpcomingWeek { get; }
        int CurrentSeason { get; }
        int CurrentWeek { get; }
        int LastCompletedSeason { get; }
        int LastCompletedWeek { get; }
        TeamByeWeeks GetByeWeeks(string season);
        Scores GetScores(string season);
        Scores GetNFLTeamScoreByWeek(string season, int week);
    }
}
