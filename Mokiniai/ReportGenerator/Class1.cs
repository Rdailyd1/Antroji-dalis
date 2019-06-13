using System;
using MokinysClass;
using MokinioRepozitorija;
using System.Collections.Generic;

namespace ReportGenerator
{
    public class ReportGeneratorCS
    {
        private MokinioRepozitorijaCS _mokinioRepozitorija;
        public ReportGeneratorCS(MokinioRepozitorijaCS mokinioRepozitorija)
        {
            _mokinioRepozitorija = mokinioRepozitorija;
        }
        public string GeneruotiMokiniuAtaskaita()
        {
            List<MokinysCS> visiMokiniai = _mokinioRepozitorija.Retrieve();
            string mokinysTarpinis = "";
            foreach (var vienasMokinys in visiMokiniai)
            {
               mokinysTarpinis += "ID: " + vienasMokinys.ID + " Vardas: " + vienasMokinys.Vardas + Environment.NewLine;
            }
            return mokinysTarpinis;
        }
    }
    

}
