using System;
using Deneme1234.Models;
using Deneme1234.ViewComponents.Carousel;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Deneme1234.Concrete
{
    public class Context: IdentityDbContext<Kullanici>
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server = DESKTOP-TQ8FN5C\\SQLDERS; Database=Projee123;User Id=sa;Password=1;TrustServerCertificate=True;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
        }


        public DbSet<Models.Carousel> Carousels { get; set; }
    }
}
