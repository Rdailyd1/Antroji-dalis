using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace InvoiceBL
{
    public class InvoiceGenerator
    {
        private List<Invoice> saskaitos = new List<Invoice>();
        private InvoiceItemOutsideRepository _invoiceItemOutsideRepository;
        private CompanyRepository _companyRepository;
        public InvoiceGenerator(InvoiceItemOutsideRepository invoiceItemOutsideRepository, CompanyRepository companyRepository)
        {
            _invoiceItemOutsideRepository = invoiceItemOutsideRepository;
            _companyRepository = companyRepository;
        }
        public List<Invoice> GenerateReportInvoice()
        {
            List<int> saskaituNumeriai = GetInvoiceItemOutsideRepostory();
            foreach (var saskaitosNumeris in saskaituNumeriai)
            {
                List<InvoiceItemOutside> isorinesEilutes = _invoiceItemOutsideRepository.Retrieve(saskaitosNumeris);
                Company providerCompany = GetProviderCompny(isorinesEilutes);
                Company recipientCompany = GetRecipientCompany(isorinesEilutes);
                Invoice saskaita = MapInvoice(isorinesEilutes, providerCompany, recipientCompany);

                saskaitos.Add(saskaita);

            }
            return saskaitos;
        }

        private List<int> GetInvoiceItemOutsideRepostory()
        {
            return _invoiceItemOutsideRepository.Retrieve().Select(x => x.Number).Distinct().ToList();
        }

        private static Invoice MapInvoice(List<InvoiceItemOutside> isorinesEilutes, Company providerCompany, Company recipientCompany)
        {
            Invoice saskaita = new Invoice();
            saskaita.Number = isorinesEilutes[0].Number;
            saskaita.ProviderCompanyName = providerCompany.Name;
            saskaita.RecipientCompanyName = recipientCompany.Name;
            saskaita.ProviderCompanyAdress = providerCompany.Address;
            saskaita.RecipientCompanyAdress = recipientCompany.Address;
            saskaita.Items = GetInvoiceItems(isorinesEilutes);
            return saskaita;
        }

        private static List<InvoiceItem> GetInvoiceItems(List<InvoiceItemOutside> isorinesEilutes)
        {
            List<InvoiceItem> invoiceItems = new List<InvoiceItem>();
            foreach (var vienaEilute in isorinesEilutes)
            {
                invoiceItems.Add(new InvoiceItem()
                {
                    ServiceName = vienaEilute.ServiceName,
                    Cost = vienaEilute.Cost
                });
            }
            return invoiceItems;
        }

        private Company GetRecipientCompany(List<InvoiceItemOutside> isorinesEilutes)
        {
            return _companyRepository.Retrieve().Where(x => x.ID == isorinesEilutes[0].RecipientCompanyId).FirstOrDefault();
        }

        private Company GetProviderCompny(List<InvoiceItemOutside> isorinesEilutes)
        {
            return _companyRepository.Retrieve()
                .Where(x => x.ID == isorinesEilutes[0].ProviderCompanyId)
                .FirstOrDefault();
        }
    }
}
