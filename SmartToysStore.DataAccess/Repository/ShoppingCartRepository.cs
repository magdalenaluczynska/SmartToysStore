using SmartToysStore.DataAccess.Data;
using SmartToysStore.DataAccess.Repository.IRepository;
using SmartToysStore.Models;

namespace SmartToysStore.DataAccess.Repository
{
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        private ApplicationDbContext _db;
        public ShoppingCartRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(ShoppingCart obj)
        {
            _db.ShoppingCarts.Update(obj);
        }
    }
};
