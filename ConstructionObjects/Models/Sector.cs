namespace ConstructionsObjects.Models
{
    public class Sector
    {
        public Sector(double area, string address, int iD_Counterparty)
        {
            Area = area;
            Address = address;
            ID_Counterparty = iD_Counterparty;
            Deleted = false;
        }

        public int ID_Sector { get; set; }
        public double Area { get; set; }
        public string Address { get; set; }
        public int ID_Counterparty { get; set; }
        public bool Deleted { get; set; }
    }
}
