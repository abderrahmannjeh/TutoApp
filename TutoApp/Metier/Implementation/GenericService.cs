using AutoMapper;
using System.Data.Entity.Core;
using TutoApp.DBAccess.IRepository;
using TutoApp.Metier.Interface;

namespace TutoApp.Metier.Implementation
{
    public class GenericService<TEntityDTO, TEntity> : IGenericService<TEntityDTO, TEntity> where TEntityDTO : class where TEntity : class
    {
        protected readonly IGenericRepository<TEntity> _genericRepository;
        protected readonly IMapper _mapper;
        public GenericService(IGenericRepository<TEntity> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }
        public async Task<TEntityDTO> Add(TEntityDTO entityDTO)
        {

            var eneity = _mapper.Map<TEntity>(entityDTO);
            if (eneity != null)
            { TEntity result = await _genericRepository.Add(eneity);
                return _mapper.Map<TEntityDTO>(result);
            }
            return null;
        }

        public async Task<bool> Delete(int id)
        {
            
            bool result = await _genericRepository.Delete(id);
            return result;

        }
        public async Task<List<TEntityDTO>> GetAll()
        {
            var list = await _genericRepository.GetAll();
            return _mapper.Map<List<TEntityDTO>>(list);
        }

        public async Task<TEntityDTO> GetById(int id)
        {
            var entity = await _genericRepository.GetById(id);
            if(entity != null)
            {
                return _mapper.Map<TEntityDTO>(entity);
            }
            return null;
        }

        public async Task<TEntityDTO> Update(TEntityDTO entityDTO, int id)
        {
            var eneity = _mapper.Map<TEntity>(entityDTO);
            if (eneity != null)
            {
                TEntity result = await _genericRepository.Update(eneity,id);
                return _mapper.Map<TEntityDTO>(result);
            }
            throw new ObjectNotFoundException();
        }
    }
}
