using Rankipedia.CodeTest.Utilities;
using Rankipedia.CodeTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rankipedia.CodeTest.Data
{
    public class TrimRepository : AbstractEntityRepository<Trim>
    {
        public TrimRepository()
        {
            Entities = StaticEntitiesList.Trims;
        }

        public override List<Trim> GetEntitiesByForeignKey(int foreignKey)
        {
            return Entities.FindAll(trim => trim.ModelID == foreignKey);
        }
    }
}
