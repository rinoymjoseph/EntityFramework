using Codify.Entity.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codify.DataAccess.Admin.Configuration
{
    public class ApplicationConfiguration<TEntity> : BasicEntityConfiguration<Application>
    {
        public ApplicationConfiguration()
        {
            ToTable("APPLICATIONS", "COD");

            Property(p => p.ApplicationId).HasColumnName("APPLICATION_ID");
            Property(p => p.ApplicationName).HasColumnName("APPLICATION_NAME").HasMaxLength(200).IsRequired();

        }
    }
}
