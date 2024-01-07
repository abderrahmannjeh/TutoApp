using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TutoApp.Dto;
using TutoApp.Entity;
using TutoApp.Metier.Interface;

namespace TutoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : GenericController<CategoryDTO, Category>
    {
        public CategoryController(IGenericService<CategoryDTO, Category> genericService) : base(genericService)
        {
        }
    }
}
