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
    public partial class DienosPardavimuAtaskaita : Form
    {
        private CekiuRepozitorija _cekiuRepozitorija;
        public DienosPardavimuAtaskaita()
        {
            InitializeComponent();
        }

        public DienosPardavimuAtaskaita(CekiuRepozitorija cekiuRepozitorija) : this()
        {
            _cekiuRepozitorija = cekiuRepozitorija;
        }
        decimal cekiuSuma = 0;
        private void DienosPardavimuAtaskaita_Load(object sender, EventArgs e)
        {
            var ataskaitosGeneravimas = new ParduotuPrekiuAtaskaita( _cekiuRepozitorija);
            var report = ataskaitosGeneravimas.GenerateReportReceipt();
            if (report != null)
            {
                foreach (var elem in report)
                {
                    lbxCekioAtaskaita.Items.Add(DateTime.Now.ToString());
                    lbxCekioAtaskaita.Items.Add(string.Format(elem.PrekesPavadinimas + ", kodas: " + elem.Kodas + ", kaina " + elem.PrekesKaina + " eur "));
                    cekiuSuma = cekiuSuma + elem.PrekesKaina;
                }
            }
            tbxCekiuSuma.Text = cekiuSuma.ToString();
        }
    }
}
