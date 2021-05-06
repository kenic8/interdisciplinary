using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TournamentWeb.Data;

namespace TournamentWeb.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TournamentWebContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TournamentWebContext>>()))
            {
                if (context.Tournament.Any())
                {
                    return;   // DB has been seeded
                }


                var Attendent1 = new Attendees(
                    "Teamleader",
                    "Svenn"
                    );

                var Attendent2 = new Attendees(
                    "fag",
                    "Steven"
                    );

                var Attendent3 = new Attendees(
                    "Teamleader",
                    "Kurt"
                    );

                var Attendent4 = new Attendees(
                    "Fag",
                    "Dennis"
                    );


                // team1 Attendent
                var Team1Attendees = new List<Attendees>();
                Team1Attendees.Add(Attendent1);
                Team1Attendees.Add(Attendent2);

                // team2 Attendent
                var Team2Attendees = new List<Attendees>();
                Team2Attendees.Add(Attendent3);
                Team2Attendees.Add(Attendent4);

                var Team1 = new Teams(
                    1,
                    "team1",
                    Team1Attendees,
                    0,
                    false
                    );

                var Team2 = new Teams(
                    2,
                    "team2",
                    Team2Attendees,
                    0,
                    false
                    );

                var Teamssa = new List<Teams>();
                Teamssa.Add(Team1);
                Teamssa.Add(Team2);

                context.Tournament.AddRange(
                    new Tournament
                    {
                        TournamentName = "TestTournament",
                        TournamentImage = "ImageString",
                        TournamentInfo = "InfoString",
                        CreationDate = DateTime.Now,
                        TimeFrame = new DateTime(2024, 12, 31, 16, 45, 0),
                        ParticipantsAmount = 0,
                        UserId = "CreatorUserString",
                        Bracketsize = 4,
                        Teams = Teamssa
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
