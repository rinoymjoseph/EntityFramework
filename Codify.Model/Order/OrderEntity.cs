using Codify.Entity.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codify.Entity.Order
{
    public class OrderEntity : BaseEntity
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime RequiredDate { get; set; }
        public string ShipAddress { get; set; } 
        public virtual EmployeeEntity Employee { get; set; }
    }
}
