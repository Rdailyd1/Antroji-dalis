using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumanControl.Repositories;
using HumanControl;

namespace PraejimoKontrole
{
    class Program
    {
        static void Main(string[] args)
        {
            int meniuNr = 0;
            int zmogausId = 0;
            int vartuId = 0;
            int ataskaitaNr = 0;
            int testi = 1;
            EventController eventController = new EventController();
            while (testi == 1)
            {
                Console.Clear();
                Console.WriteLine("[1] Bandyti praeiti");
                Console.WriteLine("[2] Rodyti ataskaitas:");
                meniuNr = Convert.ToInt16(Console.ReadLine());
                if (meniuNr == 1)
                {
                    Console.WriteLine("i. Įveskite žmogaus ID");
                    zmogausId = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("ii. Įveskite vartų ID");
                    vartuId = Convert.ToInt16(Console.ReadLine());
                    if (eventController.TryPass(zmogausId, vartuId) == true)
                    {
                        Console.WriteLine("Žmogus praejo");
                    }
                    else
                    {
                        Console.WriteLine("Žmogus nepraejo");
                    }
                    foreach (var ivykis in eventController._events)
                    {
                        Console.WriteLine("{0} {1} {2} {3} {4}", ivykis.Id, ivykis.GateId, ivykis.Date, ivykis.HumanId, ivykis.pass);
                    }
                    ReportGenerator generator = new ReportGenerator(eventController._events, new HumanRepository, new GateRepository)
                    Console.WriteLine("Ar norite tęsti?");
                    testi = Convert.ToInt16(Console.ReadLine());
                }
                
            }
        }
            //else
            //{
            //    Console.WriteLine("[1] Bendroji praėjimų ataskaita");
            //    Console.WriteLine("[2] Išdirbtų valandų ataskaita");
            //    ataskaitaNr = Convert.ToInt16(Console.ReadLine());
            //}
           
        }
    }

