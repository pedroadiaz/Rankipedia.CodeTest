using Rankipedia.CodeTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rankipedia.CodeTest.Dto
{
    public class ModelDto : IDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public int makeId { get; set; }
    }
}
