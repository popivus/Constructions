using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructionsAPI.Models
{
    public class User
    {
        [Key]
        public int ID_User { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int ID_Employee { get; set; }
        public int ID_Role { get; set; }
        public bool Deleted { get; set; }
    }
}
