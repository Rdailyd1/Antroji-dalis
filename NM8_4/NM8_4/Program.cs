using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pirkinys;
namespace NM8_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int testi_iseiti = 1;
            int prekesnr = 0;
            int index = 0;
            int nkiekis = 0;
            
               
            pirkinys pirk = new pirkinys();
            List<pirkinys> prekiuSarasas = new List<pirkinys>();
            pirk.PrekesPavadinimas = "Bulves";
            pirk.Kiekis = 5;
            pirk.KainaVieneto = 1.9m;
            prekiuSarasas.Add(pirk);
            pirk.PrekesPavadinimas = "Obuoliai";
            pirk.Kiekis = 3;
            pirk.KainaVieneto = 2.5m;
            prekiuSarasas.Add(pirk);
            pirk.PrekesPavadinimas = "Morkos";
            pirk.Kiekis = 6;
            pirk.KainaVieneto = 0.8m;
            prekiuSarasas.Add(pirk);
            pirk.PrekesPavadinimas = "Suris";
            pirk.Kiekis = 1;
            pirk.KainaVieneto = 5.8m;
            prekiuSarasas.Add(pirk);
            int rodyti = 0;
            while (testi_iseiti == 1)
            {
                Console.WriteLine("Ką norite atlikti[1] Pridėti prekę, [2] Ištrinti prekę, [3] Koreguoti kiekį, [4] Parodyti visą sąrašą");
                rodyti = int.Parse(Console.ReadLine());
                if (rodyti == 1)
                {
                    Console.WriteLine("Įveskite prekės pavadinimą");
                    pirk.PrekesPavadinimas = Console.ReadLine();
                    Console.WriteLine("Įveskite kiekį");
                    pirk.Kiekis = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Įveskite vieneto kainą");
                    pirk.KainaVieneto = Convert.ToDecimal(Console.ReadLine());
                    prekiuSarasas.Add(pirk);
                    IsvestiSarasa(prekiuSarasas);
                }
                else if (rodyti == 2)
                {
                    Console.WriteLine("Kurią prekę ištrinti(įveskite prekės Nr.)?");
                    prekesnr = Convert.ToInt16(Console.ReadLine()) - 1;
                    if (prekesnr >= prekiuSarasas.Count() || prekesnr < 0)
                    {
                        Console.WriteLine("Tokia preke neegzistuoja");
                    }
                    else
                    {
                        prekiuSarasas.RemoveAt(prekesnr);
                        IsvestiSarasa(prekiuSarasas);
                    }
                }
                else if (rodyti == 3)
                {
                    Console.WriteLine("Kurią prekę koreguosite?");
                    index = Convert.ToInt16(Console.ReadLine())-1;
                    Console.WriteLine("Prekė: {0}, {1} kg, {2} eur", prekiuSarasas[index].PrekesPavadinimas, prekiuSarasas[index].Kiekis, prekiuSarasas[index].KainaVieneto);
                    Console.WriteLine("Įveskite naują kiekį");
                    nkiekis = Convert.ToInt16(Console.ReadLine());
                    pirkinys tarpinis = new pirkinys();
                    tarpinis.Kiekis = nkiekis;
                    tarpinis.PrekesPavadinimas = prekiuSarasas[index].PrekesPavadinimas;
                    tarpinis.KainaVieneto = prekiuSarasas[index].KainaVieneto;
                    prekiuSarasas[index] = tarpinis;
                    
                }
                else if (rodyti == 4)
                {
                    IsvestiSarasa(prekiuSarasas);
                }
                Console.WriteLine("[1] Tęsti darbą, [2] Išeiti");
                testi_iseiti = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("Pabaiga");
            Console.ReadLine();
        }

        private static void IsvestiSarasa(List<pirkinys> prekiuSarasas)
        {
            decimal viso = 0;
            foreach (var elementas in prekiuSarasas)
            {
                Console.WriteLine("Prekė: {0}, {1} kg, {2} eur", elementas.PrekesPavadinimas, elementas.Kiekis, elementas.KainaVieneto);
                Console.WriteLine("Kaina viso: {0} eur", elementas.KainaViso);
                viso += elementas.KainaViso;
            }
            Console.WriteLine("Viso kaina: {0}", viso);
            
        }
    }
}

