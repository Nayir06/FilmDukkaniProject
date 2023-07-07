
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FilmDukkanı.DAL.Context
{
    internal class FılmDukkanıContext:IdentityDbContext
    {



        public DbSet<Category>



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=DESKTOP-TQ757R7\\hasan;database=FılmDukkanıDB;uid=sa;pwd=123");
            }
        }
    }
}
