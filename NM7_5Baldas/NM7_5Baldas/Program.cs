using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NM7_5Baldas
{
    class Program
    {
        public struct Baldas
        {
            public string pavadinimas;
            public string kategorija;
            public decimal kaina;
            //public int visoBaldu()
            //{
            //    int suma = 0;
            //    return suma;
            //}
        }
            public static void kainininkas(List<Baldas> sarasas)
            {
                Baldas baldai = new Baldas();
                baldai.kategorija = "Virtuvės";
                baldai.pavadinimas = "Ledas";
                baldai.kaina = 2500m;
                sarasas.Add(baldai);
                baldai.kategorija = "Miegamojo";
                baldai.pavadinimas = "Tulpe";
                baldai.kaina = 1500.50m;
                sarasas.Add(baldai);
                baldai.kategorija = "Svetainės";
                baldai.pavadinimas = "Pieva";
                baldai.kaina = 4200m;
                sarasas.Add(baldai);
                baldai.kategorija = "Virtuvės";
                baldai.pavadinimas = "Kolonos";
                baldai.kaina = 3500m;
                sarasas.Add(baldai);
                baldai.kategorija = "Miegamojo";
                baldai.pavadinimas = "Rokas";
                baldai.kaina = 1800m;
                sarasas.Add(baldai);
                baldai.kategorija = "Svetainės";
                baldai.pavadinimas = "Taiga";
                baldai.kaina = 4000m;
                sarasas.Add(baldai);
                baldai.kategorija = "Virtuvės";
                baldai.pavadinimas = "Sefas";
                baldai.kaina = 3200m;
                sarasas.Add(baldai);
                baldai.kategorija = "Miegamojo";
                baldai.pavadinimas = "Opa";
                baldai.kaina = 2500m;
                sarasas.Add(baldai);
                baldai.kategorija = "Svetainės";
                baldai.pavadinimas = "Saule";
                baldai.kaina = 4400m;
                sarasas.Add(baldai);
        }
        static void Main(string[] args)
        {
            List<Baldas> baldu_sar = new List <Baldas>();
            kainininkas(baldu_sar);
            Console.WriteLine("Viso baldu sarase: {0}", baldu_sar.Count());
            decimal miegbaldukaina = 0m;
            decimal virtbaldukaina = 0m;
            decimal svetbaldukaina = 0m;
            decimal bendrakaina = 0m;
            foreach (Baldas elementas in baldu_sar)
            {
                if (elementas.kategorija == "Miegamojo")
                    miegbaldukaina += elementas.kaina;
                if (elementas.kategorija == "Virtuvės")
                    virtbaldukaina += elementas.kaina;
                if (elementas.kategorija == "Svetainės")
                    svetbaldukaina += elementas.kaina;
            }
            bendrakaina += miegbaldukaina + virtbaldukaina + svetbaldukaina;
            Console.WriteLine("Miegamojo baldu kaina: {0}", miegbaldukaina);
            Console.WriteLine("Virtuves baldu kaina: {0}", virtbaldukaina);
            Console.WriteLine("Svetaines baldu kaina: {0}", svetbaldukaina);
            Console.WriteLine("Bendra visu baldu kaina: {0}", bendrakaina);
            Console.ReadLine();
        }
    }
}
