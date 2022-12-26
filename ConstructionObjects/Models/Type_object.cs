namespace ConstructionsObjects.Models
{
    public class Type_object
    {
        public Type_object(string name)
        {
            Name = name;
            Deleted = false;
        }
        public int ID_Type_object { get; set; }
        public string Name { get; set; }
        public bool Deleted { get; set; }
    }
}
