using AutoMapper;
using TutoApp.DBAccess.IRepository;
using TutoApp.Dto;
using TutoApp.Entity;
using TutoApp.Metier.Interface;

namespace TutoApp.Metier.Implementation
{
    public class BrandService<TentityDto, TEntity> : GenericService<TentityDto, TEntity>, IBrandServicee<TentityDto, TEntity>
         where TentityDto : BrandDTO
        where TEntity : Brand, new()
    {
        public BrandService(IGenericRepository<TEntity> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }
    }
}
