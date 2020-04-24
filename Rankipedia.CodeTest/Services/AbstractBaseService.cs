using AutoMapper;
using Rankipedia.CodeTest.Data;
using Rankipedia.CodeTest.Dto;
using Rankipedia.CodeTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rankipedia.CodeTest.Services
{
    public class AbstractBaseService<TDto, TEntity> : IEntityService<TDto, TEntity> where TDto : class, IDto where TEntity : class, IEntity
    {
        protected readonly IEntityRepository<TEntity> _entityRepository;
        protected readonly IMapper _mapper;

        public AbstractBaseService(IEntityRepository<TEntity> repository, IMapper mapper)
        {
            _entityRepository = repository;
            _mapper = mapper;
        }

        public TDto GetDto(int id)
        {
            TEntity entity = _entityRepository.GetEntity(id);

            return _mapper.Map<TDto>(entity);
        }

        public List<TDto> GetDtos()
        {
            List<TEntity> entities = _entityRepository.GetEntities();

            return _mapper.Map<List<TDto>>(entities);
        }

        public virtual List<TDto> GetDtosByForeignKey(int foreignKey)
        {
            List<TEntity> entities = _entityRepository.GetEntitiesByForeignKey(foreignKey);

            return _mapper.Map<List<TDto>>(entities);
        }
    }
}
