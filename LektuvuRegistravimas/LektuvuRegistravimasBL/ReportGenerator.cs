using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using IAC;
namespace LektuvuRegistravimasBL
{
    public class ReportGenerator
    {
        private AircraftRepository _aircraftRepository;
        private CompanyRepository _companyRepository;
        private CountryRepository _countryRepository;
        private AircraftModelRepository _aircraftModelRepository;
        public ReportGenerator(AircraftRepository aircraftRepository,
            CompanyRepository companyRepository,
            CountryRepository countryRepository,
            AircraftModelRepository aircraftModelRepository)
        {
            _aircraftRepository = aircraftRepository;
            _companyRepository = companyRepository;
            _countryRepository = countryRepository;
            _aircraftModelRepository = aircraftModelRepository;

        }
        public List<ReportItem> GenerateReportAircraftInEurope()
        {
            List<ReportItem> ataskaita = new List<ReportItem>();
            var lektuvuSarasas = _aircraftRepository.Retrieve();
            if (lektuvuSarasas.Count() > 0)
            {
                foreach (var lektuvas in lektuvuSarasas)
                {
                    Company lektuvuKompanija = _companyRepository.Retrieve(lektuvas.CompanyId);
                    Country lektuvoSalis = _countryRepository.Retrieve(lektuvuKompanija.CountryId);
                    AircraftModel modelis = _aircraftModelRepository.Retrieve(lektuvas.ModelId);
                    if (lektuvoSalis.Continent == "Europe")
                    {
                        ReportItem reportItem = new ReportItem();
                        reportItem.AircraftTailNumber = lektuvas.TailNumber;
                        reportItem.ModelNumber = modelis.Number;
                        reportItem.ModelDescription = modelis.Description;
                        reportItem.OwnerCompanyName = lektuvuKompanija.Name;
                        reportItem.CompanyCountryCode = lektuvoSalis.Code;
                        reportItem.CompanyCountryName = lektuvoSalis.Name;
                        reportItem.BelongsToEU = lektuvoSalis.BelongsToEU;
                        ataskaita.Add(reportItem);
                    }
                }
                return ataskaita; 
            }
            else
            {
                return null;
            }
        }
    }
   
}
