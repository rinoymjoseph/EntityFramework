using Codify.DataAccess.Employee.Configuration;
using Codify.DataAccess.Order.Configuration;
using Codify.DataAccess.Product.Configuration;
using Codify.Entity.Employee;
using Codify.Entity.Order;
using Codify.Entity.Product;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Codify.DataAccess
{
    public class CodifyDataContext : DbContext
    {
        public CodifyDataContext() : base("name = CodifyDataContext") { }
        public DbSet<EmployeeEntity> employees { get; set; }
        public DbSet<ProductEntity> products { get; set; }
        public DbSet<OrderEntity> orders { get; set; }
        public DbSet<OrderDetailsEntity> orderDetails { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new EmployeeConfiguration<EmployeeEntity>());
            modelBuilder.Configurations.Add(new ProductConfiguration<ProductEntity>());
            modelBuilder.Configurations.Add(new OrderConfiguration<OrderEntity>());
            modelBuilder.Configurations.Add(new OrderDetailsConfiguration<OrderDetailsEntity>());
            base.OnModelCreating(modelBuilder);
        }

    }
}
