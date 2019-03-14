using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NBA.Entities
{
    public class Teams : List<Team>
    { }
    public class Team
    {
        public int TeamID { get; set; }

        public string Key { get; set; }

        public bool Active { get; set; }

        public string City { get; set; }

        public string Name { get; set; }

        public int? LeagueID { get; set; }

        public int? StadiumID { get; set; }

        public string Conference { get; set; }

        public string Division { get; set; }

        public string PrimaryColor { get; set; }

        public string SecondaryColor { get; set; }

        public string TertiaryColor { get; set; }

        public string QuaternaryColor { get; set; }

        public string WikipediaLogoUrl { get; set; }

        public string WikipediaWordMarkUrl { get; set; }

        public int GlobalTeamID { get; set; }

    }

}
