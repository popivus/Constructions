using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructionsAPI.Models
{
    public class Materials_ordering_agreement
    {
        [Key]
        public int ID_Materials_ordering_agreement { get; set; }
        public double Sum { get; set; }
        public int Amount { get; set; }
        public int ID_Materials { get; set; }
        public int ID_Counterparty { get; set; }
        public bool Deleted { get; set; }
    }
}
