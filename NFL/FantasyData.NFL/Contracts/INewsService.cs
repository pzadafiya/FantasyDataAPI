﻿using FantasyData.NFL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Contracts
{
    public interface INewsService
    {
        News GetNews();
        News GetForTeam(TeamTypes team);
        News GetForPlayer(int playerId);
        News GetNewsbyDate(DateTime date);
    }
}
