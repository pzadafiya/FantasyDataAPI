﻿using FantasyData.NFL.Entities;
using FantasyData.NFL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Contracts
{
    public interface ITeamService
    {
        Standings GetStandingsBySeason(string season);
        Teams Get();
    }
}
