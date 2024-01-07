using AutoMapper;
using TutoApp.DBAccess.IRepository;
using TutoApp.Dto;
using TutoApp.Entity;
using TutoApp.Metier.Interface;

namespace TutoApp.Metier.Implementation
{
    public class CommandeService<TentityDto, TEntity> : GenericService<TentityDto, TEntity>, ICommandeService<TentityDto, TEntity>
         where TentityDto : CommandeDTO
        where TEntity : Commande, new()
    {
        public CommandeService(IGenericRepository<TEntity> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }
    }
}
