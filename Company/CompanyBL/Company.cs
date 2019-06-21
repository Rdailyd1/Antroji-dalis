using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyBL
{
    public class Company
    {
        public Company()
        {

        }
        public Company(int id, string name, List<string> phonenumbers )
        {
           ID = id;
           Name = name;
           PhoneNumbers = phonenumbers;
        }
       
        public int ID { get; set; }
        public string Name { get; set; }
        public List<string> PhoneNumbers { get; set; }
        public int TelefonoNrSkaicius(List<Company>companies,int id)
        {
            int skaicius = 0;

            foreach (var elementas in companies)
            {
                if (elementas.ID == id)
                {
                    skaicius = elementas.PhoneNumbers.Count();
                }
            }
                      
            return skaicius;
        }
    }
}
