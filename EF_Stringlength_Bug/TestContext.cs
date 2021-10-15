using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EF_Stringlength_Bug
{
    public class TestContext : DbContext
    {
        public virtual DbSet<CustomerRecord> CustomerRecords => Set<CustomerRecord>();
        public virtual DbSet<CustomerClass> CustomerClasses => Set<CustomerClass>();

        public TestContext(DbContextOptions<TestContext> dbContextOptions)
            : base(dbContextOptions)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
