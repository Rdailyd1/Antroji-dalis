using System;

namespace InvoiceItemOutsideCS
{
    public class InvoiceItemOutsideCS
    {
        public InvoiceItemOutsideCS()
        {
                
        }
        public InvoiceItemOutsideCS(int number, string servicename, decimal cost, int providercompanyid, int recipientcompanyid, int taxrate, DateTime bilingdate)
        {
            Number = number;
            ServiceName = servicename;
            Cost = cost;
            ProviderCompanyId = providercompanyid;
            RecipientCompanyId = recipientcompanyid;
            TaxRate = taxrate;
            BilingDate = bilingdate;
        }
        public int Number { get; set; }
        public string ServiceName { get; set; }
        public decimal Cost { get; set; }
        public int ProviderCompanyId { get; set; }
        public int RecipientCompanyId { get; set; }
        public int TaxRate { get; set; }
        public DateTime BilingDate { get; set; }
    }
}
