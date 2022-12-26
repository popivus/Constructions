
namespace ConstructionsObjects.Models
{
    public class Brigade
    {
        public Brigade(string name, int iD_Object)
        {
            Name = name;
            ID_Object = iD_Object;
            Deleted = false;
        }

        public int ID_Brigade { get; set; }
        public string Name { get; set; }
        public int ID_Object { get; set; }
        public bool Deleted { get; set; }
    }
}
