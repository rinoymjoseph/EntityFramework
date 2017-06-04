using Codify.Entity.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codify.DataAccess.Order.Repository.Interface
{
    public interface IOrderDetailsRepository
    {
        void AddOrderDetails(OrderDetailsEntity orderDetailsEntity);
        List<OrderDetailsEntity> GetAllOrderDetails();
        OrderDetailsEntity GetOrderDetailsById(int orderDetailsId);
    }
}
