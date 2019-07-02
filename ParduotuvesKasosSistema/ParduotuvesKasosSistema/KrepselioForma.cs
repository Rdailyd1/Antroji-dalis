using ParduotuvesKasosSistemaBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParduotuvesKasosSistema
{
    public partial class KrepselioForma : Form
    {
        private CekiuRepozitorija _cekiuRepozitorija;
        public KrepselioForma(CekiuRepozitorija cekiuRepozitorija) : this()
        {
            _cekiuRepozitorija = cekiuRepozitorija;
        }
        
        public KrepselioForma()
        {
            InitializeComponent();
        }
       
        private void LbxCekioSarasas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void KrepselioForma_Load_1(object sender, EventArgs e)
        {

            var cekioPrekes = _cekiuRepozitorija.Retrieve();
            foreach (var elementas in cekioPrekes)
            {

                lbxKrepselioSarasas.Items.Add("ID:" + elementas.CekioID + ", " + elementas.PrekesPavadinimas + ", Kodas:" + elementas.PrekesKodas + ", Kaina: " + elementas.VienetoKaina);
            }
           
        }
    }
}
