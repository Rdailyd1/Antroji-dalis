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
    public partial class PradinioLangoForma : Form
    {
        public static CekiuRepozitorija _cekiuRepozitorija;
        public static PrekiuRepozitorija _prekiuRepozitorija;
        public PradinioLangoForma(PrekiuRepozitorija prekiuRepozitorija, CekiuRepozitorija cekiuRepozitorija) : this()
        {
            if (_cekiuRepozitorija == null)
            {
                _cekiuRepozitorija = cekiuRepozitorija;
            }
            if (_prekiuRepozitorija == null)
            {
                _prekiuRepozitorija = prekiuRepozitorija;
            }
        }
        public PradinioLangoForma()
        {
            InitializeComponent();
           
        }
       

        private void btnKlasifikatorius_Click(object sender, EventArgs e)
        {
            lblPavadinimas.Visible = true;
            cmbPrekes.Visible = true;
            lblKodas.Visible = false;
            txb_skenavimas.Visible = false;
        }

        private void btnPrekiuPridejimas_Click(object sender, EventArgs e)
        {
            PrekesPridejimoForma prekesPridejimas = new PrekesPridejimoForma(_prekiuRepozitorija);
            prekesPridejimas.Show();
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void PradinioLangoForma_Load(object sender, EventArgs e)
        {
            lblprekiuSkaicius.Text = "";
            var perkamosPrekes = _prekiuRepozitorija.Retrieve();
            foreach (var elem in perkamosPrekes)
            {
                cmbPrekes.Items.Add(string.Format(elem.PrekesPavadinimas));
            }
            _cekiuRepozitorija.PradetiNaujaCeki();
        }
        private void btnPrekiuRedagavimas_Click(object sender, EventArgs e)
        {
            PrekiuRedagavimas prekiuredagavimas = new PrekiuRedagavimas();
            prekiuredagavimas.Show();
        }

        private void btnTrynimas_Click(object sender, EventArgs e)
        {
            PrekiuTrynimas prekiutrynimas = new PrekiuTrynimas();
            prekiutrynimas.Show();
        }

        private void Krepselis_btn_Click(object sender, EventArgs e)
        {
            KrepselioForma krepselis = new KrepselioForma();
            krepselis.Show();
        }
        public decimal cekioSuma;
        private void Patvirtinti_btn_Click(object sender, EventArgs e)
        {
            prekenuskenuota_lbl.Visible = true;
            lbxPerkamuPrekiuSarasas.Items.Clear();
            decimal cekioPrekesKaina = 0;
            var perkamosPrekes = _prekiuRepozitorija.Retrieve();
            int prekesIndeksas = -1;
            int n = 0;
            if (cmbPrekes.SelectedIndex >= 0)
            {
                prekesIndeksas = cmbPrekes.SelectedIndex + 1;
                string cekioPrekesPavadinimas = perkamosPrekes.Where(x => x.ID == prekesIndeksas).FirstOrDefault().PrekesPavadinimas;
                string prekesKodas = perkamosPrekes.Where(x => x.ID == prekesIndeksas).FirstOrDefault().Kodas;
                cekioPrekesKaina = perkamosPrekes.Where(x => x.ID == prekesIndeksas).FirstOrDefault().PrekesKaina;
                _cekiuRepozitorija.IdejimasIKrepseli(prekesIndeksas, prekesKodas, cekioPrekesPavadinimas, cekioPrekesKaina);
                var cekioPrekes = _cekiuRepozitorija.Retrieve();
                n = 1;
                foreach (var elementas in cekioPrekes)
                {
                    lbxPerkamuPrekiuSarasas.Items.Add(elementas.PrekesPavadinimas + " " + elementas.VienetoKaina);
                    lblprekiuSkaicius.Text = _cekiuRepozitorija.Retrieve().Count.ToString();
                }
            }

            if (perkamosPrekes.Where(x=>x.Kodas == txb_skenavimas.Text).Count()>0)
            {
                string cekioPrekesPavadinimas = perkamosPrekes.Where(x => x.Kodas == txb_skenavimas.Text).FirstOrDefault().PrekesPavadinimas;
                int id = perkamosPrekes.Where(x => x.Kodas == txb_skenavimas.Text).FirstOrDefault().ID;
                string prekesKodas = perkamosPrekes.Where(x => x.Kodas == txb_skenavimas.Text).FirstOrDefault().Kodas;
                cekioPrekesKaina = perkamosPrekes.Where(x => x.Kodas == txb_skenavimas.Text).FirstOrDefault().PrekesKaina;
                _cekiuRepozitorija.IdejimasIKrepseli(id, prekesKodas, cekioPrekesPavadinimas, cekioPrekesKaina);
                var cekioPrekes = _cekiuRepozitorija.Retrieve();
                lbxPerkamuPrekiuSarasas.Items.Clear();
                foreach (var elementas in cekioPrekes)
                {
                    
                    lbxPerkamuPrekiuSarasas.Items.Add(elementas.PrekesPavadinimas + " " + elementas.VienetoKaina);
                    lblprekiuSkaicius.Text = _cekiuRepozitorija.Retrieve().Count.ToString();
                }
                
            }
            else if (n==0)
            {
                MessageBox.Show("Nėra tokios prekės");
            }
            txb_skenavimas.Clear();
            cekioSuma = cekioSuma + cekioPrekesKaina;
            tbxSuma.Text = cekioSuma.ToString();
        }

        private void Skenavimas_txb_TextChanged(object sender, EventArgs e)
        {
            prekenuskenuota_lbl.Visible = false;
        }

        private void BtnApmoketi_Click(object sender, EventArgs e)
        {
            lblIdekitePinigus.Visible = true;
            txbApmokejimas.Visible = true;
            btnIdeti.Visible = true;
            _cekiuRepozitorija.UzbaigtiEinamaCeki();
            _cekiuRepozitorija.PradetiNaujaCeki();
        }

        private void BtnIdeti_Click(object sender, EventArgs e)
        {
            decimal graza = Convert.ToDecimal(txbApmokejimas.Text) - cekioSuma;
            MessageBox.Show("Apmokėjimas įvykdytas, sumokėta: " + txbApmokejimas.Text + " eur, " + "grąža " + graza.ToString() + " eur");
            LblIsvalyti_Click(sender,e);
            txbApmokejimas.Clear();
            lblIdekitePinigus.Visible = false;
            txbApmokejimas.Visible = false;
            btnIdeti.Visible = false;
        }

        private void LblIsvalyti_Click(object sender, EventArgs e)
        {
            _cekiuRepozitorija.Trinti();
            lbxPerkamuPrekiuSarasas.Items.Clear();
            cekioSuma = 0;
            lblprekiuSkaicius.Text = _cekiuRepozitorija.Retrieve().Count.ToString();
            tbxSuma.Text = "";
            cmbPrekes.SelectedIndex = -1;
        }

        private void CmbPrekes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPrekes.Items.Clear();
            var perkamosPrekes = _prekiuRepozitorija.Retrieve();
            foreach (var elem in perkamosPrekes)
            {
                cmbPrekes.Items.Add(string.Format(elem.PrekesPavadinimas));
            }
           
        }

        private void BtnIvestiKoda_Click(object sender, EventArgs e)
        {
            lblPavadinimas.Visible = false;
            cmbPrekes.Visible = false;
            lblKodas.Visible = true;
            txb_skenavimas.Visible = true;
            cmbPrekes.SelectedIndex = -1;
        }

        private void BtnCekiuAtaskaita_Click(object sender, EventArgs e)
        {
            DienosPardavimuAtaskaita ataskaitosForma = new DienosPardavimuAtaskaita(_cekiuRepozitorija);
            ataskaitosForma.Show();
        }

        private void BtnCekis_Click(object sender, EventArgs e)
        {
            CekioForma cekioForma = new CekioForma(_cekiuRepozitorija);
            cekioForma.Show();
        }
    }
}
