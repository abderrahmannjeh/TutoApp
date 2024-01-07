using TutoApp.Dto;
using TutoApp.Entity;

namespace TutoApp.Metier.Interface
{
    public interface IClientService<TentityDto, TEntity> : IGenericService<TentityDto, TEntity>
        where TentityDto : ClientDTO
        where TEntity : Client, new()
    {
    }
}
