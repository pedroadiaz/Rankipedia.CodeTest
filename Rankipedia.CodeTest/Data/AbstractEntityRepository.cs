using Rankipedia.CodeTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rankipedia.CodeTest.Data
{
    public abstract class AbstractEntityRepository<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity
    {
        public List<TEntity> Entities { get; set; }

        public List<TEntity> GetEntities()
        {
            return Entities;
        }

        public virtual List<TEntity> GetEntitiesByForeignKey(int foreignKey)
        {
            return Entities;
        }

        public TEntity GetEntity(int id)
        {
            return Entities.Find(e => e.ID == id);
        }
    }
}
