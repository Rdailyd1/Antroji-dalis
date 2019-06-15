using System;

namespace InvoiceBL
{
    public class InvoiceItemOutside
    {
      
        public int Number { get; set; }
        public string ServiceName { get; set; }
        public decimal Cost { get; set; }
        public int ProviderCompanyId { get; set; }
        public int RecipientCompanyId { get; set; }
        public int TaxRate { get; set; }
        public DateTime BilingDate { get; set; }
    }
}
