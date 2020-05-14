using System;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.DataContext
{
    public class EmployeeDBContext : DbContext
    {
        public class OptionsBuild {
            public OptionsBuild() {
                settings = new AppConfiguration();
                opsBuilder = new DbContextOptionsBuilder<EmployeeDBContext>();
                opsBuilder.UseMySQL(settings.ConnectionString);
                dbOption = opsBuilder.Options;
            }

            public DbContextOptionsBuilder<EmployeeDBContext> opsBuilder { get; set; }

            public DbContextOptions<EmployeeDBContext> dbOption { get; set; }

            private AppConfiguration settings { get; set; }
        }

        public static OptionsBuild ops = new OptionsBuild();

        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options) : base(options) { }

        

        //DBSETS

        public DbSet<User> Users { get; set; }
        
    }
}
