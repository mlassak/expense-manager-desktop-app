using ExpManagerDAL.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpManagerDAL
{
    public class ExpManagerDbContext : DbContext
    {
        private string connectionStr = @"server=(localdb)\MSSQLLocalDB; " +
                                       "Initial Catalog=ExpenseManagerDB; " +
                                       "Integrated Security=true";

        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public ExpManagerDbContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionStr);
            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
