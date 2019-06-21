using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CompanyBL
{
    class CompanyRepository
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
            companies.Add(new Company(1, "Ideju sala", null ));
            companies.Add(new Company(1, "Irankiai", null));
            companies.Add(new Company(2, "Geras namas", null));
            companies.Add(new Company(2, "Muras", null));
            companies.Add(new Company(2, "Vijoklis", null));
        }
        
        
    }
}
