using Codify.Entity.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codify.DataAccess.Admin.Configuration
{
    public class UserConfiguration<TEntity> : BasicEntityConfiguration<User>
    {
        public UserConfiguration()
        {
            ToTable("USERS", "COD");

            Property(p => p.UserID).HasColumnName("USER_ID");
            Property(p => p.Email).HasColumnName("EMAIL").IsRequired();
            Property(p => p.UserName).HasColumnName("USER_NAME").HasMaxLength(200).IsRequired();
            Property(p => p.FullName).HasColumnName("FULL_NAME").HasMaxLength(200).IsRequired();
            Property(p => p.EmployeeNumber).HasColumnName("EMPLOYEE_NUMBER").HasMaxLength(200);
            Property(p => p.Phone).HasColumnName("PHONE").HasMaxLength(200);
        }

    }
}
