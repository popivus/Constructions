using System;

namespace ConstructionsObjects.Models
{
    public class Counterparty
    {
        public Counterparty(string name, string iNN, string specialization, string personal_account, string checking_account, DateTime registration_date, string address, string phone_number, string fIO_Responsible_person)
        {
            Name = name;
            INN = iNN;
            Specialization = specialization;
            Personal_account = personal_account;
            Checking_account = checking_account;
            Registration_date = registration_date;
            Address = address;
            Phone_number = phone_number;
            FIO_Responsible_person = fIO_Responsible_person;
            Deleted = false;
        }

        public int ID_Counterparty { get; set; }
        public string Name { get; set; }
        public string INN { get; set; }
        public string Specialization { get; set; }
        public string Personal_account { get; set; }
        public string Checking_account { get; set; }
        public DateTime Registration_date { get; set; }
        public string Address { get; set; }
        public string Phone_number { get; set; }
        public string FIO_Responsible_person { get; set; }
        public bool Deleted { get; set; }

        
    }
}
