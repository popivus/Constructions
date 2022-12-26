namespace ConstructionsObjects.Models
{
    public class Materials_Objects
    {
        public Materials_Objects(int amount, int iD_Object, int iD_Materials)
        {
            Amount = amount;
            ID_Object = iD_Object;
            ID_Materials = iD_Materials;
        }

        public int ID_Materials_Objects { get; set; }
        public int Amount { get; set; }
        public int ID_Object { get; set; }
        public int ID_Materials { get; set; }
    }
}
