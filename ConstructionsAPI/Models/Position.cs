using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructionsAPI.Models
{
    public class Position
    {
        [Key]
        public int ID_Position { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public bool Deleted { get; set; }
    }
}
