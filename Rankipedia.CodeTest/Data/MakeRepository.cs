using Rankipedia.CodeTest.Models;
using Rankipedia.CodeTest.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rankipedia.CodeTest.Data
{
    public class MakeRepository : AbstractEntityRepository<Make>
    {
        public MakeRepository() : base()
        {
            Entities = StaticEntitiesList.Makes;
        }
    }
}
