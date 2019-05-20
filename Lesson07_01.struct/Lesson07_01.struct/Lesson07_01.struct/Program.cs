using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07_01.@struct
{
    class Program
    {

        private static int MetinisVidurkis(int trim1, int trim2, int trim3)
        {
            int vid = (trim1 + trim2 + trim3) / 3;
            return vid;
        }
        static void Main(string[] args)
        {
            int trimestras1 = 8;
            int trimestras2 = 10;
            int trimestras3 = 9;

            Console.WriteLine(MetinisVidurkis(trimestras1, trimestras2, trimestras3));
            Console.ReadLine();
        }
    }
}
