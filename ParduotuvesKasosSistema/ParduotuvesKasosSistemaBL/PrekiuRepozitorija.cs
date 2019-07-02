using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ParduotuvesKasosSistemaBL
{
    public class PrekiuRepozitorija
    {
        private List<Preke> prekes = new List<Preke>();
        public PrekiuRepozitorija()
        {
            prekes.Add(new Preke(1, "123","Duona", 1.5m));
            prekes.Add(new Preke(2, "234", "Sviestas", 2.1m));
            prekes.Add(new Preke(3, "345", "Pienas", 1.3m));
            prekes.Add(new Preke(4, "456", "Obuoliai", 1.2m));
        }
        public void PrekiuPridejimas(string prekesPavadinimas, string prekesKodas, decimal prekesVienetoKaina)
        {
            prekes.Add(new Preke() { ID = prekes.OrderByDescending(x=>x.ID).Select(x=>x.ID).FirstOrDefault() + 1, Kodas = prekesKodas, PrekesPavadinimas = prekesPavadinimas, PrekesKaina = prekesVienetoKaina});
        }
        public List<Preke> Retrieve()
        {
            return prekes;
        }
        public void PrekiuTrynimas(int index)
        {
            prekes.RemoveAt(index);
        }
    }
}
