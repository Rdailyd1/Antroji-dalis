using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pirkinys;
namespace NM8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            pirkinys pirk = new pirkinys();
            pirk._PrekėsPavadinimas = "Bulves";
            pirk._Kiekis = 5;
            pirk._KainaVieneto = 1.9m;
            Console.WriteLine("Prekė: {0}, {1} kg, {2} eur", pirk._PrekėsPavadinimas, pirk._Kiekis, pirk._KainaVieneto);
            Console.WriteLine("Kaina viso: {0} eur", pirk.KainaViso);
            Console.ReadLine();
        }
    }
}
