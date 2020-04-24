using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rankipedia.CodeTest.Models
{
    public interface IEntity
    {
        int ID { get; set; }
        string Name { get; set; }
    }
}
