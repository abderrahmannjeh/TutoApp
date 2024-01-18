using TutoApp.Dto;
using TutoApp.Entity;

namespace TutoApp.Metier.Interface
{
    public interface ITagServicecse<TentityDto, TEntity> : IGenericService<TentityDto, TEntity>
        where TentityDto : TagDTO
        where TEntity : Tag, new()
    {
    }
}
