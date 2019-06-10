using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotekosKnyga;
namespace Biblioteka
{
    class Program
    {
        static void Main(string[] args)
        {
            var knygos = new BibliotekosKnygaCs();
            Console.WriteLine("Skaitytojo vardas:");
            string vardas = Console.ReadLine();
            int ID = 10;
            string pavadinimas = "Gera knyga";
            Console.WriteLine("Paėmimo data:");
            DateTime paemimoData = Convert.ToDateTime(Console.ReadLine());
            if(knygos.ArLaikuGrazino(ID, paemimoData))
            {
                Console.WriteLine("Knyga grazino laiku");
            }
            else
            {
                Console.WriteLine("Pavelavo grazinti knyga");
            }
            Console.ReadLine();
        }
    }
}
