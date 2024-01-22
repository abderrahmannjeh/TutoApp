using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TutoApp.DBAccess.IRepository;
using TutoApp.Entity;

namespace TutoApp.DBAccess.Repository
{
    public class ProductRepository<TEntity> : GenericRepository<TEntity>,IProductRepository<TEntity> where TEntity : Product
    {
        public ProductRepository(TutoContext dbContext) : base(dbContext)
        {
        }

        public async Task<Product> FindProductWithDetailsById(int id)
        {
           return await dbContext.Products.Where(p=>p.Id == id)
                                            .AsNoTracking()
                                            .Include(p=>p.Brand)
                                            .Include(p=>p.Tags)
                                            .Include(p=>p.Category)
                                            .FirstOrDefaultAsync();
        }
    }
}
