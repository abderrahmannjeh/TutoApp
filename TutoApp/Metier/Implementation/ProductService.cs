using AutoMapper;
using TutoApp.DBAccess.IRepository;
using TutoApp.Dto;
using TutoApp.Entity;
using TutoApp.Metier.Interface;

namespace TutoApp.Metier.Implementation
{
    public class ProductService<TentityDto, TEntity> : GenericService<TentityDto, TEntity>, IProductService<TentityDto, TEntity>
         where TentityDto : ProductDTO
        where TEntity : Product, new()
    {
        public ProductService(IGenericRepository<TEntity> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }
    }
}
