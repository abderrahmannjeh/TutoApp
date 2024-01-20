using TutoApp.Dto;
using TutoApp.Entity;

namespace TutoApp.Metier.Interface
{
    public interface IProductService<TentityDto, TEntity> : IGenericService<TentityDto, TEntity>
        where TentityDto : ProductDTO
        where TEntity : Product, new()
    {
        Task<ProductDTO> FindProductWithDetailsById(int id);
    }
}
