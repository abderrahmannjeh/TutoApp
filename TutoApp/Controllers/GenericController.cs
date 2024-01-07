using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TutoApp.Dto;
using TutoApp.Metier.Interface;

namespace TutoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<TEntityDTO,TEntity> : ControllerBase where TEntity : class where TEntityDTO: class
    {
        protected readonly IGenericService<TEntityDTO,TEntity> _genericService;

        public GenericController(IGenericService<TEntityDTO, TEntity> genericService)
        {
            _genericService = genericService;
        }

        [HttpGet]
        public async Task<List<TEntityDTO>> GetAll()
        {
            return await _genericService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<TEntityDTO> GetById(int id)
        {
            return await _genericService.GetById(id);
        }

        [HttpPost]
        public async Task<TEntityDTO> Create([FromBody] TEntityDTO entity)
        {
            return await _genericService.Add(entity);
        }

        [HttpPut]
        public async Task<TEntityDTO> Update([FromBody] TEntityDTO entity,int id)
        {
            return await _genericService.Update(entity,id);
        }

        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _genericService.Delete(id);
        }


    }
}
