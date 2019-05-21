using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NM7_1Zmogus
{
    class Program
    {
        public struct Zmogus
        {
            public string vardas;
            public string pavarde;
        }
        static void Main(string[] args)
        {
            Zmogus vyras = new Zmogus();
            vyras.vardas = "Antanas";
            vyras.pavarde = "Antanauskas";
            Zmogus moteris = new Zmogus();
            moteris.vardas = "Rita";
            moteris.pavarde = "Ritenyte";
            Console.WriteLine("Zmogus Nr.1: {0} {1}", vyras.vardas, vyras.pavarde);
            Console.WriteLine("Zmogus Nr.2: {0} {1}", moteris.vardas, moteris.pavarde);
            Console.ReadLine();
        }
    }
}

