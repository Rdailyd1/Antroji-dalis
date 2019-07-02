using System;
using System.Collections.Generic;
using System.Text;

namespace ParduotuvesKasosSistemaBL
{
    public class ReportItem
    {
        public Guid CekioID { get; set; }
        public string Kodas { get; set; }
        public string PrekesPavadinimas { get; set; }
        public decimal PrekesKaina { get; set; }
    }
}
