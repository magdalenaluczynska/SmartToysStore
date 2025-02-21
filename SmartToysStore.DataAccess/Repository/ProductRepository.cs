using SmartToysStore.DataAccess.Data;
using SmartToysStore.DataAccess.Repository.IRepository;
using SmartToysStore.Models;

namespace SmartToysStore.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Product obj)
        {
            var objFromDb = _db.Products.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = obj.Name;
                objFromDb.CategoryId = obj.CategoryId;
                objFromDb.Description = obj.Description;
                objFromDb.ModelCode = obj.ModelCode;
                objFromDb.Price = obj.Price;
                objFromDb.Price50 = obj.Price50;
                objFromDb.Price100 = obj.Price100;
                objFromDb.Color = obj.Color;
                objFromDb.Link = obj.Link;
                if (obj.Image != null)
                {
                    objFromDb.Image = obj.Image;
                }
                
            }
        }
    }
};
