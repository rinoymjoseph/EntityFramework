using Codify.Entity.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codify.DataAccess.Order.Configuration
{
    public class OrderDetailsConfiguration<TEntity> : BasicEntityConfiguration<OrderDetailsEntity>
    {
        public OrderDetailsConfiguration()
        {
            ToTable("OrderDetails", "COD");
            Property(p => p.Id).HasColumnName("ORDER_DETAILS_ID");
            Property(p => p.OrderId).HasColumnName("ORDER_ID");
            Property(p => p.ProductId).HasColumnName("PRODUCT_ID");
            Property(p => p.UnitPrice).HasColumnName("UNIT_PRICE");
            Property(p => p.Quantity).HasColumnName("QUANTITY");
            Property(p => p.Discount).HasColumnName("DISCOUNT");
        }
    }
}
