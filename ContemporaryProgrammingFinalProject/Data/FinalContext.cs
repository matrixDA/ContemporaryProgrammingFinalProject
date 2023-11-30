using ContemporaryProgrammingFinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ContemporaryProgrammingFinalProject.Data
{
    public class FinalContext : DbContext
    {
        public FinalContext(DbContextOptions<FinalContext> options) : base(options) { }


            modelBuilder.Entity<PersonalInfo>().HasData(

                new PersonalInfo
                {
                    ID = 1,
                    Member = "Logan Freeman",
                    BirthDate = new DateTime(2003, 11, 18),
                    CollegeProgram = "Information Technology",
                    YearInProgram = "Junior",
                },

                 new PersonalInfo
                 {
                     ID = 2,
                     Member = "Ian Mendez",
                     BirthDate = new DateTime(2000, 11, 2),
                     CollegeProgram = "Psychology",
                     YearInProgram = "Senior",
                 },

                  new PersonalInfo
                  {
                      ID = 3,
                      Member = "Loc Nguyen",
                      BirthDate = new DateTime(2004, 8, 6),
                      CollegeProgram = "Information Technology",
                      YearInProgram = "Sophomore",
                  },

                   new PersonalInfo
                   {
                       ID = 4,
                       Member = "Dinesh Adhikari",
                       BirthDate = new DateTime(2003, 5, 27),
                       CollegeProgram = "Information Technology",
                       YearInProgram = "Sophomore",
                   }

                );

            modelBuilder.Entity<VideoGames>().HasData(

                new VideoGames
                {
                    ID = 1,
                    Member = "Logan",
                    Title = "Minecraft",
                    Developer = "Mojang",
                    PlayTime = "7 years",
                    Genre = "Sandbox",
                    Rank = "10 out of 10"
                },

                new VideoGames
                {
                    ID = 2,
                    Member = "Loc",
                    Title = "League of Legends",
                    Developer = "Riot Games",
                    PlayTime = "9 years",
                    Genre = "Moba",
                    Rank = "9 out of 10"
                },

                new VideoGames
                {
                    ID = 3,
                    Member = "Dinesh",
                    Title = "Fallout New Vegas",
                    Developer = "Bethesda Softworks",
                    PlayTime = "2 years",
                    Genre = "RPG",
                    Rank = "10 out of 10"
                },


	}
}
