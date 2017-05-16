using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codify.Entity.Admin
{
    public class User : BaseEntity
    {
        public int UserID { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string EmployeeNumber { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<UserApplicationRole> UserApplicationRole { get; set; }

    }
}
