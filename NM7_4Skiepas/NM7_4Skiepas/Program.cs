using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NM7_4Skiepas
{
    class Program
    {
        public struct Skiepas
        {
            public DateTime SkiepoData;
            public string SkiepoPavadinimas;
        }
        public static void skiepuKalendorius(List<Skiepas> sarasas)
        {
            Skiepas skiepai = new Skiepas();
            skiepai.SkiepoPavadinimas = "skiepas1";
            skiepai.SkiepoData = new DateTime(2019,10,15);
            sarasas.Add(skiepai);
            skiepai.SkiepoPavadinimas = "skiepas2";
            skiepai.SkiepoData = new DateTime(2019, 06, 20);
            sarasas.Add(skiepai);
            skiepai.SkiepoPavadinimas = "skiepas3";
            skiepai.SkiepoData = new DateTime(2019, 07, 23);
            sarasas.Add(skiepai);
            skiepai.SkiepoPavadinimas = "skiepas4";
            skiepai.SkiepoData = new DateTime(2019, 05, 10);
            sarasas.Add(skiepai);
            skiepai.SkiepoPavadinimas = "skiepas5";
            skiepai.SkiepoData = new DateTime(2019, 04, 05);
            sarasas.Add(skiepai);
            skiepai.SkiepoPavadinimas = "skiepas6";
            skiepai.SkiepoData = new DateTime(2019, 11, 25);
            sarasas.Add(skiepai);
            skiepai.SkiepoPavadinimas = "skiepas7";
            skiepai.SkiepoData = new DateTime(2019, 03, 02);
            sarasas.Add(skiepai);

        }
            static void Main(string[] args)
        {
            List<Skiepas> sk_sarasas = new List<Skiepas>();
            DateTime siandien = DateTime.Now;
            skiepuKalendorius(sk_sarasas);
            // if (skiepuKalendorius(sk_sarasas))
            int kiek_kartu = 0;
            foreach (Skiepas elementas in sk_sarasas)
            {
                if (elementas.SkiepoData <= siandien)
                {
                    kiek_kartu++;
                }
            }
            Console.WriteLine("Žmogus buvo skiepytas {0} kart", kiek_kartu);
            Console.WriteLine("Padaryti sie skiepai:");
            DateTime paskutinioSkdata = new DateTime();
            foreach (Skiepas elementas in sk_sarasas)
            {
                if (elementas.SkiepoData <= siandien)
                {
                    Console.WriteLine(elementas.SkiepoPavadinimas);
                    paskutinioSkdata = elementas.SkiepoData;
                } 
            }
            if (paskutinioSkdata.Year != 0)
            {
                Console.WriteLine("Paskutinio padaryto skiepo data {0}", paskutinioSkdata.ToShortDateString());
                Console.ReadLine();
            }
        }
    }
}
