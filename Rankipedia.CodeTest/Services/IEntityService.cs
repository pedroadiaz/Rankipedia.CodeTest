using Rankipedia.CodeTest.Dto;
using Rankipedia.CodeTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rankipedia.CodeTest.Services
{
    public interface IEntityService<TDto, TEntity> where TDto : class, IDto where TEntity : class, IEntity
    {
        List<TDto> GetDtos();
        TDto GetDto(int id);
        List<TDto> GetDtosByForeignKey(int foreignKey);
    }
}
