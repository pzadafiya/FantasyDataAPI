using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Entities
{
  public class Players : List<Player>
  { }

  public class Player
  {
    public Player()
    {
      //LatestNews = new News();
      //InjuryStatus = new Injury();
      //PlayerSeason = new PlayerSeason();
    }

        public int PlayerID { get; set; }
        public string Team { get; set; }
        public int Number { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Status { get; set; }
        public string Height { get; set; }
        public int Weight { get; set; }
        public string BirthDate { get; set; }
        public string College { get; set; }
        public int Experience { get; set; }
        public string FantasyPosition { get; set; }
        public bool Active { get; set; }
        public string PositionCategory { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string ExperienceString { get; set; }
        public string BirthDateString { get; set; }
        public string PhotoUrl { get; set; }
        public int? ByeWeek { get; set; }
        public string UpcomingGameOpponent { get; set; }
        public int UpcomingGameWeek { get; set; }
        public string ShortName { get; set; }
        public double? AverageDraftPosition { get; set; }
        public string DepthPositionCategory { get; set; }
        public string DepthPosition { get; set; }
        public int? DepthOrder { get; set; }
        public int? DepthDisplayOrder { get; set; }
        public string CurrentTeam { get; set; }
        public string CollegeDraftTeam { get; set; }
        public int CollegeDraftYear { get; set; }
        public int? CollegeDraftRound { get; set; }
        public int? CollegeDraftPick { get; set; }
        public bool IsUndraftedFreeAgent { get; set; }
        public int HeightFeet { get; set; }
        public int HeightInches { get; set; }
        public int? UpcomingOpponentRank { get; set; }
        public int? UpcomingOpponentPositionRank { get; set; }
        public string CurrentStatus { get; set; }
        public int? UpcomingSalary { get; set; }
        public int FantasyAlarmPlayerID { get; set; }
        public string SportRadarPlayerID { get; set; }
        public int? RotoworldPlayerID { get; set; }
        public int? RotoWirePlayerID { get; set; }
        public int? StatsPlayerID { get; set; }
        public int? SportsDirectPlayerID { get; set; }
        public int XmlTeamPlayerID { get; set; }
        public int? FanDuelPlayerID { get; set; }
        public int? DraftKingsPlayerID { get; set; }
        public int? YahooPlayerID { get; set; }
        public string InjuryStatus { get; set; }
        public string InjuryBodyPart { get; set; }
        public string InjuryStartDate { get; set; }
        public string InjuryNotes { get; set; }
        public string FanDuelName { get; set; }
        public string DraftKingsName { get; set; }
        public string YahooName { get; set; }
        public int? FantasyPositionDepthOrder { get; set; }
        public object InjuryPractice { get; set; }
        public object InjuryPracticeDescription { get; set; }
        public bool DeclaredInactive { get; set; }

       // public News LatestNews { get; set; }
    //public Injury InjuryStatus { get; set; }
   // public PlayerSeason PlayerSeason { get; set; }
  }


    public class RootObject
    {
        public int PlayerID { get; set; }
        public string Team { get; set; }
        public int Number { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Status { get; set; }
        public string Height { get; set; }
        public int Weight { get; set; }
        public string BirthDate { get; set; }
        public string College { get; set; }
        public int Experience { get; set; }
        public string FantasyPosition { get; set; }
        public bool Active { get; set; }
        public string PositionCategory { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string ExperienceString { get; set; }
        public string BirthDateString { get; set; }
        public string PhotoUrl { get; set; }
        public int? ByeWeek { get; set; }
        public string UpcomingGameOpponent { get; set; }
        public int UpcomingGameWeek { get; set; }
        public string ShortName { get; set; }
        public double? AverageDraftPosition { get; set; }
        public string DepthPositionCategory { get; set; }
        public string DepthPosition { get; set; }
        public int? DepthOrder { get; set; }
        public int? DepthDisplayOrder { get; set; }
        public string CurrentTeam { get; set; }
        public string CollegeDraftTeam { get; set; }
        public int CollegeDraftYear { get; set; }
        public int? CollegeDraftRound { get; set; }
        public int? CollegeDraftPick { get; set; }
        public bool IsUndraftedFreeAgent { get; set; }
        public int HeightFeet { get; set; }
        public int HeightInches { get; set; }
        public int? UpcomingOpponentRank { get; set; }
        public int? UpcomingOpponentPositionRank { get; set; }
        public string CurrentStatus { get; set; }
        public int? UpcomingSalary { get; set; }
        public int FantasyAlarmPlayerID { get; set; }
        public string SportRadarPlayerID { get; set; }
        public int? RotoworldPlayerID { get; set; }
        public int? RotoWirePlayerID { get; set; }
        public int? StatsPlayerID { get; set; }
        public int? SportsDirectPlayerID { get; set; }
        public int XmlTeamPlayerID { get; set; }
        public int? FanDuelPlayerID { get; set; }
        public int? DraftKingsPlayerID { get; set; }
        public int? YahooPlayerID { get; set; }
        public string InjuryStatus { get; set; }
        public string InjuryBodyPart { get; set; }
        public string InjuryStartDate { get; set; }
        public string InjuryNotes { get; set; }
        public string FanDuelName { get; set; }
        public string DraftKingsName { get; set; }
        public string YahooName { get; set; }
        public int? FantasyPositionDepthOrder { get; set; }
        public object InjuryPractice { get; set; }
        public object InjuryPracticeDescription { get; set; }
        public bool DeclaredInactive { get; set; }
    }
}
