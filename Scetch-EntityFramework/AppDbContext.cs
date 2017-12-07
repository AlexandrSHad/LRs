using Scetch_EntityFramework.Models;
using System.Data.Entity;

namespace Scetch_EntityFramework
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("AppDbContext")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<SchoolClass> SchoolClasses { get; set; }
    }
}
