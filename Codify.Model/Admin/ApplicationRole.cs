using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codify.Entity.Admin
{
    public class ApplicationRole : BaseEntity
    {
        public int ApplicationRoleId { get; set; }
        public int ApplicationId { get; set; }
        public int RoleId { get; set; }
        public virtual Application Application { get; set; }
        public virtual Role Role { get; set; }

    }
}
