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
            InsertEmployees();
            Console.ReadKey();
        }

        private static void InsertEmployees()
        {
            CreateEmployee("Joy", "Smith", "Los Angeles", "USA");
            CreateEmployee("Abram", "Ivanov", "Moscow", "Russia");
            CreateEmployee("Aryan", "Sodhi", "Delhi", "India");
            CreateEmployee("James", "Williams", "Sidney", "Australia");
            CreateEmployee("Muhammed", "Emir", "Istanbul", "Turkey");
        }

        private static void CreateEmployee(string firstName, string lastName, string city, string country)
        {
            EmployeeEntity employee = new EmployeeEntity();
            employee.City = city;
            employee.Country = country;
            employee.FirstName = firstName;
            employee.LastName = lastName;
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
