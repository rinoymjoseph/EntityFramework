using Codify.Entity.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codify.DataAccess.Admin.Configuration
{
    public class ApplicationRoleConfiguration<TEntity> : BasicEntityConfiguration<ApplicationRole>
    {
        public ApplicationRoleConfiguration()
        {
            ToTable("APPLICATION_ROLES", "COD");

            Property(p => p.ApplicationRoleId).HasColumnName("APPLICATION_ROLE_ID");
            Property(p => p.ApplicationId).HasColumnName("APPLICATION_ID").IsRequired();
            Property(p => p.RoleId).HasColumnName("ROLE_ID").IsRequired();
        }
    }
}
