using BulkyWebRazor_Temp.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWebRazor_Temp.Data
{
    public class ApplicationdbContext : DbContext
    {
        public ApplicationdbContext(DbContextOptions<ApplicationdbContext> option) : base(option)
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
