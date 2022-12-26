namespace ConstructionsObjects.Models
{
    public class Composition_brigade
    {
        public Composition_brigade(int iD_Employee, int iD_Brigade)
        {
            ID_Employee = iD_Employee;
            ID_Brigade = iD_Brigade;
        }

        public int ID_Composition_brigade { get; set; }
        public int ID_Employee { get; set; }
        public int ID_Brigade { get; set; }
    }
}
