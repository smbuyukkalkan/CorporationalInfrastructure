using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    /// <summary> The database context used to manage relations to databases, for Entity Framework Core. </summary>
    public class CorporationalInfrastructureDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // ReSharper disable once StringLiteralTypo
            // optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=CorporationalInfrastructure;Trusted_Connection=true");
            optionsBuilder.UseSqlite(@"Filename=CorporationalInfrastructure.db");
        }
    }
}
