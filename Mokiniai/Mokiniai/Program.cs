using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MokinysClass;

namespace Mokiniai
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pazymiusarasas1 = new List<int>();
            List<int> pazymiusarasas2 = new List<int>();
            List<int> pazymiusarasas3 = new List<int>();
            List<int> pazymiusarasas4 = new List<int>();
            var mokinys1 = new MokinysCS(1, "Petras", pazymiusarasas1);
            var mokinys2 = new MokinysCS(2, "Jonas", pazymiusarasas2);
            var mokinys3 = new MokinysCS(3, "Laima", pazymiusarasas3);
            var mokinys4 = new MokinysCS(4, "Asta", pazymiusarasas4);
            List<MokinysCS> mokiniai = new List<MokinysCS>();
            mokiniai.Add(mokinys1);
            mokiniai.Add(mokinys2);
            mokiniai.Add(mokinys3);
            mokiniai.Add(mokinys4);
            pazymiusarasas1.Add(8);
            pazymiusarasas1.Add(4);
            pazymiusarasas2.Add(3);
            pazymiusarasas2.Add(5);
            pazymiusarasas3.Add(9);
            pazymiusarasas3.Add(7);
            pazymiusarasas4.Add(2);
            pazymiusarasas4.Add(4);
            foreach (var item in mokiniai)
            {
                Console.WriteLine("Mokinys ID={0}, vardas - {1}, pažymių vidurkis {2}", item.ID, item.Vardas, item.VidurkioSkaiciavimas(item.PazymiuSarasas));
            }

            Console.ReadLine();
        }
    }
}
