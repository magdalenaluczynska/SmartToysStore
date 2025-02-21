using SmartToysStore.Models;

namespace SmartToysStore.DataAccess.Repository.IRepository
{
    public interface ICompanyRepository : IRepository<Company>
    {
        void Update(Company obj);
    }
};