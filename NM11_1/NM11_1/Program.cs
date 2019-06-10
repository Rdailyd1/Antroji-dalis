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

            Console.WriteLine("Iveskite varda:");
            string vardas = Console.ReadLine();
            Console.WriteLine("Iveskite pavarde:");
            string pavarde = Console.ReadLine();
            Console.WriteLine("Iveskite gimimo metus:");
            DateTime  gimMetai= Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("{0} {1} {2}", VardasPavarde.Vardas(vardas), VardasPavarde.Pavarde(pavarde), VardasPavarde.GimMetai(gimMetai));
            Console.WriteLine("Jums yra {0} m", VardasPavarde.GetAge());
            Console.ReadLine();
        }
    }
}
