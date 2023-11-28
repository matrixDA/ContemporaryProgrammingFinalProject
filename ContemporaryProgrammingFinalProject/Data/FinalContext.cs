using ContemporaryProgrammingFinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ContemporaryProgrammingFinalProject.Data
{
    public class FinalContext : DbContext
    {
        public FinalContext(DbContextOptions<FinalContext> options) : base(options) { }

        public DbSet<FavoriteFood> FavoriteFood { get; set; }
        public DbSet<Hobbies> Hobbies { get; set;}
        public DbSet<PersonalInfo> PersonalInfo { get; set; }
        public DbSet<VideoGames> VideoGames { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FavoriteFood>().HasData(
                new FavoriteFood
                {
                    ID = 1,
                    Member = "Logan",
                    Breakfast = "Yogurt",
                    Lunch = "Sandwich",
                    Dinner = "Chicken Burrito",
                    Snack = "Chips"
                },

                new FavoriteFood
                {
                    ID = 2,
                    Member = "Ian",
                    Breakfast = "Bacon & Eggs",
                    Lunch = "Roast Beef Sandwich",
                    Dinner = "Steak & Potatoes",
                    Snack = "Protein Bar",
                },

                new FavoriteFood
                {
                    ID= 3,
                    Member = "Dinesh",
                    Breakfast = "Cereal",
                    Lunch = "Pizza",
                    Dinner = "Pasta",
                    Snack = "Lay's Lemon Chips",
                },

                new FavoriteFood
                {
                    ID = 4,
                    Member = "Loc",
                    Breakfast = "Toast & Ham",
                    Lunch = "Bun Bo Hue",
                    Dinner = "Fried Rice",
                    Snack = "Chips"
                }

                );

            modelBuilder.Entity<Hobbies>().HasData(
                new Hobbies
                {
                    ID = 1, 
                    Member = "Logan",
                    Hobby = "Photography",
                    InterestLevel = 9,
                    Discovery = "First time using camera"
                },

                new Hobbies
                {
                    ID = 2,
                    Member = "Ian",
                    Hobby = "PC Building",
                    InterestLevel = 8,
                    Discovery = "Built my first PC with friends"
                },

                new Hobbies
                {
                    ID = 3,
                    Member = "Loc",
                    Hobby = "Practicing Guitar",
                    InterestLevel = 9,
                    Discovery = "Got a guitar from my brother"
                },

                new Hobbies
                {
                    ID = 4,
                    Member = "Dinesh",
                    Hobby = "Video Games",
                    InterestLevel = 7,
                    Discovery = "Played WWE game on my friend's PS2"
                }

                );

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

                new VideoGames
                {
                    ID = 4,
                    Member = "Ian",
                    Title = "Roboquest",
                    Developer = "RyseUp",
                    PlayTime = "1 years",
                    Genre = "Roguelite",
                    Rank = "10 out of 10"
                }

                );
        }
	}
}
