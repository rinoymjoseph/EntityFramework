using Codify.Entity.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codify.DataAccess.Admin.Configuration
{
    public class UserApplicationRoleConfiguration<TEntity> : BasicEntityConfiguration<UserApplicationRole>
    {
        public UserApplicationRoleConfiguration()
        {
            ToTable("USER_APPLICATION_ROLE", "COD");

            Property(p => p.UserApplicationRoleId).HasColumnName("USER_APPLICATION_ROLE_ID");
            Property(p => p.ApplicationRoleId).HasColumnName("APPLICATION_ROLE_ID").IsRequired();
            Property(p => p.UserId).HasColumnName("USER_ID").IsRequired();
        }
    }
}
