using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructionsAPI.Models
{
    public class Type_object
    {
        [Key]
        public int ID_Type_object { get; set; }
        public string Name { get; set; }
        public bool Deleted { get; set; }
    }
}
