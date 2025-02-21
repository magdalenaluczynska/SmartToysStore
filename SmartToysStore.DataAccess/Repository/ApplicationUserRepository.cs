using SmartToysStore.DataAccess.Data;
using SmartToysStore.DataAccess.Repository.IRepository;
using SmartToysStore.Models;

namespace SmartToysStore.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private ApplicationDbContext _db;
        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
};
