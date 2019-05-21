using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NM7_2Zmogus
{
    class Program
    {
        public struct Zmogus
        {
            public string vardas;
            public string pavarde;
            public DateTime GimMetai;
            public int amzius()
            {
                DateTime siandien = DateTime.Now;
                int metai = (siandien - GimMetai).Days / 365;
                return metai;
            }
        }
        static void Main(string[] args)
        {
            Zmogus vyras = new Zmogus();
            vyras.vardas = "Antanas";
            vyras.pavarde = "Antanauskas";
            vyras.GimMetai = new DateTime(1980,10,12);
            Zmogus moteris = new Zmogus();
            moteris.vardas = "Rita";
            moteris.pavarde = "Ritenyte";
            moteris.GimMetai = new DateTime(1975, 05, 17);
            Console.WriteLine("Zmogus Nr.1: {0} {1}, amzius {2}", vyras.vardas, vyras.pavarde, vyras.amzius());
            Console.WriteLine("Zmogus Nr.2: {0} {1}, amzius {2}", moteris.vardas, moteris.pavarde, moteris.amzius());
            Console.ReadLine();
        }
    }
}
