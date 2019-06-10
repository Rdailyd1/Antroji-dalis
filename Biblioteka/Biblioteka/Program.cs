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
            var knygos = new BibliotekosKnygaCs(5, "Knyga", 10);
            Console.WriteLine("Skaitytojo vardas:");
            string vardas = Console.ReadLine();
           
            Console.WriteLine("Paėmimo data:");
            DateTime paemimoData = Convert.ToDateTime(Console.ReadLine());
            knygos.PaemimoData = paemimoData;
          
            if (knygos.ArLaikuGrazino())
            {
                Console.WriteLine("Knyga grazino laiku");
                Console.WriteLine("Delspinigiai {0} eur", Math.Round(knygos.DelspiniguSkaiciavimas(),2));
            }
            else
            {
                Console.WriteLine("Pavelavo grazinti knyga {0}", knygos.PradelstosDienos());
                Console.WriteLine("Delspinigiai {0} eur", Math.Round(knygos.DelspiniguSkaiciavimas(),2));
            }
                Console.ReadLine();
        }
    }
}
