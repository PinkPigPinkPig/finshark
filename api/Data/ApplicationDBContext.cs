using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }

        public DbSet<Models.Stock> Stock { get; set; }
        public DbSet<Models.Comment> Comment { get; set; }
    }
}