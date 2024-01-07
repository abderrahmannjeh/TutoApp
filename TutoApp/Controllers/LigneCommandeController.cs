using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TutoApp.Dto;
using TutoApp.Entity;
using TutoApp.Metier.Interface;

namespace TutoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LigneCommandeController : GenericController<LigneCommandeDTO, LigneCommande>
    {
        public LigneCommandeController(IGenericService<LigneCommandeDTO, LigneCommande> genericService) : base(genericService)
        {
        }
    }
}
