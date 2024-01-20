using AutoMapper;
using TutoApp.DBAccess.IRepository;
using TutoApp.Dto;
using TutoApp.Entity;
using TutoApp.Metier.Interface;

namespace TutoApp.Metier.Implementation
{
    public class TagService<TentityDto, TEntity> : GenericService<TentityDto, TEntity>, ITagServicecse<TentityDto, TEntity>
         where TentityDto : TagDTO
        where TEntity : Tag, new()
    {
        public TagService(IGenericRepository<TEntity> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }
    }
}
