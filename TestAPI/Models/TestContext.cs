using Microsoft.EntityFrameworkCore;

namespace TestAPI.Models
{
    public class TestContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Manager> Managers { get; set; } = null!;
        public string DbPath { get; }

        public TestContext(DbContextOptions<TestContext> options)
            : base(options)
        {
            var path = System.IO.Directory.GetCurrentDirectory();
            DbPath = System.IO.Path.Join(path + "\\TestContext.db");
            Console.WriteLine("DbPath:" + DbPath);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

     }
}
