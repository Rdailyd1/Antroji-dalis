using System;
using System.Collections.Generic;
using System.Text;

namespace ParduotuvesKasosSistemaBL
{
    public class Preke
    {
        public Preke()
        {

        }
        public Preke(int _id, string _kodas, string _prekesPavadinimas, decimal _prekesKaina)
        {
            ID = _id;
            Kodas = _kodas;
            PrekesPavadinimas = _prekesPavadinimas;
            PrekesKaina = _prekesKaina;
        }
        public int ID { get; set; }
        public string Kodas { get; set; }
        public string PrekesPavadinimas { get; set; }
        public decimal PrekesKaina { get; set; }
    }
}
