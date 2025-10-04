using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id =1, Name = "Action", DisplayOrder=1},
                new Category { Id = 2, Name = "Action", DisplayOrder = 9 },
                new Category { Id = 3, Name = "Action", DisplayOrder =2 },
                new Category { Id = 4, Name = "Action", DisplayOrder = 3 },
                new Category { Id = 5, Name = "Action", DisplayOrder = 4 },
                new Category { Id = 6, Name = "Action", DisplayOrder = 5 },
                new Category { Id = 7, Name = "Action", DisplayOrder = 6 },
                new Category { Id = 8, Name = "Action", DisplayOrder = 7 },
                new Category { Id = 9, Name = "Action", DisplayOrder = 8 },
                new Category { Id = 10, Name = "Action", DisplayOrder = 10 }

             );
        }
    }
}
