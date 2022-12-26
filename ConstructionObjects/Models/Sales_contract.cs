using System;

namespace ConstructionsObjects.Models
{
    public class Sales_contract
    {
        public Sales_contract(string number, DateTime contract_date, double sum, int iD_Counterparty)
        {
            Number = number;
            Contract_date = contract_date;
            Sum = sum;
            ID_Counterparty = iD_Counterparty;
            Deleted = false;
        }

        public int ID_Sales_contract { get; set; }
        public string Number { get; set; }
        public DateTime Contract_date { get; set; }
        public double Sum { get; set; }
        public int ID_Counterparty { get; set; }
        public bool Deleted { get; set; }
    }
}
