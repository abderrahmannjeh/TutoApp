using AutoMapper;
using TutoApp.DBAccess.IRepository;
using TutoApp.Dto;
using TutoApp.Entity;
using TutoApp.Metier.Interface;

namespace TutoApp.Metier.Implementation
{
    public class CategoryService<TentityDto, TEntity> : GenericService<TentityDto, TEntity>, ICategoryService<TentityDto, TEntity>
         where TentityDto : CategoryDTO
        where TEntity : Category, new()
    {
        public CategoryService(IGenericRepository<TEntity> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
           
        }
    }
}
