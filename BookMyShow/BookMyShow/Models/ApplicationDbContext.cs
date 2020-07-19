using Microsoft.EntityFrameworkCore;

namespace BookMyShow.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Movies> movies { get; set; }
        public DbSet<Languages> languages { get; set; }
        public DbSet<Review> reviews { get; set; }
    }
}

