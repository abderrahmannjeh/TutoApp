namespace TutoApp.Metier.Interface
{
    public interface IGenericService<TEntityDTO,TEntity> where TEntityDTO : class where TEntity: class
    {
        public Task<TEntityDTO> Add(TEntityDTO entity);
        public Task<TEntityDTO> Update(TEntityDTO entity, int id);
        public Task<bool> Delete(int id);
        public Task<List<TEntityDTO>> GetAll();
        public Task<TEntityDTO> GetById(int id);
    }
}
