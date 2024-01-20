using TutoApp.Entity;

namespace TutoApp.DBAccess.IRepository
{
    public interface ITagRepository<TEntity> : IGenericRepository<TEntity> where TEntity : Tag
    {
    }
}
