using System;

namespace BibliotekosKnyga
{
    public class BibliotekosKnygaCs
    {
        public int ID { get; set; }
        public string pavadinimas { get; private set; }
        public int dienosGrazinti { get; private set; }
        public string skaitytojoVardas { get; set; }
        public DateTime paemimoData { get; set; }
        public bool ArLaikuGrazino(int dienosgrazinti, DateTime paemimodata)
        {

            bool arLaiku = true;
            DateTime grazinimoData = paemimodata.AddDays(dienosgrazinti);
            if (grazinimoData <= DateTime.Now)
            {
                arLaiku = false;
            }
                return arLaiku;
        }
    }
}
