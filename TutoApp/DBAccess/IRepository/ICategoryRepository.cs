using TutoApp.Entity;

namespace TutoApp.DBAccess.IRepository
{
    public interface ICategoryRepository<TEntity>: IGenericRepository<TEntity> where TEntity : Category
    {
    }
}
