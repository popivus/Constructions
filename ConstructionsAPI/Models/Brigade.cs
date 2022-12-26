using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructionsAPI.Models
{
    public class Brigade
    {
        [Key]
        public int ID_Brigade { get; set; }
        public string Name { get; set; }
        public int ID_Object { get; set; }
        public bool Deleted { get; set; }
    }
}
