
using FılmDukkanı.Entity.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FilmDukkanı.DAL.Context
{
    public class FılmDukkanıContext:IdentityDbContext
    {


        //tablolar
        public DbSet<Category> Categories { get; set; }
        public DbSet<Movie> Movies   { get; set; }
        public DbSet<AppUser> Users { get; set; }





        //connecting string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=DESKTOP-TQ757R7\\hasan;database=FılmDukkanıDB;uid=sa;pwd=123");
            }
        }
    }
}
