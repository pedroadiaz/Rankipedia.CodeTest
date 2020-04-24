using Rankipedia.CodeTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rankipedia.CodeTest.Data
{
    public interface IEntityRepository<TEntity> where TEntity : class, IEntity
    {
        List<TEntity> Entities { get; set; }
        List<TEntity> GetEntities();
        TEntity GetEntity(int id);
        List<TEntity> GetEntitiesByForeignKey(int foreignKey);
    }
}
