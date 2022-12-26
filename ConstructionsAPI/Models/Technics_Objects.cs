using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructionsAPI.Models
{
    public class Technics_Objects
    {
        [Key]
        public int ID_Technics_Objects { get; set; }
        public int ID_Object { get; set; }
        public int ID_Technics { get; set; }
    }
}
