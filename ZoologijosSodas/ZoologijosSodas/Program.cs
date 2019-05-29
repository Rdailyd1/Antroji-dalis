using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoologijosSodas
{
    class Program
    {
        public struct Gyvunas
        {
            public string Vardas;
            public string Rusis;
            public Gyvunas(string vardas, string rusis)
            {
                Vardas = vardas;
                Rusis = rusis;
            }
        }
        public struct Zoologijossodas
        {
            public string pavadinimas;
            public string adresas;
            public  List<Gyvunas> gyvunai;

            public int VisoGyvunu()
            {
                return gyvunai.Count();
            }
            public List<RusisKiekis> KiekisPagalRusi()
            {
                List<string> skirtingosRusys = gyvunai.Select(x => x.Rusis).Distinct().ToList();
                List<RusisKiekis> kiekispagalrusi = new List<RusisKiekis>();
                return kiekispagalrusi;
            }
        }
        public struct RusisKiekis
        {
            public string rusis;
            public int kiekis;
        }
        static void Main(string[] args)
        {
            Zoologijossodas zoologijossodas = new Zoologijossodas();
            zoologijossodas.adresas = "aaasssddd";
            zoologijossodas.pavadinimas = "pavadinimas";
            zoologijossodas.gyvunai = new List<Gyvunas>();

            zoologijossodas.gyvunai.Add(new Gyvunas("Zigmas", "Lokys"));
            zoologijossodas.gyvunai.Add(new Gyvunas("Didis", "Erelis"));
            zoologijossodas.gyvunai.Add(new Gyvunas("Jonas", "Lokys"));
            zoologijossodas.KiekisPagalRusi();

        }
    }
}
