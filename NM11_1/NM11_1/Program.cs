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
            VardasPavarde.vardas = "Rolandas";
            VardasPavarde.pavarde = "Dailydė";
            Console.WriteLine("{0} {1}", VardasPavarde.vardas, VardasPavarde.pavarde);
            Console.ReadLine();
        }
    }
}
