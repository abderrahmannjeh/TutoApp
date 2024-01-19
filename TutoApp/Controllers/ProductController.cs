using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TutoApp.Dto;
using TutoApp.Entity;
using TutoApp.Metier.Interface;

namespace TutoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : GenericController<ProductDTO, Product>
    {
        private IProductService<ProductDTO, Product> _productService;
        public ProductController(IGenericService<ProductDTO, Product> genericService) : base(genericService)
        {

        }
        [HttpGet("GetProductWithDetails")]
        public async Task<ProductDTO> GetProductWithAllDEtails(int id)
        {
            try
            {
                return await _productService.FindProductWithDetailsById(id);
            }
            catch (Exception ex)
            {
                return new ProductDTO()
                {
                    Error = ex.Message,
                    hasError = true
                };

            }
        }
    }
}
