using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructionsAPI.Models
{
    public class Object
    {
        [Key]
        public int ID_Object { get; set; }
        public double Area { get; set; }
        public int Flats { get; set; }
        public DateTime Start_date { get; set; }
        public DateTime End_date { get; set; }
        public string Building_permit { get; set; }
        public int Number_building { get; set; }
        public int ID_Sector { get; set; }
        public int ID_Type_object { get; set; }
        public int ID_Employee { get; set; }
        public bool Deleted { get; set; }
    }
}
