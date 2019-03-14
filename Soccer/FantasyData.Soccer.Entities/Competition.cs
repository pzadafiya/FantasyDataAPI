using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Soccer.Entities
{
    public class Competitions : List<Competition>
    { }
    public class Competition
    {
        public int CompetitionId { get; set; }
        public int AreaId { get; set; }
        public string AreaName { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Type { get; set; }
        public string Format { get; set; }
        public SoccerSeasons Seasons { get; set; }

        /// <summary>
        /// Added for Competition fixutures only
        /// </summary>
        public SoccerSeasons CurrentSeason { get; set; }
        /// <summary>
        /// Added for Competition fixutures only
        /// </summary>
        public Teams Teams { get; set; }
        /// <summary>
        /// Added for Competition fixutures only
        /// </summary>
        public Games Games { get; set; }
    }

    public class CompetitionHierarchies : List<CompetitionHierarchy> { }
    public class CompetitionHierarchy
    {
        public int AreaId { get; set; }
        public string CountryCode { get; set; }
        public string Name { get; set; }
        public Competitions Competitions { get; set; }
    }
}
