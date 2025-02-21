using SmartToysStore.DataAccess.Data;
using SmartToysStore.DataAccess.Repository.IRepository;
using SmartToysStore.Models;

namespace SmartToysStore.DataAccess.Repository
{
    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
        private ApplicationDbContext _db;
        public OrderDetailRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(OrderDetail obj)
        {
            _db.OrderDetails.Update(obj);
        }
    }
};
