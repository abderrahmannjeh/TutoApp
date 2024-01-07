using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TutoApp.Dto;
using TutoApp.Entity;
using TutoApp.Metier.Interface;

namespace TutoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : GenericController<ClientDTO, Client>
    {
        public ClientController(IGenericService<ClientDTO, Client> genericService) : base(genericService)
        {
        }
    }
}
