using SmartToysStore.Models;

namespace SmartToysStore.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product obj);
    }
};