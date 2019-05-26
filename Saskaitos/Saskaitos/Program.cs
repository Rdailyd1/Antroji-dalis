using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Saskaita;

namespace Saskaitos
{
    class Program
    {
        static void Main(string[] args)
        {
            saskaita sask = new saskaita("Imone","vst",250);
            
            Console.WriteLine(sask.Gavejas);
            Console.WriteLine(sask.Siuntejas);
            Console.WriteLine(sask.SaskaitosNumeris);
            Console.WriteLine(sask.MoketiViso);
            Console.ReadLine();
        }
    }
}
