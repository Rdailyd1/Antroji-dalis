using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStruct;

namespace BookProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Book knyga = new Book("Vardas", "123");
            //knyga.LocalId = string.Format("{0}_{1}", knyga.Name, knyga.Id);

            Console.WriteLine(knyga.Name);
            Console.WriteLine(knyga.Id);
            //Console.WriteLine(knyga.GetId());
            Console.WriteLine(knyga.LocalId);
            
            Console.ReadLine();
        }
    }
}
