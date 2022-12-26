using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructionsAPI.Models
{
    public class Employee
    {
        [Key]
        public int ID_Employee { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Middlename { get; set; }
        public string Seria_passport { get; set; }
        public string Number_passport { get; set; }
        public string SNILS { get; set; }
        public string INN { get; set; }
        public bool Fired { get; set; }
        public byte[] Passport_scan { get; set; }
        public DateTime Birthday { get; set; }
        public int ID_Position { get; set; }
        public bool Deleted { get; set; }
    }
}
