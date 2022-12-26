namespace ConstructionsObjects.Models
{
    public class Materials_ordering_agreement
    {
        public Materials_ordering_agreement(double sum, int amount, int iD_Materials, int iD_Counterparty)
        {
            Sum = sum;
            Amount = amount;
            ID_Materials = iD_Materials;
            ID_Counterparty = iD_Counterparty;
            Deleted = false;
        }

        public int ID_Materials_ordering_agreement { get; set; }
        public double Sum { get; set; }
        public int Amount { get; set; }
        public int ID_Materials { get; set; }
        public int ID_Counterparty { get; set; }
        public bool Deleted { get; set; }
    }
}
