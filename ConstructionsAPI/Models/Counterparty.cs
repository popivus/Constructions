using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructionsAPI.Models
{
    public class Counterparty
    {
        [Key]
        public int ID_Counterparty { get; set; }
        public string Name { get; set; }
        public string INN { get; set; }
        public string Specialization { get; set; }
        public string Personal_account { get; set; }
        public string Checking_account { get; set; }
        public DateTime Registration_date { get; set; }
        public string Address { get; set; }
        public string Phone_number { get; set; }
        public string FIO_Responsible_person { get; set; }
        public bool Deleted { get; set; }
    }
}
