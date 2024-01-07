using TutoApp.Dto;
using TutoApp.Entity;

namespace TutoApp.Metier.Interface
{
    public interface ILigneCommandeService<TentityDto, TEntity> : IGenericService<TentityDto, TEntity>
        where TentityDto : LigneCommandeDTO
        where TEntity : LigneCommande, new()
    {
    }
}
