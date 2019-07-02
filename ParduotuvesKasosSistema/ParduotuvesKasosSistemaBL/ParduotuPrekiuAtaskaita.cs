using System;
using System.Collections.Generic;
using System.Text;
using ParduotuvesKasosSistemaBL;

namespace ParduotuvesKasosSistemaBL
{
    public class ParduotuPrekiuAtaskaita
    {
        public CekiuRepozitorija _cekiuRepozitorija;
        public ParduotuPrekiuAtaskaita(CekiuRepozitorija cekiuRepozitorija)
        {
            _cekiuRepozitorija = cekiuRepozitorija;
        }
        public List<ReportItem> GenerateReportReceipt()
        {
            List<ReportItem> ataskaita = new List<ReportItem>();
            var cekiai = _cekiuRepozitorija.RetrieveAllChecqes();
            if (cekiai.Count > 0)
            {
                foreach (var cekis in cekiai)
                {
                    foreach (var cekioElementas in cekis.CekioElementuSarasas)
                    {
                        ReportItem reportItem = new ReportItem();
                        reportItem.CekioID = cekioElementas.CekioID;
                        reportItem.Kodas = cekioElementas.PrekesKodas;
                        reportItem.PrekesPavadinimas = cekioElementas.PrekesPavadinimas;
                        reportItem.PrekesKaina = cekioElementas.VienetoKaina;
                        ataskaita.Add(reportItem);
                    }
                    
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
