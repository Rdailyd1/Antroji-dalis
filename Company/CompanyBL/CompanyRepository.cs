using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CompanyBL
{
    public class CompanyRepository
    {
        private List<Company> companies = new List<Company>();

        public List<Company> Retrieve()
        {
            return companies;
        }
        public Company Retrieve(int id)
        {
            return companies.Where(x => x.ID == id).FirstOrDefault();
        }
        public CompanyRepository()
        {
            companies.Add(new Company(1, "Ideju sala", null, false));
            companies.Add(new Company(2, "Irankiai", null, true));
            companies.Add(new Company(3, "Geras namas", null, false));
            companies.Add(new Company(4, "Muras", null, true));
            companies.Add(new Company(5, "Vijoklis", null, false));
        }

    }
}
