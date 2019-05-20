using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public struct Mokinys
        {
            public string vardas;
            public string pavarde;
            public DateTime kursoPradzia;
            public DateTime kursoPabaiga;
        }
        static void Main(string[] args)
        {
            Mokinys mok = new Mokinys();
            mok.vardas = "Lukas";
            mok.pavarde = "Zareckas";
            mok.kursoPradzia = Convert.ToDateTime("2019-05-01");
            mok.kursoPabaiga = Convert.ToDateTime("2019-07-01");
            Console.WriteLine("Vardas {0}", mok.vardas);
            Console.WriteLine("Pavarde  {0}", mok.pavarde);
            Console.WriteLine("Kurso pradzia  {0}", mok.kursoPradzia);
            Console.WriteLine("Kurso pabaiga {0}", mok.kursoPabaiga);
            Console.ReadLine();
        }
    }
}
