using System;
using System.Collections.Generic;

namespace InvoiceBL
{
    public class CompanyRepository
    {
        public List<Company> Retrieve()
        {
            List<Company> companies = new List<Company>();
            companies.Add(new Company() {
                ID = 1,
                Name = "Medis",
                Address = "Kaunas" });
            companies.Add(new Company()
            {
                ID = 2,
                Name = "Zaibas",
                Address = "Vilnius"
            });
            companies.Add(new Company()
            {
                ID = 3,
                Name = "Auditorius",
                Address = "Vilnius"
            });
            return companies;
        }
    }
}
