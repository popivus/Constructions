using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructionsAPI.Models
{
    public class Sales_contract
    {
        [Key]
        public int ID_Sales_contract { get; set; }
        public string Number { get; set; }
        public DateTime Contract_date { get; set; }
        public double Sum { get; set; }
        public int ID_Counterparty { get; set; }
        public bool Deleted { get; set; }
    }
}
