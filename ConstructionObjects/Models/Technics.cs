namespace ConstructionsObjects.Models
{
    public class Technics
    {
        public int ID_Technics { get; set; }
        public string Name { get; set; }
        public int ID_Type_technics { get; set; }
        public int ID_Country { get; set; }
        public bool Deleted { get; set; }

        public Technics(string name, int idType, int idCountry)
        {
            Name = name;
            ID_Type_technics = idType;
            ID_Country = idCountry;
            Deleted = false;
        }
    }
}
