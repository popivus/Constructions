using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructionsAPI.Models
{
    public class Technics
    {
        [Key]
        public int ID_Technics { get; set; }
        public string Name { get; set; }
        public int ID_Type_technics { get; set; }
        public int ID_Country { get; set; }
        public bool Deleted { get; set; }
    }
}
