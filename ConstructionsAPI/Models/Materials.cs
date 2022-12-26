using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructionsAPI.Models
{
    public class Materials
    {
        [Key]
        public int ID_Materials { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public bool Deleted { get; set; }
    }
}
