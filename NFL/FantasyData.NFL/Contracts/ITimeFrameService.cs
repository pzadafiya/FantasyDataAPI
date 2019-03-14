using FantasyData.NFL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Contracts
{
    public interface ITimeFrameService
    {
         TimeFrames GetAllTimeFrames();

         TimeFrames GetRecentTimeFrames();

         TimeFrames GetCompletedTimeFrames();

         TimeFrames GetUpcomingTimeFrames();

         TimeFrames GetCurrentTimeFrames();
    }
}
