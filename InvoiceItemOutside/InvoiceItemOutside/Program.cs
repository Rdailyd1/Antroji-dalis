using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceBL;

namespace InvoiceUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var kompanijos = new CompanyRepository();
            Console.WriteLine("Kompanijos:");
            foreach (var item in kompanijos.Retrieve())
            {
                Console.WriteLine("{0} {1} {2}", item.ID, item.Name, item.Address);
            }

            var saskaitos = new InvoiceItemOutsideRepository();
            Console.WriteLine("Saskaitos:");
            foreach (var item in saskaitos.Retrieve())
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", item.Number, item.ProviderCompanyId, item.RecipientCompanyId, item.ServiceName, item.Cost);
            }

            var ataskaitosGeneravimas = new InvoiceGenerator(new InvoiceItemOutsideRepository(), new CompanyRepository());
            var report = ataskaitosGeneravimas.GenerateReportInvoice();
            Console.WriteLine("Ataskaita:");
            foreach (var ataskaita in report)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", ataskaita.Number,
                    ataskaita.ProviderCompanyAdress, 
                    ataskaita.ProviderCompanyName,
                    ataskaita.RecipientCompanyAdress,
                    ataskaita.RecipientCompanyName,
                    ataskaita.Total);
            }
            Console.ReadLine();
        }
    }
}
 