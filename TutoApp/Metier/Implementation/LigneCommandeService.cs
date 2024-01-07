using AutoMapper;
using TutoApp.DBAccess.IRepository;
using TutoApp.Dto;
using TutoApp.Entity;
using TutoApp.Metier.Interface;

namespace TutoApp.Metier.Implementation
{
    public class LigneCommandeService<TentityDto, TEntity> : GenericService<TentityDto, TEntity>, ILigneCommandeService<TentityDto, TEntity>
         where TentityDto : LigneCommandeDTO
        where TEntity : LigneCommande, new()
    {
        public LigneCommandeService(IGenericRepository<TEntity> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }
    }
}
