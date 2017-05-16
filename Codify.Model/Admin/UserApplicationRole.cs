using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codify.Entity.Admin
{
    public class UserApplicationRole : BaseEntity
    {
        public int UserApplicationRoleId { get; set; }
        public int ApplicationRoleId { get; set; }
        public int UserId { get; set; }
        public virtual ApplicationRole ApplicationRole { get; set; }
        public virtual User User { get; set; }

    }
}
