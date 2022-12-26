using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructionsAPI.Models
{
    public class Equipment_order_agreement
    {
        [Key]
        public int ID_Equipment_order_agreement { get; set; }
        public double Sum { get; set; }
        public int ID_Counterparty { get; set; }
        public int ID_Technics { get; set; }
        public bool Deleted { get; set; }
    }
}
