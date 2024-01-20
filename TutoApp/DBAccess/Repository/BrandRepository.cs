using TutoApp.DBAccess.IRepository;
using TutoApp.Entity;

namespace TutoApp.DBAccess.Repository
{
    public class BrandRepository<TEntity> : GenericRepository<TEntity>, IBrandRepository<TEntity> where TEntity : Brand
    {
        public BrandRepository(TutoContext dbContext) : base(dbContext)
        {
        }
    }
}
