namespace ConstructionsObjects.Models
{
    public class Materials
    {
        public int ID_Materials { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public bool Deleted { get; set; }

        public Materials(string name, int amount)
        {
            Name = name;
            Amount = amount;
            Deleted = false;
        }

    }
}
