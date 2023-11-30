using ContemporaryProgrammingFinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ContemporaryProgrammingFinalProject.Data
{
	public class HContext : DbContext
	{
		public HContext(DbContextOptions<HContext> options) : base(options) { }

		public DbSet<Hobbies> Hobbies { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
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
		}
	}

}