using SmartToysStore.DataAccess.Data;
using SmartToysStore.DataAccess.Repository.IRepository;
using SmartToysStore.Models;

namespace SmartToysStore.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
};
