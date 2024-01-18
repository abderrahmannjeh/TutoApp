using TutoApp.Entity;

namespace TutoApp.DBAccess.IRepository
{
    public interface IBrandRepository<TEntity> : IGenericRepository<TEntity> where TEntity : Brand
    {
    }
}
