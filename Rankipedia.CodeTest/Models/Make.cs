using System;
using System.ComponentModel.DataAnnotations;

namespace Rankipedia.CodeTest.Models
{
    public class Make : IEntity
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
