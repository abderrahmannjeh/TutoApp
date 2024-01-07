namespace TutoApp.DBAccess.IRepository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        public Task<TEntity> Add(TEntity entity);
        public Task<TEntity> Update(TEntity entity,int id);
        public Task<bool> Delete(int id);
        public Task<List<TEntity>> GetAll();

        public Task<TEntity> GetById(int id);

    }
}
