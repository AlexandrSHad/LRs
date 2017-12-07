using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LR31_EF_Cars.Models;

namespace LR31_EF_Cars
{
    public class AppDataContext : DbContext
    {
        public AppDataContext() : base("AppDataContext")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<AppDataContext,LR31_EF_Cars.Migrations.Configuration>("AppDataContext"));
            Database.SetInitializer(new CreateDatabaseIfNotExists<AppDataContext>());
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<CarOwner> CarOwners { get; set; }
    }
}
