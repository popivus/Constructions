using System;

namespace ConstructionsObjects.Models
{
    public class Employee
    {
        public Employee(string surname, string name, string middlename, string seria_passport, string number_passport, string sNILS, string iNN, bool fired, byte[] passport_scan, DateTime birthday, int iD_Position)
        {
            Surname = surname;
            Name = name;
            Middlename = middlename;
            Seria_passport = seria_passport;
            Number_passport = number_passport;
            SNILS = sNILS;
            INN = iNN;
            Fired = fired;
            Passport_scan = passport_scan;
            Birthday = birthday;
            ID_Position = iD_Position;
            Deleted = false;
        }

        public int ID_Employee { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Middlename { get; set; }
        public string Seria_passport { get; set; }
        public string Number_passport { get; set; }
        public string SNILS { get; set; }
        public string INN { get; set; }
        public bool Fired { get; set; }
        public byte[] Passport_scan { get; set; }
        public DateTime Birthday { get; set; }
        public int ID_Position { get; set; }
        public bool Deleted { get; set; }
    }
}
