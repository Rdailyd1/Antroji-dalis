using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MokinysStruct;

namespace MokinysTrimestrai
{
    class Program
    {
      
        static void Main(string[] args)
        {
            
            Mokinys mokinys = new Mokinys();
            mokinys.trimestras1 = new List<int>();
            mokinys.trimestras2 = new List<int>();
            mokinys.trimestras3 = new List<int>();

            mokinys.trimestras1.Add(5);
            mokinys.trimestras1.Add(7);
            mokinys.trimestras1.Add(6);
            mokinys.trimestras2.Add(4);
            mokinys.trimestras2.Add(7);
            mokinys.trimestras2.Add(9);
            mokinys.trimestras3.Add(4);
            mokinys.trimestras3.Add(5);
            mokinys.trimestras3.Add(5);
            Console.WriteLine("Pirmojo trimestro vidurkis {0}", mokinys.PirmojoTrimestroVidurkis());
            Console.WriteLine("Pirmojo trimestro vidurkis {0}", mokinys.AntrojoTrimestroVidurkis());
            Console.WriteLine("Pirmojo trimestro vidurkis {0}", mokinys.TrecioTrimestroVidurkis());
            Console.WriteLine("Metinis pazymys {0}", (mokinys.PirmojoTrimestroVidurkis() + mokinys.AntrojoTrimestroVidurkis() + mokinys.TrecioTrimestroVidurkis())/3);
            Console.ReadLine();
        }
    }
}
