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
    public partial class CekioForma : Form
    {
        private CekiuRepozitorija _cekiuRepozitorija;
        public CekioForma()
        {
            InitializeComponent();
        }
        public CekioForma(CekiuRepozitorija cekiuRepozitorija, bool krepselis) : this()
        {
            _cekiuRepozitorija = cekiuRepozitorija;
            if (krepselis == true)
            {
                lblPirkimoCekis.Text = "Pirkinių krepšelis";
            }
        }
        decimal cekioSuma = 0;
        private void CekioForma_Load(object sender, EventArgs e)
        {
            var ataskaitosGeneravimas = new CekioPrekiuAtaskaita(_cekiuRepozitorija);
            List<ReportItem> report;
            if (_cekiuRepozitorija.Retrieve().Count == 0)
            {
                report = ataskaitosGeneravimas.GenerateLastChecqueReport();
            }
            else
            {
                report = ataskaitosGeneravimas.GenerateCurrentChecqueReport();
            }
            if (report != null)
            {
                lbxCekis.Items.Add(DateTime.Now.ToString());
                lbxCekis.Items.Add("");
                foreach (var elem in report)
                {
                    lbxCekis.Items.Add(string.Format(elem.PrekesPavadinimas + "; kodas " + elem.Kodas + "; kaina " + elem.PrekesKaina + " eur "));
                    cekioSuma = cekioSuma + elem.PrekesKaina;
                }
            }
            tbxCekioSuma.Text = cekioSuma.ToString();
        }
    }
}