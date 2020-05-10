using System;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.DataContext
{
    public class DatabaseContext :DbContext
    {
        public class OptionsBuild {
            public OptionsBuild() {
                settings = new AppConfiguration();
                opsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
                opsBuilder.UseMySQL(settings.ConnectionString);
                dbOption = opsBuilder.Options;
            }

            public DbContextOptionsBuilder<DatabaseContext> opsBuilder { get; set; }

            public DbContextOptions<DatabaseContext> dbOption { get; set; }

            private AppConfiguration settings { get; set; }
        }

        public static OptionsBuild ops = new OptionsBuild();

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        //DBSETS

        public DbSet<User> Users { get; set; }
        
    }
}
