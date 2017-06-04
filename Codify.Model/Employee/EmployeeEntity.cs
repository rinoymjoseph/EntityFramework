using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Codify.Entity.Order;
using System.Threading.Tasks;

namespace Codify.Entity.Employee
{
    public class EmployeeEntity : BaseEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public virtual ICollection<OrderEntity> OrderEntities { get; set; }

    }
}
