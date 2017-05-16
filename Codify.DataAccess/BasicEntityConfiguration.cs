using Codify.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codify.DataAccess
{
    public abstract class BasicEntityConfiguration<TEntity> : EntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        public BasicEntityConfiguration()
        {
            Property(p => p.CreatedDate).HasColumnName("CREATED_DATE").IsRequired();
            Property(p => p.CreatedBy).HasColumnName("CREATED_BY").HasMaxLength(50).IsRequired();
            Property(p => p.ModifiedDate).HasColumnName("MODIFIED_DATE").IsRequired();
            Property(p => p.ModifiedBy).HasColumnName("MODIFIED_BY").HasMaxLength(50).IsRequired();
            Property(p => p.IsCurrent).HasColumnName("IS_CURRENT").IsRequired();
            Property(p => p.IsDeleted).HasColumnName("IS_DELETED").IsRequired();
            Property(e => e.RecordTimeStamp).HasColumnName("RTS").IsRowVersion().IsRequired();
        }
    }
}
