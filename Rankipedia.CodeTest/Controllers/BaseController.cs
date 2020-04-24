using Microsoft.AspNetCore.Mvc;
using Rankipedia.CodeTest.Models;
using Rankipedia.CodeTest.Dto;
using Rankipedia.CodeTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rankipedia.CodeTest.Controllers
{
    public class BaseController<TEntity, TDto> : Controller where TEntity : class, IEntity where TDto : class, IDto
    {
        protected readonly IEntityService<TDto, TEntity> _entityService;

        public BaseController(IEntityService<TDto, TEntity> entityService)
        {
            _entityService = entityService;
        }

        [HttpGet]
        public virtual List<TDto> GetDtos()
        {
            return _entityService.GetDtos();
        }

        [HttpGet("{id}")]
        public virtual TDto GetDto([FromRoute]int ID)
        {
            return _entityService.GetDto(ID);
        }

        [HttpGet("GetByKey")]
        public virtual List<TDto> GetDtosByKey([FromQuery]int id)
        {
            return _entityService.GetDtosByForeignKey(id);
        }
    }
}
