using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TutoApp.Dto;
using TutoApp.Entity;
using TutoApp.Metier.Interface;

namespace TutoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandeController : GenericController<CommandeDTO, Commande>
    {
        public CommandeController(IGenericService<CommandeDTO, Commande> genericService) : base(genericService)
        {
        }
    }
}
