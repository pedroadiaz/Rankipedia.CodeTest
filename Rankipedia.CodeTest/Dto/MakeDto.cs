using Rankipedia.CodeTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rankipedia.CodeTest.Dto
{
    public class MakeDto : IDto
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
