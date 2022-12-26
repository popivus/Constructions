using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructionsAPI.Models
{
    public class Materials_Objects
    {
        [Key]
        public int ID_Materials_Objects { get; set; }
        public int Amount { get; set; }
        public int ID_Object { get; set; }
        public int ID_Materials { get; set; }
    }
}
