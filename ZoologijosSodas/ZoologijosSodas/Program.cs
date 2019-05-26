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
            public string vardas;
            public string rusis;
        }
        public struct Zoologijossodas
        {
            public string pavadinimas;
            public string adresas;
            public  List<Gyvunas> gyvrusisvardai;
        }
        static void Main(string[] args)
            {
                List<Zoologijossodas> gyvsarasas = new List<Zoologijossodas>();
                List<Gyvunas> gyvrusisvardai = new List<Gyvunas>();
                Gyvunas gyvunai = new Gyvunas();
                Zoologijossodas gyvsodas = new Zoologijossodas();
                gyvunai.vardas = "Karalius";
                gyvunai.rusis = "Liutas";
                gyvrusisvardai.Add(gyvunai);
                gyvsodas.adresas = "Kaunas";
                gyvsodas.pavadinimas = "Centrinis sodas";
                gyvsarasas.Add(gyvsodas);
                gyvunai.vardas = "Smalse";
                gyvunai.rusis = "Lape";
                gyvrusisvardai.Add(gyvunai);
                gyvsodas.adresas = "Ryga";
                gyvsodas.pavadinimas = "Rygos zooparkas";
                gyvsarasas.Add(gyvsodas);

                foreach (Zoologijossodas elementas in gyvsarasas)
                {
                    Console.WriteLine(elementas.adresas + " " + elementas.pavadinimas);
            }
            foreach (Gyvunas elementas in gyvrusisvardai)
            {
                Console.WriteLine(elementas.rusis + " " + elementas.vardas);
            }
            Console.ReadLine();

            }
        }
    }
