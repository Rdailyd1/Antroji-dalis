using System;
using System.Collections.Generic;
using System.Linq;
using MokinysClass;

namespace MokinioRepozitorija
{
    public class MokinioRepozitorijaCS
    {
        private List<MokinysCS> mokiniai = new List<MokinysCS>();
        public List<MokinysCS> Retrieve()
        {
            return mokiniai;
        }
        public MokinysCS Retrieve(int id)
        {
            return mokiniai.Where(x => x.ID == id).FirstOrDefault();
        }
       List<int> pazymiusarasas1 = new List<int>();
        List<int> pazymiusarasas2 = new List<int>();
        List<int> pazymiusarasas3 = new List<int>();
        List<int> pazymiusarasas4 = new List<int>();
        public MokinioRepozitorijaCS()
        {
            pazymiusarasas1.Add(8);
            pazymiusarasas1.Add(5);
            pazymiusarasas2.Add(7);
            pazymiusarasas2.Add(4);
            pazymiusarasas3.Add(8);
            pazymiusarasas3.Add(5);
            pazymiusarasas4.Add(9);
            pazymiusarasas4.Add(7);
            mokiniai.Add(new MokinysCS(1, "Tadas", pazymiusarasas1, true));
            mokiniai.Add(new MokinysCS(2, "Jolanta", pazymiusarasas2, false));
            mokiniai.Add(new MokinysCS(3, "Simas", pazymiusarasas3, false));
            mokiniai.Add(new MokinysCS(4, "Rima", pazymiusarasas4, false));
        }
    }
}
