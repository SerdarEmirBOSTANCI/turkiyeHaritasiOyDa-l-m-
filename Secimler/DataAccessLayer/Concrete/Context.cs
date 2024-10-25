using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
   public class Context:DbContext
    {
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-LC55U5G\\SQLEXPRESS;database=DBSecimler;integrated security=true;");
        }

        public DbSet<sehir> sehirs { get; set; }
        public DbSet<ikibinonyedisecim> ikibinonyedisecims { get; set; }
        public DbSet<ikibinyirmiucsecimiki> ikibinyirmiucsecimikis { get; set; }
        public DbSet<ikibinyirmiucsecimbir> ikibinyirmiucsecimbirs { get; set; }
        public DbSet<ikibinondortsecim> İkibinondortsecims { get; set; }
        public DbSet<ikibinonsekizsecim> ikibinonsekizsecims { get; set; }
        public DbSet<ikibinyirmidortsecim> ikibinyirmidortsecims { get; set; }
        public DbSet<denemeicin> denemeicins { get; set; }


    }
}
