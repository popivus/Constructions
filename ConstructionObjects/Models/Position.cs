namespace ConstructionsObjects.Models
{
    public class Position
    {
        public Position(string name, double salary)
        {
            Name = name;
            Salary = salary;
            Deleted = false;
        }

        public int ID_Position { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public bool Deleted { get; set; }
    }
}
