using System;

namespace BibliotekosKnyga
{
    public class BibliotekosKnygaCs
    {
        public BibliotekosKnygaCs()
        {

        }
        public BibliotekosKnygaCs(int id, string pavadinimas, int dienosGrazinti)
        {
            Pavadinimas = pavadinimas;
            DienosGrazinti = dienosGrazinti;
            ID = id;
        }
        public int ID { get; private set; }
        public string Pavadinimas { get; private set; }
        public int DienosGrazinti { get; private set; }
        public string SkaitytojoVardas { get; set; }
        public DateTime PaemimoData { get; set; }
        public decimal Delspinigiai { get; set; }
        public bool ArLaikuGrazino()
        {

            bool arLaiku = true;
            DateTime grazinimoData = PaemimoData.AddDays(DienosGrazinti);
            if (grazinimoData <= DateTime.Now)
            {
                arLaiku = false;
            }
                return arLaiku;
        }
       public int PradelstosDienos()
        {
            int virsytuDienuSk = 0;
            DateTime grazinimoData = PaemimoData.AddDays(DienosGrazinti);
            if (!ArLaikuGrazino())
            {
                virsytuDienuSk = (DateTime.Now - grazinimoData).Days;
            }
            return virsytuDienuSk;
        }
        public decimal DelspiniguSkaiciavimas()
        {
            int virsytuDienuSkaicius = PradelstosDienos();
            decimal ikainis = 0.17m;
            Delspinigiai = ikainis * virsytuDienuSkaicius;
            return Delspinigiai;
        }
        public bool Validate()
        {
            var isValid = true;
            DateTime pridetaData = PaemimoData.AddDays(DienosGrazinti);
            if (pridetaData <= DateTime.Now.Date)
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
