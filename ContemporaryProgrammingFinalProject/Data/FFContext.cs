using ContemporaryProgrammingFinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ContemporaryProgrammingFinalProject.Data
{
	public class FFContext : DbContext
	{
		public FFContext(DbContextOptions<FFContext> options) : base(options) { }

		public DbSet<FavoriteFood> FavoriteFood { get; set; }

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
					ID = 3,
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
		}
	}

}