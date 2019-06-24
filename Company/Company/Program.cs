using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyBL;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            CompanyBL.Company company = new CompanyBL.Company();
            List<string> TelSarasas1 = new List<string>();
            List<string> TelSarasas2 = new List<string>();
            var company1 = new CompanyBL.Company(1, "Ideju sala", TelSarasas1, false);
            var company2 = new CompanyBL.Company(2, "Geras namas", TelSarasas2, false);
            List<CompanyBL.Company> kompanijos = new List<CompanyBL.Company>();
            kompanijos.Add(company1);
            kompanijos.Add(company2);
            TelSarasas1.Add("3706451236");
            TelSarasas1.Add("3706451236");
            TelSarasas2.Add("3706854521");
            TelSarasas2.Add("3706452563");
            TelSarasas2.Add("3706553254");
            Console.WriteLine("Company ID, Neme, Phone Numbers");
            
            Console.WriteLine("{0} {1}", company1.ID, company1.Name);
            Console.WriteLine("Telefonai:");
            foreach (var tel in TelSarasas1)
            {
                Console.WriteLine(tel);
            }
            Console.WriteLine("{0} {1}", company2.ID, company2.Name);
            foreach (var tel in TelSarasas2)
            {
                Console.WriteLine(tel);
            }
            Console.WriteLine("Iveskite imones ID, pagal kurį būtų paskaiciuota telefonu sk.");
            int id = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Telefono Nr. skaičius:");
            Console.WriteLine(company.TelefonoNrSkaicius(kompanijos, id));

            CompanyRepository repo = new CompanyRepository();
            var kompanijuSarasas = repo.Retrieve();
            Console.WriteLine("Kompanijos ID ir vardas:");
            foreach (var elementas in kompanijuSarasas)
            {
                Console.WriteLine($"ID={elementas.ID}, Vardas={elementas.Name} ");
            }
            Console.WriteLine("Iveskite imones ID kuria reikia parodyti:");
            int nr = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"ID={repo.Retrieve(nr).ID}, Vardas={repo.Retrieve(nr).Name}, Nekomercine Organizacija={repo.Retrieve(nr).NekomercineOrganizacija} ");
            var ReportGenerator = new ReportGenerator(repo);
            ReportGenerator.GenerateCompanyReport();
            string kompanijuAtaskaita = ReportGenerator.GenerateCompanyReport();
            Console.WriteLine("Ataskaita:");
            Console.WriteLine(kompanijuAtaskaita);
            Console.ReadLine();
        }
    }
}
