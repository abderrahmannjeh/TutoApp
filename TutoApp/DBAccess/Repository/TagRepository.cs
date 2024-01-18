using TutoApp.DBAccess.IRepository;
using TutoApp.Entity;

namespace TutoApp.DBAccess.Repository
{
    public class TagRepository<TEntity> : GenericRepository<TEntity>, ITagRepository<TEntity> where TEntity : Tag
    {
        public TagRepository(TutoContext dbContext) : base(dbContext)
        {
        }
    }
}
