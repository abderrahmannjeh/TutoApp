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
        private IProductRepository<Product> _productRepository;
        public ProductService(IGenericRepository<TEntity> genericRepository, IMapper mapper) : base(genericRepository, mapper)
        {
        }

        public async Task<ProductDTO> FindProductWithDetailsById(int id)
        {
            Product result = await _productRepository.FindProductWithDetailsById(id);
            if (result != null)
            {
                return _mapper.Map<ProductDTO>(result);

            }
            else
                throw new Exception("Product Not Found");
        }
    }
}
