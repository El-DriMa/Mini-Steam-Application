using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSteam.Data
{
    public class MiniSteamDbContext : DbContext
    {
        private readonly string dbPutanja;
        public MiniSteamDbContext()
        {
            dbPutanja = ConfigurationManager.ConnectionStrings["MiniSteamDbPutanja"].ConnectionString;
        }
        //public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=C:\\Users\\HOME\\Desktop\\SQLiteDBs\\MiniSteamDb.db"
);
            }
        }

    }
}
