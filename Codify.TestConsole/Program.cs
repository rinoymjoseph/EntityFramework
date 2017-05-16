using Codify.DataAccess.Admin;
using Codify.DataAccess.Admin.Repository;
using Codify.DataAccess.Admin.Repository.Interfaces;
using Codify.Entity.Admin;
using System;

namespace Codify.TestConsole
{
    class Program
    {
        static CodifyDataContext codifyDataContext = new CodifyDataContext();
        static void Main(string[] args)
        {
            CreateRole();
            Console.ReadKey();
        }

        private static void CreateRole()
        {
            Role role = new Role();
            role.RoleName = "Admin";
            role.CreatedBy = System.Environment.UserName;
            role.ModifiedBy = System.Environment.UserName;
            role.CreatedDate = DateTime.Now;
            role.ModifiedDate = DateTime.Now;
            IRoleRepository roleRepository = new RoleRepository(codifyDataContext);
            roleRepository.AddRole(role);
            string message = roleRepository.SaveChanges();
            Console.WriteLine(message);
        }
    }
}
