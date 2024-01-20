using Microsoft.EntityFrameworkCore;
using TutoApp.DBAccess.IRepository;

namespace TutoApp.DBAccess.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly TutoContext dbContext;
        public GenericRepository(TutoContext dbContext) {
        this.dbContext = dbContext;
        }
        public async Task<TEntity> Add(TEntity entity)
        {
            dbContext.Set<TEntity>().Add(entity);
            _ = await dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> Delete(int id)
        {
            var entity = await dbContext.Set<TEntity>().FindAsync(id);
            if(entity != null) { 
            dbContext.Set<TEntity>().Remove(entity);
            var result = await dbContext.SaveChangesAsync();
            }
            return false;
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await dbContext.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            var entity= await dbContext.Set<TEntity>().FindAsync(id);
            if(entity != null)
            {
                dbContext.Entry(entity).State = EntityState.Detached;
            }
            return entity;
        }

        public async Task<TEntity> Update(TEntity entity, int id)
        {
            dbContext.Set<TEntity>().Update(entity);
            _ = await dbContext.SaveChangesAsync();
            return entity;
        }
    }
}
