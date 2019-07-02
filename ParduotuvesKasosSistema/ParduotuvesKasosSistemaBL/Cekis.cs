using System;
using System.Collections.Generic;
using System.Text;

namespace ParduotuvesKasosSistemaBL
{
    public class Cekis
    {
        public Cekis()
        {
            CekioElementuSarasas = new List<CekioElementas>();
        }
      
        public Guid CekioID { get; set; }
        public DateTime PirkimoData { get; set; }
        public List<CekioElementas> CekioElementuSarasas { get; set; }
    }
}
