using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureDatabaseProject.Models
{
    public class ShowContext:DbContext
    {
        public ShowContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 100,
                Name = "Toy Story",
                Description = "Animated",
                Duration = 110.20f
            });
        }
    }
}
