using System;
using System.Collections.Generic;
using System.Linq;
namespace InvoiceBL
{
    public class InvoiceItemOutsideRepository
    {
        private List<InvoiceItemOutside> invoiceitemoutsiderepositories = new List<InvoiceItemOutside>();
        public InvoiceItemOutsideRepository()
        {
            invoiceitemoutsiderepositories.Add(new InvoiceItemOutside()
            {
                Number = 3,
                ServiceName = "Remontas",
                Cost = 300,
                ProviderCompanyId = 1,
                RecipientCompanyId = 2,
                BilingDate = new DateTime(2019, 05, 10),
                TaxRate = 21
            });
            invoiceitemoutsiderepositories.Add(new InvoiceItemOutside()
            {
                Number = 3,
                ServiceName = "Valymas",
                Cost = 150,
                ProviderCompanyId = 1,
                RecipientCompanyId = 2,
                BilingDate = new DateTime(2019, 05, 10),
                TaxRate = 21
            });
            invoiceitemoutsiderepositories.Add(new InvoiceItemOutside()
            {
                Number = 3,
                ServiceName = "Sumontavimas",
                Cost = 550,
                ProviderCompanyId = 1,
                RecipientCompanyId = 2,
                BilingDate = new DateTime(2019, 05, 10),
                TaxRate = 21
            });
            invoiceitemoutsiderepositories.Add(new InvoiceItemOutside()
            {
                Number = 4,
                ServiceName = "Dazymas",
                Cost = 250,
                ProviderCompanyId = 2,
                RecipientCompanyId = 1,
                BilingDate = new DateTime(2019, 05, 15),
                TaxRate = 21
            });
            invoiceitemoutsiderepositories.Add(new InvoiceItemOutside()
            {
                Number = 4,
                ServiceName = "Tinkavimas",
                Cost = 350,
                ProviderCompanyId = 2,
                RecipientCompanyId = 1,
                BilingDate = new DateTime(2019, 05, 15),
                TaxRate = 21
            });
            invoiceitemoutsiderepositories.Add(new InvoiceItemOutside()
            {
                Number = 5,
                ServiceName = "Auditas",
                Cost = 1250,
                ProviderCompanyId = 1,
                RecipientCompanyId = 3,
                BilingDate = new DateTime(2019, 05, 17),
                TaxRate = 21
            });
        }
        public List<InvoiceItemOutside> Retrieve()
        {
            return invoiceitemoutsiderepositories;
        }
        public List<InvoiceItemOutside> Retrieve(int number)
        {
            return invoiceitemoutsiderepositories.Where(x => x.Number == number).ToList();
        }
    }
}
