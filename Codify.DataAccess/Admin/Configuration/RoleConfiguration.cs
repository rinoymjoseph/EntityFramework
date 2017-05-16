using Codify.Entity.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codify.DataAccess.Admin.Configuration
{
    public class RoleConfiguration<TEntity> : BasicEntityConfiguration<Role>
    {
        public RoleConfiguration()
        {
            ToTable("ROLES", "COD");

            Property(p => p.RoleId).HasColumnName("ROLE_ID");
            Property(p => p.RoleName).HasColumnName("ROLE_NAME").HasMaxLength(200).IsRequired();
        }

    }
}
