using System;
using System.Collections.Generic;

namespace MokinysClass
{
    public class MokinysCS
    {
        public MokinysCS()
        {

        }
        public MokinysCS(int id, string vardas, List<int> pazymiusarasas, bool nugaletojas)
        {
            ID = id;
            Vardas = vardas;
            PazymiuSarasas = pazymiusarasas;
            OlimpijaduNugaletojas = nugaletojas;
        }
        public int ID { get; private set; }
        public string Vardas { get; private set; }
        public List<int> PazymiuSarasas { get; set; }
        public bool OlimpijaduNugaletojas { get; set; }
        public int VidurkioSkaiciavimas(List<int> PazymiuSarasas)
        {
            int vidurkis = 0;
            foreach (var item in PazymiuSarasas)
            {
                vidurkis += item;
            }
            return vidurkis/PazymiuSarasas.Count;
        }
    }
}
