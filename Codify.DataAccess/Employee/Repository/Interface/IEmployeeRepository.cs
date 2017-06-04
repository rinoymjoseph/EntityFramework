using Codify.Entity.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codify.DataAccess.Employee.Repository.Interface
{
    public interface IEmployeeRepository
    {
        void AddEmployee(EmployeeEntity employeeEntity);
        List<EmployeeEntity> GetAllEmployees();
        EmployeeEntity GetEmployeeById(int employeeId);
        string SaveChanges();
    }
}
