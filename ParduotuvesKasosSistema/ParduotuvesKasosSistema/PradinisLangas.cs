﻿using ParduotuvesKasosSistemaBL;
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


        private void BtnKlasifikatorius_Click(object sender, EventArgs e)
        {
            lblPavadinimas.Visible = true;
            cmbPrekes.Visible = true;
            nmKiekis.Visible = true;
            lblKiekis.Visible = true;
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
            nmKiekis.Value = 1;
            var perkamosPrekes = _prekiuRepozitorija.Retrieve();
            foreach (var elem in perkamosPrekes)
            {
                cmbPrekes.Items.Add(string.Format(elem.PrekesPavadinimas));
            }
            _cekiuRepozitorija.PradetiNaujaCeki();
        }
      
        private void Krepselis_btn_Click(object sender, EventArgs e)
        {
            if (lblprekiuSkaicius.Text == "0")
            {
                MessageBox.Show("Pirkinių krepšelis tuščias");
            }
            else
            {
                bool krepselis = true;
                CekioForma cekioForma = new CekioForma(_cekiuRepozitorija, krepselis);
                cekioForma.Show();
            }
        }
        public decimal cekioSuma;
        private void Patvirtinti_btn_Click(object sender, EventArgs e)
        {
            prekenuskenuota_lbl.Visible = true;
            lblCekioPrekTrynimas.Visible = true;
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
                for (int i = 0; i < nmKiekis.Value; i++)
                {
                    _cekiuRepozitorija.IdejimasIKrepseli(prekesIndeksas, prekesKodas, cekioPrekesPavadinimas, cekioPrekesKaina);
                }
                nmKiekis.Value = 1;
                var cekioPrekes = _cekiuRepozitorija.Retrieve();
                n = 1;
                foreach (var elementas in cekioPrekes)
                {
                    lbxPerkamuPrekiuSarasas.Items.Add(elementas.PrekesPavadinimas + " " + elementas.VienetoKaina);
                    lblprekiuSkaicius.Text = cekioPrekes.Count.ToString();
                }
            }

            if (perkamosPrekes.Where(x=>x.Kodas == txb_skenavimas.Text).Count() > 0)
            {
                prekenuskenuota_lbl.Visible = true;
                string cekioPrekesPavadinimas = perkamosPrekes.Where(x => x.Kodas == txb_skenavimas.Text).FirstOrDefault().PrekesPavadinimas;
                int id = perkamosPrekes.Where(x => x.Kodas == txb_skenavimas.Text).FirstOrDefault().ID;
                string prekesKodas = perkamosPrekes.Where(x => x.Kodas == txb_skenavimas.Text).FirstOrDefault().Kodas;
                cekioPrekesKaina = perkamosPrekes.Where(x => x.Kodas == txb_skenavimas.Text).FirstOrDefault().PrekesKaina;
                for (int i = 0; i < nmKiekis.Value; i++)
                {
                    _cekiuRepozitorija.IdejimasIKrepseli(id, prekesKodas, cekioPrekesPavadinimas, cekioPrekesKaina);
                }
                nmKiekis.Value = 1;
                var cekioPrekes = _cekiuRepozitorija.Retrieve();
                lbxPerkamuPrekiuSarasas.Items.Clear();
                foreach (var elementas in cekioPrekes)
                {
                    lbxPerkamuPrekiuSarasas.Items.Add(elementas.PrekesPavadinimas + " " + elementas.VienetoKaina);
                    lblprekiuSkaicius.Text = cekioPrekes.Count.ToString();
                }
                
            }
            else if (n==0)
            {
                var cekioPrekes = _cekiuRepozitorija.Retrieve();
                foreach (var elementas in cekioPrekes)
                {
                    lbxPerkamuPrekiuSarasas.Items.Add(elementas.PrekesPavadinimas + " " + elementas.VienetoKaina);
                    lblprekiuSkaicius.Text = cekioPrekes.Count.ToString();
                }
                MessageBox.Show("Nėra tokios prekės");
            }
            txb_skenavimas.Clear();
            var cekioElemSarasas = _cekiuRepozitorija.Retrieve();
            decimal cekSuma = 0;
                    foreach (var elementas in cekioElemSarasas)
                    {
                        cekSuma = cekSuma + elementas.VienetoKaina;
                        
                    }
                    tbxSuma.Text = cekSuma.ToString();
            cmbPrekes.SelectedIndex = -1;
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
            decimal cekSuma = Convert.ToDecimal(tbxSuma.Text);
            decimal graza = Convert.ToDecimal(txbApmokejimas.Text) - cekSuma;
            MessageBox.Show("Apmokėjimas įvykdytas, sumokėta: " + txbApmokejimas.Text + " eur, " + "grąža " + graza.ToString() + " eur");
            LblIsvalyti_Click(sender,e);
            txbApmokejimas.Clear();
            lblIdekitePinigus.Visible = false;
            txbApmokejimas.Visible = false;
            btnIdeti.Visible = false;
            prekenuskenuota_lbl.Visible = false;
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
            prekenuskenuota_lbl.Visible = false;
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
            nmKiekis.Visible = true;
            lblKiekis.Visible = true;
            cmbPrekes.SelectedIndex = -1;
        }

        private void BtnPardavimuAtaskaita_Click(object sender, EventArgs e)
        {
            PardavimuAtaskaita ataskaitosForma = new PardavimuAtaskaita(_cekiuRepozitorija);
            ataskaitosForma.Show();
        }

        private void BtnCekis_Click(object sender, EventArgs e)
        {
            bool krepselis = false;
            CekioForma cekioForma = new CekioForma(_cekiuRepozitorija, krepselis);
            cekioForma.Show();
        }

        private void LbxPerkamuPrekiuSarasas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxPerkamuPrekiuSarasas.SelectedIndex > -1)
            {
                _cekiuRepozitorija.PrekiuTrynimas(lbxPerkamuPrekiuSarasas.SelectedIndex);
            }
            for (int i = 0; i < lbxPerkamuPrekiuSarasas.SelectedItems.Count; i++)
            {
                var confirmResult = MessageBox.Show("Ar tikrai norite ištrinti prekę?", "", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    lbxPerkamuPrekiuSarasas.Items.Remove(lbxPerkamuPrekiuSarasas.SelectedItems[i]);
                    var cekioElemSarasas = _cekiuRepozitorija.Retrieve();
                    decimal cekSuma = 0;
                    foreach (var elementas in cekioElemSarasas)
                    {
                        cekSuma = cekSuma + elementas.VienetoKaina;
                    }
                    tbxSuma.Text = cekSuma.ToString();
                    lblprekiuSkaicius.Text = cekioElemSarasas.Count.ToString();
                    if (cekioElemSarasas.Count == 0)
                    {
                        lblCekioPrekTrynimas.Visible = false;
                    }
                }

            }
        }

    }
}
