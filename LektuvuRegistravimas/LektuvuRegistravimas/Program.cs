using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IAC;
using LektuvuRegistravimasBL;

namespace LektuvuRegistravimas
{
    class Program
    {
        static void Main(string[] args)
        {

            var ataskaitosGeneravimas = new ReportGenerator(new AircraftRepository(), new CompanyRepository(), new CountryRepository(), new AircraftModelRepository());
            var report = ataskaitosGeneravimas.GenerateReportAircraftInEurope();
            Console.WriteLine("Bendras sąrašas");
          
            foreach (var item in report)
            {

                Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}",
                item.AircraftTailNumber, item.BelongsToEU, item.BelongsToEurope, item.CompanyCountryCode, item.CompanyCountryName, item.ModelDescription, item.ModelNumber, item.OwnerCompanyName);
            }
            Console.WriteLine();
            Console.WriteLine("Viso irasu: {0}", report.Count());

            HTMLGenerator htmlGen = new HTMLGenerator();
            htmlGen.GenerateHTMLWithColor(report);
            Console.ReadLine();
        }
    }
}
