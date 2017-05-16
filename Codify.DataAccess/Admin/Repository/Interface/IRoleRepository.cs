using Codify.Entity.Admin;
using System.Collections.Generic;

namespace Codify.DataAccess.Admin.Repository.Interfaces
{
    public interface IRoleRepository
    {
        void AddRole(Role role);
        List<Role> GetRoles();
        string SaveChanges();
    }
}
