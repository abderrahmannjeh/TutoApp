using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TutoApp.Dto;
using TutoApp.Entity;
using TutoApp.Metier.Interface;

namespace TutoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : GenericController<TagDTO, Tag>
    {
        public TagController(IGenericService<TagDTO, Tag> genericService) : base(genericService)
        {
        }
    }
}
