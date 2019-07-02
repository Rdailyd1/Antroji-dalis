using System;
using System.Collections.Generic;
using System.Text;
using ParduotuvesKasosSistemaBL;
using System.Linq;
namespace ParduotuvesKasosSistemaBL
{
    public class CekioPrekiuAtaskaita
    {
        public CekiuRepozitorija _cekiuRepozitorija;
        public CekioPrekiuAtaskaita(CekiuRepozitorija cekiuRepozitorija)
        {
            _cekiuRepozitorija = cekiuRepozitorija;
        }
        public List<ReportItem> GenerateCurrentChecqueReport()
        {
             List<ReportItem> ataskaita = new List<ReportItem>();
            var cekiai = _cekiuRepozitorija.Retrieve();
            if (cekiai.Count > 0)
            {
                foreach (var cekis in cekiai)
                {
                    ReportItem reportItem = new ReportItem();
                    reportItem.CekioID = cekis.CekioID;
                    reportItem.Kodas = cekis.PrekesKodas;
                    reportItem.PrekesPavadinimas = cekis.PrekesPavadinimas;
                    reportItem.PrekesKaina = cekis.VienetoKaina;
                    ataskaita.Add(reportItem);
                }
                return ataskaita;
            }
            else
            {
                return null;
            }
        }
        public List<ReportItem> GenerateLastChecqueReport()
        {
            List<ReportItem> ataskaita = new List<ReportItem>();
            var cekiai = _cekiuRepozitorija.RetrieveAllChecqes().OrderByDescending(x=>x.PirkimoData).FirstOrDefault();
            if (cekiai != null)
            {
                foreach (var cekioElementai in cekiai.CekioElementuSarasas)
                {
                    ReportItem reportItem = new ReportItem();
                    reportItem.CekioID = cekioElementai.CekioID;
                    reportItem.Kodas = cekioElementai.PrekesKodas;
                    reportItem.PrekesPavadinimas = cekioElementai.PrekesPavadinimas;
                    reportItem.PrekesKaina = cekioElementai.VienetoKaina;
                    ataskaita.Add(reportItem);
                }
                return ataskaita;
            }
            else
            {
                return null;
            }
        }
    }
}
