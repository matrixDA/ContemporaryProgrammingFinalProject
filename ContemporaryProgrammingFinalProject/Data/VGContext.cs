using ContemporaryProgrammingFinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ContemporaryProgrammingFinalProject.Data
{
	public class VGContext : DbContext
	{
		public VGContext(DbContextOptions<VGContext> options) : base(options) { }

		public DbSet<VideoGames> VideoGames { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
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