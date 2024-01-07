using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using TutoApp.DBAccess.IRepository;
using TutoApp.Entity;

namespace TutoApp.DBAccess.Repository
{
    public class CategoryRepository<TEntity> : GenericRepository<TEntity>, ICategoryRepository<TEntity> where TEntity : Category
    {
        public CategoryRepository(TutoContext dbContext) : base(dbContext)
        {
        }
    }
}
