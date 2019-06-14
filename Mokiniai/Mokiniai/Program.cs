using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MokinysClass;
using MokinioRepozitorija;
using ReportGenerator;

namespace Mokiniai
{
    class Program
    {
        static void Main(string[] args)
        {
           
            MokinioRepozitorijaCS repo = new MokinioRepozitorijaCS();
            List<MokinysCS> mokiniai = repo.Retrieve();
            string OlNugaletojas = "";
            foreach (var item in mokiniai)
            {
                if (item.OlimpijaduNugaletojas == true)
                {
                    OlNugaletojas = "Taip";
                }
                else
                {
                    OlNugaletojas = "Ne";
                }
                Console.WriteLine("Mokinys ID={0}, vardas - {1}, olimpijados nugalėtojas - {2}", item.ID, item.Vardas, OlNugaletojas);
            }
            Console.WriteLine("Mokinys kurio ID=3 - {0}",mokiniai.Where(x=>x.ID==3).FirstOrDefault().Vardas);

            ReportGeneratorCS reportGenerator = new ReportGeneratorCS(new MokinioRepozitorijaCS());
            string mokiniuAtaskaita = reportGenerator.GeneruotiMokiniuAtaskaita();
            Console.WriteLine("Ataskaita:");
            Console.WriteLine(mokiniuAtaskaita);

            Console.ReadLine();
        }
    }
}
