namespace ConstructionsObjects.Models
{
    public class Equipment_order_agreement
    {
        public Equipment_order_agreement(double sum, int iD_Counterparty, int iD_Technics)
        {
            Sum = sum;
            ID_Counterparty = iD_Counterparty;
            ID_Technics = iD_Technics;
            Deleted = false;
        }

        public int ID_Equipment_order_agreement { get; set; }
        public double Sum { get; set; }
        public int ID_Counterparty { get; set; }
        public int ID_Technics { get; set; }
        public bool Deleted { get; set; }
    }
}
