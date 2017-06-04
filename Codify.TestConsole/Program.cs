using Codify.DataAccess;
using Codify.DataAccess.Employee.Repository;
using Codify.DataAccess.Employee.Repository.Interface;
using Codify.Entity.Employee;
using System;

namespace Codify.TestConsole
{
    class Program
    {
        static CodifyDataContext codifyDataContext = new CodifyDataContext();
        static void Main(string[] args)
        {
            CreateEmployee();
            Console.ReadKey();
        }

        private static void CreateEmployee()
        {
            EmployeeEntity employee = new EmployeeEntity();
            employee.City = "Bangalore";
            employee.FirstName = "Luke";
            employee.LastName = "Skywalker";
            employee.CreatedBy = System.Environment.UserName;
            employee.ModifiedBy = System.Environment.UserName;
            employee.CreatedDate = DateTime.Now;
            employee.ModifiedDate = DateTime.Now;
            IEmployeeRepository roleRepository = new EmployeeRepository(codifyDataContext);
            roleRepository.AddEmployee(employee);
            string message = roleRepository.SaveChanges();
            Console.WriteLine(message);
        }
    }
}
