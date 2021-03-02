using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TjRUsGR6.Models;

namespace TjRUsGR6.Data
{
    public class ClothingContext:DbContext
    {
        public ClothingContext(DbContextOptions<ClothingContext> options) : base(options)
        {
        }

        public DbSet<Clothing> Clothings { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Size> Sizes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clothing>().ToTable("Clothing");
            modelBuilder.Entity<Color>().ToTable("Color");
            modelBuilder.Entity<Image>().ToTable("Image");
            modelBuilder.Entity<Size>().ToTable("Size");
        }
    }
}
