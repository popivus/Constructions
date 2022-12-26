using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructionsAPI.Models
{
    public class Composition_brigade
    {
        [Key]
        public int ID_Composition_brigade { get; set; }
        public int ID_Employee { get; set; }
        public int ID_Brigade { get; set; }
    }
}
