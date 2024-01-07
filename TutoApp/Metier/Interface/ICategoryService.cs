using TutoApp.Dto;
using TutoApp.Entity;

namespace TutoApp.Metier.Interface
{
    public interface ICategoryService<TentityDto, TEntity> : IGenericService<TentityDto, TEntity>
        where TentityDto : CategoryDTO
        where TEntity : Category, new()
    {
    }
}
