using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staciakampis
{
    public struct Staciakampis
    {
        public int ilgis;
        public int plotis;

        public int Plotas()
        {
            int plotas = ilgis * plotis;
            return plotas;
        }
    }
   
    class Program
    {
        public static void SukurtiStaciakampius(List<Staciakampis> sarasas)
        {
            Staciakampis stac = new Staciakampis();
            stac.ilgis = 12;
            stac.plotis = 10;
            sarasas.Add(stac);
            stac.ilgis = 5;
            stac.plotis = 7;
            sarasas.Add(stac);
            stac.ilgis = 6;
            stac.plotis = 4;
            sarasas.Add(stac);
        }
        static void Main(string[] args)
        {
            List<Staciakampis> stacSarasas = new List<Staciakampis>();
            SukurtiStaciakampius(stacSarasas);
            foreach (Staciakampis elementas in stacSarasas)
            {

                Console.WriteLine("Plotas {0}", elementas.Plotas());
            }
            Console.ReadLine();
            }
    }
}

//    Console.WriteLine("Dienu skaicius {0}", knygos.knygaPasskaitytoja());
//    Console.ReadLine();
