using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rankipedia.CodeTest.Models
{
    public class Model : IEntity
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public int MakeID { get; set; }
    }
}
