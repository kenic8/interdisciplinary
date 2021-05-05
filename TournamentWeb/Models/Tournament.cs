using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace TestforProject.Model
{
    public class Tournament
    {
        public int TournamentId { get; set; }
        public string TournamentName { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime StarTime { get; set; }
        public DateTime TimeFrame { get; set; }
        public User Creator { get; set; }
        public string Category { get; set; }
        // Not sure we need this property because 
        //public int BracketSize { get; set; }
        public List<Brackets> Brackets { get; } = new List<Brackets>();

        //Team is a person of more person joining the game
        public List<Team> TeamList { get; } = new List<Team>();

        public Tournament()
        {

        }

        public Tournament(int tournamentId, string tournamentName, DateTime creationDate, DateTime starTime,
            DateTime timeFrame, User creator, string category, int size, Brackets brackets)
        {
            TournamentId = tournamentId;
            TournamentName = tournamentName;
            CreationDate = creationDate;
            StarTime = starTime;
            TimeFrame = timeFrame;
            Creator = creator;
            Category = category;
            BracketSize = size;

        }

        public void AddBrackets(Brackets brackets)
        {
            Brackets.Add(brackets);
        }

        public void AddTeams(Team team)
        {
            TeamList.Add(team);
        }
    }

    public static class Repository
    {
        public static List<Tournament> Tournaments = new List<Tournament>();

        static Repository()
        {

        }


        public Tournament tournament1 =
            new Tournament(1, "The final countdown", new DateTime(2021, 05, 04), new DateTime(2021, 05, 22),
                new DateTime(2021, 05, 18),
                new User("Dart Vader"), "League of Legends", 8,
                new Brackets("stuff"),
                new List<Team>("The dark side"));

        public Brackets br = new Brackets("whatever");
        public Team DarkTeam = new Team("The dark side");
        Tournaments

        public Tournament tournament2 =
            new Tournament(1, "The final countdown", new DateTime(2021, 05, 04), new DateTime(2021, 05, 22),
                new DateTime(2021, 05, 18),
                new User("Yoda"), "League of Legends", 8,
                new Brackets("stuff"),
                new List<Team>("Jedis"));


    }


}

