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
        public int zooSodoNr;
        public Gyvunas(string vardas, string rusis, int ZooSodoNr)
        {
            Vardas = vardas;
            Rusis = rusis;
            zooSodoNr = ZooSodoNr;
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
            List<RusisKiekis> skirtinguRusiuSarasas = new List<RusisKiekis>();
            Console.WriteLine("Skirtingos rusys yra:");
            foreach(string k in skirtingosRusys)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine();
            Console.WriteLine("Skirtingu rusiu skaicius {0}", skirtingosRusys.Count());

            return skirtinguRusiuSarasas;
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
        List<Zoologijossodas> zoosoduSarasas = new List<Zoologijossodas>();
        zoologijossodas.pavadinimas = "Kauno zoologijos sodas";
        zoologijossodas.adresas = "Kaunas, Lietuva";
        zoosoduSarasas.Add(zoologijossodas);
        zoologijossodas.pavadinimas = "Rygos zoologijos sodas";
        zoologijossodas.adresas = "Ryga, Latvija";
        zoosoduSarasas.Add(zoologijossodas);
        Console.WriteLine("Zoologijos sodu sarasas:");
        foreach (var elementai in zoosoduSarasas)
        {
            Console.WriteLine("Pavadinimas - {0}, adreasas - {1}", elementai.pavadinimas, elementai.adresas);
        }
        Console.WriteLine();
        zoologijossodas.gyvunai = new List<Gyvunas>();
        zoologijossodas.gyvunai.Add(new Gyvunas("Zigmas", "Lokys", 1));
        zoologijossodas.gyvunai.Add(new Gyvunas("Didis", "Erelis",1));
        zoologijossodas.gyvunai.Add(new Gyvunas("Jonas", "Lokys", 2));
        zoologijossodas.gyvunai.Add(new Gyvunas("Ramus", "Stumbras", 2));
        var skaiciuotiKieki = zoologijossodas.KiekisPagalRusi();
        int kiek = skaiciuotiKieki.Count();
        Console.WriteLine();
        Console.WriteLine("Viso gyvunu yra {0}\n", zoologijossodas.VisoGyvunu());
        Console.WriteLine("Gyvuno rusis, vardas, zoologijos sodo pavadinimas, adresas:\n");     
        foreach (var zoosodogyvunai in zoologijossodas.gyvunai)
        {
                
            Console.WriteLine("{0}, {1}, {2},({3})", zoosodogyvunai.Rusis, zoosodogyvunai.Vardas, zoosoduSarasas[zoosodogyvunai.zooSodoNr-1].pavadinimas, zoosoduSarasas[zoosodogyvunai.zooSodoNr - 1].adresas);
        }

        List<string> skirtRusys = zoologijossodas.gyvunai.Select(x => x.Rusis).Distinct().ToList();
        Console.WriteLine();
        foreach (var rusis in skirtRusys)
        {
            int sk = 0;
            foreach (var kiekis in zoologijossodas.gyvunai)
            {

                if (rusis == kiekis.Rusis)
                {
                    sk++;
                }
            }
            Console.WriteLine("Gyvunu rusies {0} yra {1} gyv. ", rusis, sk);
        }

        foreach (var rusis in skirtRusys)
        {
            Console.WriteLine();
            Console.WriteLine("Gyvunu rusis {0} yra šiuose zoologijos soduose:", rusis);
            foreach (var kiekis in zoologijossodas.gyvunai)
            {
                if (rusis == kiekis.Rusis)
                {
                    Console.WriteLine(zoosoduSarasas[kiekis.zooSodoNr-1].pavadinimas);
                }
            }
        }
            Console.WriteLine();
            foreach (var sodai in zoosoduSarasas)
            {
                int sk = 0;
                Console.WriteLine("Zoologijos sode '{0}' yra šie gyvūnai:", sodai.pavadinimas);
                foreach (var kiekis in zoologijossodas.gyvunai)
                {
                    if (sodai.pavadinimas == zoosoduSarasas[kiekis.zooSodoNr - 1].pavadinimas)
                    {
                        sk++;
                        Console.WriteLine(kiekis.Rusis);
                    }
                }
                Console.WriteLine("Viso šiame sode gyvūnų {0}\n", sk);
            }
                Console.ReadLine();
    }
}
}
