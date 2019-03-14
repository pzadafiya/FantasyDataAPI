using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Soccer.Entities
{
    public class BoxScores : List<BoxScore>
    { }

    public class BoxScore
    {
        public Game Game { get; set; }
        //public AwayTeamCoach AwayTeamCoach { get; set; }
        //public HomeTeamCoach HomeTeamCoach { get; set; }
        public TeamCoach AwayTeamCoach { get; set; }
        public TeamCoach HomeTeamCoach { get; set; }
        public Referee MainReferee { get; set; }
        public Referee AssistantReferee1 { get; set; }
        public Referee AssistantReferee2 { get; set; }
        public Referee FourthReferee { get; set; }
        public Referee AdditionalAssistantReferee1 { get; set; }
        public Referee AdditionalAssistantReferee2 { get; set; }
        public List<Lineup> Lineups { get; set; }
        public List<Goal> Goals { get; set; }
        public List<Booking> Bookings { get; set; }
        public List<PenaltyShootout> PenaltyShootouts { get; set; }
        public List<TeamGame> TeamGames { get; set; }
        public List<PlayerGame> PlayerGames { get; set; }
    }

    #region Other Classes
    public class TeamCoach
    {
        public int CoachId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ShortName { get; set; }
        public string Nationality { get; set; }
    }
    //public class AwayTeamCoach
    //{
    //    public int CoachId { get; set; }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public string ShortName { get; set; }
    //    public string Nationality { get; set; }
    //}

    //public class HomeTeamCoach
    //{
    //    public int CoachId { get; set; }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public string ShortName { get; set; }
    //    public string Nationality { get; set; }
    //}

    public class Referee
    {
        public int RefereeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ShortName { get; set; }
        public string Nationality { get; set; }
    }
    //public class MainReferee
    //{
    //    public int RefereeId { get; set; }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public string ShortName { get; set; }
    //    public string Nationality { get; set; }
    //}

    //public class AssistantReferee
    //{
    //    public int RefereeId { get; set; }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public string ShortName { get; set; }
    //    public string Nationality { get; set; }
    //}


    //public class FourthReferee
    //{
    //    public int RefereeId { get; set; }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public string ShortName { get; set; }
    //    public string Nationality { get; set; }
    //}

    public class Lineup
    {
        public int LineupId { get; set; }
        public int GameId { get; set; }
        public string Type { get; set; }
        public int TeamId { get; set; }
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int? ReplacedPlayerId { get; set; }
        public string ReplacedPlayerName { get; set; }
        public int GameMinute { get; set; }
        public int GameMinuteExtra { get; set; }
        public int? PitchPositionHorizontal { get; set; }
        public int? PitchPositionVertical { get; set; }
    }

    public class Goal
    {
        public int GoalId { get; set; }
        public int GameId { get; set; }
        public int TeamId { get; set; }
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public int? AssistedByPlayerId1 { get; set; }
        public string AssistedByPlayerName1 { get; set; }
        public int? AssistedByPlayerId2 { get; set; }
        public string AssistedByPlayerName2 { get; set; }
        public int GameMinute { get; set; }
        public int? GameMinuteExtra { get; set; }
    }

    public class Booking
    {
        public int BookingId { get; set; }
        public int GameId { get; set; }
        public string Type { get; set; }
        public int TeamId { get; set; }
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public int GameMinute { get; set; }
        public int GameMinuteExtra { get; set; }
    }

    #endregion Other Classes
}
