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
    public partial class PrekesPridejimoForma : Form
    {
        private PrekiuRepozitorija _prekiuRepozitorija;
        public PrekesPridejimoForma()
        {
            InitializeComponent();
        }

        public PrekesPridejimoForma(PrekiuRepozitorija prekiuRepozitorija) : this()
        {
            _prekiuRepozitorija = prekiuRepozitorija;
        }
        
        private void PrekesIrasymas_Click(object sender, EventArgs e)
        {
            string prekesPavadinimas = prekesPavadinimas_txb.Text;
            string prekesKodas = prekesKodas_txb.Text;
            decimal prekesVienetoKaina = Convert.ToDecimal(vienetoKaina_txb.Text);
            _prekiuRepozitorija.PrekiuPridejimas(prekesPavadinimas, prekesKodas, prekesVienetoKaina);
            
            List<Preke>prekiuRinkinys = _prekiuRepozitorija.Retrieve();

            lbxPrekiuSarasas.Items.Clear();
            foreach (var elementas in prekiuRinkinys)
            {
                lbxPrekiuSarasas.Items.Add("ID:" + elementas.ID + ", " + elementas.PrekesPavadinimas + ", Kodas:" + elementas.Kodas + ", Kaina: " + elementas.PrekesKaina);
            }
            prekesPavadinimas_txb.Clear();
            prekesKodas_txb.Clear();
            vienetoKaina_txb.Clear();

        }

        private void PrekesPridejimoForma_Load(object sender, EventArgs e)
        {
            List<Preke> prekiuRinkinys = _prekiuRepozitorija.Retrieve();
            foreach (var elementas in prekiuRinkinys)
            {
                
                lbxPrekiuSarasas.Items.Add("ID:" + elementas.ID + ", " + elementas.PrekesPavadinimas + ", Kodas:" + elementas.Kodas + ", Kaina: " + elementas.PrekesKaina);
            }
        }

        private void LbxPrekiuSarasas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxPrekiuSarasas.SelectedIndex > -1)
            {
                _prekiuRepozitorija.PrekiuTrynimas(lbxPrekiuSarasas.SelectedIndex);
            }
            for (int i = 0; i < lbxPrekiuSarasas.SelectedItems.Count; i++)
            {
                var confirmResult = MessageBox.Show("Ar tikrai norite ištrinti prekę?","", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    lbxPrekiuSarasas.Items.Remove(lbxPrekiuSarasas.SelectedItems[i]);
                }
               
            }
            
        }
    }
}
