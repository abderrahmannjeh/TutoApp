using TutoApp.Dto;
using TutoApp.Entity;

namespace TutoApp.Metier.Interface
{
    public interface ICommandeService<TentityDto, TEntity> : IGenericService<TentityDto, TEntity>
        where TentityDto : CommandeDTO
        where TEntity : Commande, new()
    {
    }
}
