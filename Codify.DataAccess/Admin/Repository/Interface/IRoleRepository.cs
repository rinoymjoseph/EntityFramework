using Codify.Entity.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codify.DataAccess.Admin.Repository.Interface
{
    interface IRoleRepository
    {
        void AddRole(Role role);
        List<Role> GetRoles();
        string SaveChanges();
    }
}
