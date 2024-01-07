using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using TutoApp.DBAccess.IRepository;
using TutoApp.Entity;

namespace TutoApp.DBAccess.Repository
{
    public class ProductRepository<TEntity> : GenericRepository<TEntity>,IProductRepository<TEntity> where TEntity : Product
    {
        public ProductRepository(TutoContext dbContext) : base(dbContext)
        {
        }
    }
}
