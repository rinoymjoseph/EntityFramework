using Codify.Entity.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codify.DataAccess.Order.Configuration
{
    public class OrderConfiguration<TEntity> : BasicEntityConfiguration<OrderEntity>
    {
        public OrderConfiguration()
        {
            ToTable("Order", "COD");

            Property(p => p.Id).HasColumnName("ORDER_ID");
            Property(p => p.EmployeeId).HasColumnName("EMPLOYEE_ID");
            Property(p => p.RequiredDate).HasColumnName("REQUIRED_DATE");
            Property(p => p.ShipAddress).HasColumnName("SHIP_ADDRESS");
        }
    }
}
