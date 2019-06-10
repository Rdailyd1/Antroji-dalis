using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VardasPavarde;

namespace NM11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var VardasPavarde = new VardasPavarde_cs();
            Console.WriteLine("{0} {1}", VardasPavarde.Vardas("Rolandas"), VardasPavarde.Pavarde("Dailydė"));
            Console.ReadLine();
        }
    }
}
