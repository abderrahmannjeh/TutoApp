using TutoApp.Entity;

namespace TutoApp.DBAccess.IRepository
{
    public interface IProductRepository<TEntity> : IGenericRepository<TEntity> where TEntity : Product
    {
        Task<Product> FindProductWithDetailsById(int id);
    }
}
