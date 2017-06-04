using Codify.Entity.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codify.DataAccess.Product.Configuration
{
    public class ProductConfiguration<TEntity> : BasicEntityConfiguration<ProductEntity>
    {
        public ProductConfiguration()
        {
            ToTable("Product", "COD");

            Property(p => p.Id).HasColumnName("PRODUCT_ID");
            Property(p => p.ProductName).HasColumnName("PRODUCT_NAME").HasMaxLength(200).IsRequired();
            Property(p => p.UnitPrice).HasColumnName("UNIT_PRICE");
        }
    }
}
