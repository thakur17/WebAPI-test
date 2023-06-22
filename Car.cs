using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apitest
{
    public class Car
    {
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
    }
}
