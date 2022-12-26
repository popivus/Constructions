using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructionObjects.Models
{
    class User
    {
        public int ID_User { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int ID_Employee { get; set; }
        public int ID_Role { get; set; }
        public bool Deleted { get; set; }


        public User(string name, string password, int id_em, int id_role)
        {
            Name = name;
            Password = password;
            ID_Employee = id_em;
            ID_Role = id_role;
            Deleted = false;
        }
    }
}
