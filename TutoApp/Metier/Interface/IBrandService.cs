using TutoApp.Dto;
using TutoApp.Entity;

namespace TutoApp.Metier.Interface
{
    public interface IBrandServicee<TentityDto, TEntity> : IGenericService<TentityDto, TEntity>
        where TentityDto : BrandDTO
        where TEntity : Brand, new()
    {
    }
}
