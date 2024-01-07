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
        public ProductController(IGenericService<ProductDTO, Product> genericService) : base(genericService)
        {
        }
    }
}
