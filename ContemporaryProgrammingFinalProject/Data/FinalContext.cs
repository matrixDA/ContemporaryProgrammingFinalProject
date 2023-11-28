using Microsoft.EntityFrameworkCore;

namespace ContemporaryProgrammingFinalProject.Data
{
    public class FinalContext : DbContext
    {
        public FinalContext(DbContextOptions<FinalContext> options)
            : base(options) { }


    }
}
