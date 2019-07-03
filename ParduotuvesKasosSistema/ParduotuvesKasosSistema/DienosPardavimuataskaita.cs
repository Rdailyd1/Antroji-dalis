using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParduotuvesKasosSistemaBL;

namespace ParduotuvesKasosSistema
{
    public partial class PardavimuAtaskaita : Form
    {
        private CekiuRepozitorija _cekiuRepozitorija;
        public PardavimuAtaskaita()
        {
            InitializeComponent();
        }

        public PardavimuAtaskaita(CekiuRepozitorija cekiuRepozitorija) : this()
        {
            _cekiuRepozitorija = cekiuRepozitorija;
        }
        decimal cekiuSuma = 0;
        public void DienosPardavimuAtaskaita_Load(object sender, EventArgs e)
        {
            var ataskaitosGeneravimas = new ParduotuPrekiuAtaskaita( _cekiuRepozitorija);
            var report = ataskaitosGeneravimas.GenerateReportReceipt();
            if (report != null)
            {
                lbxCekioAtaskaita.Items.Add("Ataskaitos data: " + DateTime.Now.ToString("yyyy-MM-dd"));
                lbxCekioAtaskaita.Items.Add("");
                foreach (var elem in report)
                {
                    lbxCekioAtaskaita.Items.Add(string.Format(elem.PrekesPavadinimas + "; kodas " + elem.Kodas + "; kaina " + elem.PrekesKaina + " eur "));
                    cekiuSuma = cekiuSuma + elem.PrekesKaina;
                }
            }
            tbxCekiuSuma.Text = cekiuSuma.ToString();
     
        }

        private void LblAtsisiustiAtaskaita_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            const string sPath = @"C:\Users\rdail\Documents\NET kursai\Antroji-dalis\Ataskaita\PardavimuAtaskaita.txt";
            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
            foreach (var item in lbxCekioAtaskaita.Items)
            {
                SaveFile.WriteLine(item);
            }

            SaveFile.Close();
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook sablonas = excel.Workbooks.Open(@"C:\Users\rdail\Documents\NET kursai\Antroji-dalis\Ataskaita\PardavimuAtaskaita.xlsx", 0, true);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = sablonas.ActiveSheet;

            worksheet.Name = "Ataskaita";

            excel.Visible = true;
            int i = 3;
            worksheet.Cells[1, 1] = "Pardavimų ataskaita";
            foreach (var item in lbxCekioAtaskaita.Items)
            {
                worksheet.Cells[i, 1] = item;
                i++;
            }
            worksheet.Cells[i+1, 1] = "Suma, eur";
            worksheet.Cells[i+1, 2] = tbxCekiuSuma.Text;
        }
    }
}
