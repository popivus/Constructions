namespace ConstructionsObjects.Models
{
    public class Technics_Objects
    {
        public Technics_Objects(int iD_Object, int iD_Technics)
        {
            ID_Object = iD_Object;
            ID_Technics = iD_Technics;
        }

        public int ID_Technics_Objects { get; set; }
        public int ID_Object { get; set; }
        public int ID_Technics { get; set; }
    }
}
