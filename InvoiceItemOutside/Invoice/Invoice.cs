using System;

namespace Invoice
{
    public class InvoiceCS
    {
        public InvoiceCS()
        {

        }
        public InvoiceCS()
        {

        }
        public int Number { get; set; }
        public string ProviderCompanyName { get; set; }
        public string ProviderCompanyAddress { get; set; }
        public string RecipientCompanyName { get; set; }
        public string RecipientCompanyAddress { get; set; }
        public decimal Total{ get; set; }
        public int ProviderCompanyId { get; set; }
        public int RecipientCompanyId { get; set; }
        public int TaxRate { get; set; }
        public DateTime BilingDate { get; set; }
    }
}
