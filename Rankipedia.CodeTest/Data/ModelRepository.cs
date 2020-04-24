using Rankipedia.CodeTest.Models;
using Rankipedia.CodeTest.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rankipedia.CodeTest.Data
{
    public class ModelRepository : AbstractEntityRepository<Model>
    {
        public ModelRepository()
        {
            Entities = StaticEntitiesList.Models;
        }

        public override List<Model> GetEntitiesByForeignKey(int foreignKey)
        {
            return Entities.FindAll(model => model.MakeID == foreignKey);
        }
    }
}
