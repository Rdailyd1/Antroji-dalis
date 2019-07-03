using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParduotuvesKasosSistemaBL
{
    public class CekiuRepozitorija
    {
        private List<Cekis> visiCekiai = new List<Cekis>();
        private Cekis einamasisCekis = new Cekis();
        public List<CekioElementas> Retrieve()
        {
            return einamasisCekis.CekioElementuSarasas;
        }
        public Cekis RetrieveOneCheques()
        {
            return einamasisCekis;
        }
        public List<Cekis> RetrieveAllChecqes()
        {
            return visiCekiai;
        }
      
        public void PradetiNaujaCeki()
        {
            einamasisCekis = new Cekis();
            einamasisCekis.CekioID = Guid.NewGuid();
            einamasisCekis.PirkimoData = DateTime.Now;
        }

        public void UzbaigtiEinamaCeki()
        {
            visiCekiai.Add(einamasisCekis);
        }
        public void IdejimasIKrepseli(int id, string prekesKodas, string prekesPavadinimas, decimal prekesKaina)
        {

           einamasisCekis.CekioElementuSarasas.Add(new CekioElementas() { CekioID = einamasisCekis.CekioID, PrekesPavadinimas = prekesPavadinimas, PrekesKodas = prekesKodas, VienetoKaina = prekesKaina });
 
        } 
        public void Trinti()
        {
            einamasisCekis.CekioElementuSarasas.Clear();
        }
        public void PrekiuTrynimas(int index)
        {
            einamasisCekis.CekioElementuSarasas.RemoveAt(index);
        }
    }
}
