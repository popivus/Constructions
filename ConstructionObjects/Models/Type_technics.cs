namespace ConstructionsObjects.Models
{
    public class Type_technics
    {
        public int ID_Type_technics { get; set; }
        public string Name { get; set; }
        public bool Deleted { get; set; }

        public Type_technics(string name)
        {
            Name = name;
            Deleted = false;
        }
    }
}
