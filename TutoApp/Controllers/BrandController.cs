using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TutoApp.Dto;
using TutoApp.Entity;
using TutoApp.Metier.Interface;

namespace TutoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : GenericController<BrandDTO, Brand>
    {
        public BrandController(IGenericService<BrandDTO, Brand> genericService) : base(genericService)
        {
        }
    }
}
