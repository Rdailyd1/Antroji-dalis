using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pirkinys;
namespace NM8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal viso = 0;
            pirkinys pirk = new pirkinys();
            List<pirkinys> prekiuSarasas = new List<pirkinys>();
            pirk._PrekėsPavadinimas = "Bulves";
            pirk._Kiekis = 5;
            pirk._KainaVieneto = 1.9m;
            prekiuSarasas.Add(pirk);
            pirk._PrekėsPavadinimas = "Obuoliai";
            pirk._Kiekis = 3;
            pirk._KainaVieneto = 2.5m;
            prekiuSarasas.Add(pirk);
            pirk._PrekėsPavadinimas = "Morkos";
            pirk._Kiekis = 6;
            pirk._KainaVieneto = 0.8m;
            prekiuSarasas.Add(pirk);
            pirk._PrekėsPavadinimas = "Suris";
            pirk._Kiekis = 1;
            pirk._KainaVieneto = 5.8m;
            prekiuSarasas.Add(pirk);
            foreach (var elementas in prekiuSarasas)
            {
                Console.WriteLine("Prekė: {0}, {1} kg, {2} eur", elementas._PrekėsPavadinimas, elementas._Kiekis, elementas._KainaVieneto);
                Console.WriteLine("Kaina viso: {0} eur", elementas.KainaViso);
                viso += elementas.KainaViso;
            }
            Console.WriteLine("Viso kaina: {0}", viso); 
            Console.ReadLine();
        }
    }
}
