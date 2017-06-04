using Codify.Entity.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codify.DataAccess.Employee.Configuration
{
    public class EmployeeConfiguration<TEntity> : BasicEntityConfiguration<EmployeeEntity>
    {
        public EmployeeConfiguration()
        {
            ToTable("Employee", "COD");

            Property(p => p.Id).HasColumnName("EMPLOYEE_ID");
            Property(p => p.FirstName).HasColumnName("FIRST_NAME").HasMaxLength(200).IsRequired();
            Property(p => p.LastName).HasColumnName("LAST_NAME").HasMaxLength(200).IsRequired();
            Property(p => p.Address).HasColumnName("ADDRESS").HasMaxLength(200);
            Property(p => p.City).HasColumnName("CITY").HasMaxLength(200);
            Property(p => p.Country).HasColumnName("COUNTRY").HasMaxLength(200);
        }
    }
}
