using Bulkyweb.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulkyweb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { id = 2, Name = "Action", DisplayOrder = 3 },
                new Category { id = 3, Name = "History", DisplayOrder = 3 }
                );
        }
    }
}

