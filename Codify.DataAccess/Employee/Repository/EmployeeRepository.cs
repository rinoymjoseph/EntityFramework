using Codify.DataAccess.Employee.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Codify.Entity.Employee;

namespace Codify.DataAccess.Employee.Repository
{
    public class EmployeeRepository : BaseRepository, IEmployeeRepository
    {
        private readonly DbContext _dataContext;
        public EmployeeRepository(DbContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public void AddEmployee(EmployeeEntity employeeEntity)
        {
            if (employeeEntity == null)
            {
                throw new ArgumentNullException("employeeEntity");
            }

            var set = _dataContext.Set<EmployeeEntity>();
            set.Add(employeeEntity);
        }

        public List<EmployeeEntity> GetAllEmployees()
        {
            return _dataContext.Set<EmployeeEntity>().Where(x => !x.IsDeleted).ToList();
        }

        public EmployeeEntity GetEmployeeById(int employeeId)
        {
            return _dataContext.Set<EmployeeEntity>().FirstOrDefault(x => x.Id.Equals(employeeId));
        }
    }
}
