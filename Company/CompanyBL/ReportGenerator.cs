using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyBL
{
    public class ReportGenerator
    {
        private CompanyRepository _companyRepository;
        public ReportGenerator(CompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }
        public string GenerateCompanyReport()
        {
            List<Company> kompanijos = _companyRepository.Retrieve();
            string companyTemp = "";
            foreach (var vienaKompanija in kompanijos)
            {
                companyTemp += "ID: " + vienaKompanija.ID + " Vardas: " + vienaKompanija.Name + Environment.NewLine;
            }
            return companyTemp;
        }
    }
}
