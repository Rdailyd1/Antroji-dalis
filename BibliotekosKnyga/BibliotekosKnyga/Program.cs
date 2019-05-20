using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekosKnyga
{
    class Program
    {
        public struct BibliotekosKnyga
        {
            public int ID;
            public string pavadinimas;
            public string skaitytojovardas;
            public DateTime paemimodata;
            public int knygaPasskaitytoja()
            {
                DateTime diena = DateTime.Now;
                int dienuSkaicius = (diena - paemimodata).Days;
                return dienuSkaicius;
            }
        }
        static void Main(string[] args)
        {
            BibliotekosKnyga knygos = new BibliotekosKnyga();
            knygos.ID = 1;
            knygos.skaitytojovardas = "Linas";
            knygos.pavadinimas = "Gera knyga";
            knygos.paemimodata = new DateTime(2019, 05, 01);//Convert.ToDateTime("2019-04-01");
            Console.WriteLine("Dienu skaicius {0}", knygos.knygaPasskaitytoja());
            Console.ReadLine();
        }
    }
}
