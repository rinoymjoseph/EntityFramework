using Codify.DataAccess.Order.Repository.Interface;
using Codify.Entity.Order;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codify.DataAccess.Order.Repository
{
    public class OrderDetailsRepository : BaseRepository, IOrderDetailsRepository
    {
        private readonly DbContext _dataContext;
        public OrderDetailsRepository(DbContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public void AddOrderDetails(OrderDetailsEntity orderDetailsEntity)
        {
            if (orderDetailsEntity == null)
            {
                throw new ArgumentNullException("orderDetailsEntity");
            }

            var set = _dataContext.Set<OrderDetailsEntity>();
            set.Add(orderDetailsEntity);
        }

        public List<OrderDetailsEntity> GetAllOrderDetails()
        {
            return _dataContext.Set<OrderDetailsEntity>().Where(x => !x.IsDeleted).ToList();
        }

        public OrderDetailsEntity GetOrderDetailsById(int orderDetailsId)
        {
            return _dataContext.Set<OrderDetailsEntity>().FirstOrDefault(x => x.Id.Equals(orderDetailsId));
        }
    }
}
