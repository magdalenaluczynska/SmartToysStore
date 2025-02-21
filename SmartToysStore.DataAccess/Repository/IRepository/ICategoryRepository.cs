using SmartToysStore.Models;

namespace SmartToysStore.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category obj);
    }
};