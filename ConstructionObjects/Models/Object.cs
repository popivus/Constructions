using System;

namespace ConstructionObjects.Models
{
    public class Object
    {
        public Object(double area, int flats, DateTime start_date, DateTime end_date, string building_permit, int number_building, int iD_Sector, int iD_Type_object, int iD_Employee)
        {
            Area = area;
            Flats = flats;
            Start_date = start_date;
            End_date = end_date;
            Building_permit = building_permit;
            Number_building = number_building;
            ID_Sector = iD_Sector;
            ID_Type_object = iD_Type_object;
            ID_Employee = iD_Employee;
            Deleted = false;
        }

        public int ID_Object { get; set; }
        public double Area { get; set; }
        public int Flats { get; set; }
        public DateTime Start_date { get; set; }
        public DateTime End_date { get; set; }
        public string Building_permit { get; set; }
        public int Number_building { get; set; }
        public int ID_Sector { get; set; }
        public int ID_Type_object { get; set; }
        public int ID_Employee { get; set; }
        public bool Deleted { get; set; }
    }
}
