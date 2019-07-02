using System;
using System.Collections.Generic;
using System.Text;

namespace ParduotuvesKasosSistemaBL
{
    public class CekioElementas
    {
        public CekioElementas()
        {

        }
        public CekioElementas(Guid _cekioId, string _prekesPavadinimas, string _prekesKodas, decimal _vienetoKaina)
        {
            CekioID = _cekioId;
            PrekesPavadinimas = _prekesPavadinimas;
            PrekesKodas = _prekesKodas;
            VienetoKaina = _vienetoKaina;
        }
        public Guid CekioID { get; set; }
        public string PrekesPavadinimas { get; set; }
        public string PrekesKodas { get; set; }
        public decimal VienetoKaina { get; set; }
    }
}
