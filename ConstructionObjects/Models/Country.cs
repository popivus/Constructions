namespace ConstructionsObjects.Models
{
    public class Country
    {
        public int ID_Country { get; set; }
        public string Name { get; set; }
        public bool Deleted { get; set; }

        public Country(string name)
        {
            Name = name;
        }
    }
}
