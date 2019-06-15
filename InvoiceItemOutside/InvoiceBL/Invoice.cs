using System;
using System.Collections.Generic;
using System.Linq;

namespace InvoiceBL
{
    public class Invoice
    {
       
        public int Number { get; set; }
        public string ProviderCompanyName { get; set; }
        public string ProviderCompanyAdress { get; set; }
        public string RecipientCompanyName { get; set; }
        public string RecipientCompanyAdress { get; set; }
        public decimal Total { get {
                return Items.Select(x => x.Cost).Sum();
            } }
        public List<InvoiceItem>Items { get; set; }
    }
}
