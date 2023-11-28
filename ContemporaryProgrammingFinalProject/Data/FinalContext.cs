using ContemporaryProgrammingFinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ContemporaryProgrammingFinalProject.Data
{
    public class FinalContext : DbContext
    {
        public FinalContext(DbContextOptions<FinalContext> options) : base(options) { }

		public DbSet<FavoriteFood> FavoriteFood { get; set; }

		public DbSet<Hobbies> Hobbies { get; set; }

		public DbSet<PersonalInfo> PersonalInfo { get; set; }

		public DbSet<VideoGames> VideoGames { get; set; }

	}
}
