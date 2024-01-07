using AutoMapper;
using TutoApp.DBAccess.IRepository;
using TutoApp.Dto;
using TutoApp.Entity;
using TutoApp.Metier.Interface;

namespace TutoApp.Metier.Implementation
{
    public class ClientService<TentityDto, TEntity> : GenericService<TentityDto, TEntity>, IClientService<TentityDto, TEntity>
         where TentityDto : ClientDTO
        where TEntity : Client, new()
    {
        public ClientService(IGenericRepository<TEntity> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }
    }
}
