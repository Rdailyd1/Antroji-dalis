using ParduotuvesKasosSistemaBL;

namespace ParduotuvesKasosSistema
{
    partial class PradinioLangoForma
    {
        private PrekiuRepozitorija prekiuRepozitorija = new PrekiuRepozitorija();
        private CekiuRepozitorija cekiuRepozitorija = new CekiuRepozitorija();
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKlasifikatorius = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_skenavimas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.prekesPridejimas = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.patvirtinti_btn = new System.Windows.Forms.Button();
            this.krepselis_btn = new System.Windows.Forms.Button();
            this.prekenuskenuota_lbl = new System.Windows.Forms.Label();
            this.lbxPerkamuPrekiuSarasas = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxSuma = new System.Windows.Forms.TextBox();
            this.lblSuma = new System.Windows.Forms.Label();
            this.lblprekiuSkaicius = new System.Windows.Forms.Label();
            this.btnApmoketi = new System.Windows.Forms.Button();
            this.btnCekioAtaskaita = new System.Windows.Forms.Button();
            this.txbApmokejimas = new System.Windows.Forms.TextBox();
            this.lblIdekitePinigus = new System.Windows.Forms.Label();
            this.btnIdeti = new System.Windows.Forms.Button();
            this.lblIsvalyti = new System.Windows.Forms.Label();
            this.cmbPrekes = new System.Windows.Forms.ComboBox();
            this.lblPavadinimas = new System.Windows.Forms.Label();
            this.lblKodas = new System.Windows.Forms.Label();
            this.btnIvestiKoda = new System.Windows.Forms.Button();
            this.btnCekis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKlasifikatorius
            // 
            this.btnKlasifikatorius.Location = new System.Drawing.Point(198, 112);
            this.btnKlasifikatorius.Name = "btnKlasifikatorius";
            this.btnKlasifikatorius.Size = new System.Drawing.Size(115, 34);
            this.btnKlasifikatorius.TabIndex = 0;
            this.btnKlasifikatorius.Text = "Pasirinkti iš klasifikatoriaus";
            this.btnKlasifikatorius.UseVisualStyleBackColor = true;
            this.btnKlasifikatorius.Click += new System.EventHandler(this.btnKlasifikatorius_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(194, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prekių pardavimo sistema";
            // 
            // txb_skenavimas
            // 
            this.txb_skenavimas.Location = new System.Drawing.Point(359, 178);
            this.txb_skenavimas.Name = "txb_skenavimas";
            this.txb_skenavimas.Size = new System.Drawing.Size(88, 20);
            this.txb_skenavimas.TabIndex = 3;
            this.txb_skenavimas.Visible = false;
            this.txb_skenavimas.TextChanged += new System.EventHandler(this.Skenavimas_txb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Įveskite prekės kodą arba pasirinkite prekę iš klasifikatoriaus pagal pavadinimą";
            // 
            // prekesPridejimas
            // 
            this.prekesPridejimas.Location = new System.Drawing.Point(198, 237);
            this.prekesPridejimas.Name = "prekesPridejimas";
            this.prekesPridejimas.Size = new System.Drawing.Size(115, 47);
            this.prekesPridejimas.TabIndex = 5;
            this.prekesPridejimas.Text = "Prekių pridėjimas/trynimas";
            this.prekesPridejimas.UseVisualStyleBackColor = true;
            this.prekesPridejimas.Click += new System.EventHandler(this.btnPrekiuPridejimas_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // patvirtinti_btn
            // 
            this.patvirtinti_btn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.patvirtinti_btn.Location = new System.Drawing.Point(469, 173);
            this.patvirtinti_btn.Name = "patvirtinti_btn";
            this.patvirtinti_btn.Size = new System.Drawing.Size(65, 29);
            this.patvirtinti_btn.TabIndex = 8;
            this.patvirtinti_btn.Text = "Patvirtinti";
            this.patvirtinti_btn.UseVisualStyleBackColor = false;
            this.patvirtinti_btn.Click += new System.EventHandler(this.Patvirtinti_btn_Click);
            // 
            // krepselis_btn
            // 
            this.krepselis_btn.BackColor = System.Drawing.Color.White;
            this.krepselis_btn.Image = global::ParduotuvesKasosSistema.Properties.Resources.krepselis1;
            this.krepselis_btn.Location = new System.Drawing.Point(717, 76);
            this.krepselis_btn.Name = "krepselis_btn";
            this.krepselis_btn.Size = new System.Drawing.Size(41, 38);
            this.krepselis_btn.TabIndex = 2;
            this.krepselis_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.krepselis_btn.UseVisualStyleBackColor = false;
            this.krepselis_btn.Click += new System.EventHandler(this.Krepselis_btn_Click);
            // 
            // prekenuskenuota_lbl
            // 
            this.prekenuskenuota_lbl.AutoSize = true;
            this.prekenuskenuota_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.prekenuskenuota_lbl.ForeColor = System.Drawing.Color.Green;
            this.prekenuskenuota_lbl.Location = new System.Drawing.Point(202, 202);
            this.prekenuskenuota_lbl.Name = "prekenuskenuota_lbl";
            this.prekenuskenuota_lbl.Size = new System.Drawing.Size(139, 17);
            this.prekenuskenuota_lbl.TabIndex = 9;
            this.prekenuskenuota_lbl.Text = "Prekė nuskenuota";
            this.prekenuskenuota_lbl.Visible = false;
            // 
            // lbxPerkamuPrekiuSarasas
            // 
            this.lbxPerkamuPrekiuSarasas.FormattingEnabled = true;
            this.lbxPerkamuPrekiuSarasas.HorizontalScrollbar = true;
            this.lbxPerkamuPrekiuSarasas.Location = new System.Drawing.Point(567, 141);
            this.lbxPerkamuPrekiuSarasas.Name = "lbxPerkamuPrekiuSarasas";
            this.lbxPerkamuPrekiuSarasas.ScrollAlwaysVisible = true;
            this.lbxPerkamuPrekiuSarasas.Size = new System.Drawing.Size(207, 238);
            this.lbxPerkamuPrekiuSarasas.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(567, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Prekių krepšelis";
            // 
            // tbxSuma
            // 
            this.tbxSuma.Location = new System.Drawing.Point(628, 386);
            this.tbxSuma.Name = "tbxSuma";
            this.tbxSuma.Size = new System.Drawing.Size(146, 20);
            this.tbxSuma.TabIndex = 20;
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblSuma.Location = new System.Drawing.Point(558, 389);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(64, 13);
            this.lblSuma.TabIndex = 21;
            this.lblSuma.Text = "Suma, eur";
            // 
            // lblprekiuSkaicius
            // 
            this.lblprekiuSkaicius.AutoSize = true;
            this.lblprekiuSkaicius.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblprekiuSkaicius.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblprekiuSkaicius.Location = new System.Drawing.Point(757, 76);
            this.lblprekiuSkaicius.Name = "lblprekiuSkaicius";
            this.lblprekiuSkaicius.Size = new System.Drawing.Size(17, 17);
            this.lblprekiuSkaicius.TabIndex = 22;
            this.lblprekiuSkaicius.Text = "0";
            // 
            // btnApmoketi
            // 
            this.btnApmoketi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnApmoketi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnApmoketi.Location = new System.Drawing.Point(358, 386);
            this.btnApmoketi.Name = "btnApmoketi";
            this.btnApmoketi.Size = new System.Drawing.Size(115, 29);
            this.btnApmoketi.TabIndex = 23;
            this.btnApmoketi.Text = "Apmokėti";
            this.btnApmoketi.UseVisualStyleBackColor = false;
            this.btnApmoketi.Click += new System.EventHandler(this.BtnApmoketi_Click);
            // 
            // btnCekioAtaskaita
            // 
            this.btnCekioAtaskaita.Location = new System.Drawing.Point(440, 237);
            this.btnCekioAtaskaita.Name = "btnCekioAtaskaita";
            this.btnCekioAtaskaita.Size = new System.Drawing.Size(115, 47);
            this.btnCekioAtaskaita.TabIndex = 24;
            this.btnCekioAtaskaita.Text = "Dienos pardavimų ataskaita";
            this.btnCekioAtaskaita.UseVisualStyleBackColor = true;
            this.btnCekioAtaskaita.Click += new System.EventHandler(this.BtnCekiuAtaskaita_Click);
            // 
            // txbApmokejimas
            // 
            this.txbApmokejimas.Location = new System.Drawing.Point(358, 444);
            this.txbApmokejimas.Name = "txbApmokejimas";
            this.txbApmokejimas.Size = new System.Drawing.Size(153, 20);
            this.txbApmokejimas.TabIndex = 25;
            this.txbApmokejimas.Visible = false;
            // 
            // lblIdekitePinigus
            // 
            this.lblIdekitePinigus.AutoSize = true;
            this.lblIdekitePinigus.Location = new System.Drawing.Point(355, 428);
            this.lblIdekitePinigus.Name = "lblIdekitePinigus";
            this.lblIdekitePinigus.Size = new System.Drawing.Size(73, 13);
            this.lblIdekitePinigus.TabIndex = 26;
            this.lblIdekitePinigus.Text = "Įdėkite pingus";
            this.lblIdekitePinigus.Visible = false;
            // 
            // btnIdeti
            // 
            this.btnIdeti.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnIdeti.Location = new System.Drawing.Point(517, 438);
            this.btnIdeti.Name = "btnIdeti";
            this.btnIdeti.Size = new System.Drawing.Size(40, 30);
            this.btnIdeti.TabIndex = 27;
            this.btnIdeti.Text = "Įdėti";
            this.btnIdeti.UseVisualStyleBackColor = false;
            this.btnIdeti.Visible = false;
            this.btnIdeti.Click += new System.EventHandler(this.BtnIdeti_Click);
            // 
            // lblIsvalyti
            // 
            this.lblIsvalyti.AutoSize = true;
            this.lblIsvalyti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblIsvalyti.Location = new System.Drawing.Point(717, 121);
            this.lblIsvalyti.Name = "lblIsvalyti";
            this.lblIsvalyti.Size = new System.Drawing.Size(39, 13);
            this.lblIsvalyti.TabIndex = 28;
            this.lblIsvalyti.Text = "Išvalyti";
            this.lblIsvalyti.Click += new System.EventHandler(this.LblIsvalyti_Click);
            // 
            // cmbPrekes
            // 
            this.cmbPrekes.FormattingEnabled = true;
            this.cmbPrekes.Location = new System.Drawing.Point(205, 177);
            this.cmbPrekes.Name = "cmbPrekes";
            this.cmbPrekes.Size = new System.Drawing.Size(96, 21);
            this.cmbPrekes.TabIndex = 29;
            this.cmbPrekes.Visible = false;
            this.cmbPrekes.Click += new System.EventHandler(this.CmbPrekes_SelectedIndexChanged);
            // 
            // lblPavadinimas
            // 
            this.lblPavadinimas.AutoSize = true;
            this.lblPavadinimas.Location = new System.Drawing.Point(215, 162);
            this.lblPavadinimas.Name = "lblPavadinimas";
            this.lblPavadinimas.Size = new System.Drawing.Size(67, 13);
            this.lblPavadinimas.TabIndex = 30;
            this.lblPavadinimas.Text = "Pavadinimas";
            this.lblPavadinimas.Visible = false;
            // 
            // lblKodas
            // 
            this.lblKodas.AutoSize = true;
            this.lblKodas.Location = new System.Drawing.Point(380, 162);
            this.lblKodas.Name = "lblKodas";
            this.lblKodas.Size = new System.Drawing.Size(37, 13);
            this.lblKodas.TabIndex = 31;
            this.lblKodas.Text = "Kodas";
            this.lblKodas.Visible = false;
            // 
            // btnIvestiKoda
            // 
            this.btnIvestiKoda.Location = new System.Drawing.Point(358, 116);
            this.btnIvestiKoda.Name = "btnIvestiKoda";
            this.btnIvestiKoda.Size = new System.Drawing.Size(115, 30);
            this.btnIvestiKoda.TabIndex = 32;
            this.btnIvestiKoda.Text = "Įveskite kodą";
            this.btnIvestiKoda.UseVisualStyleBackColor = true;
            this.btnIvestiKoda.Click += new System.EventHandler(this.BtnIvestiKoda_Click);
            // 
            // btnCekis
            // 
            this.btnCekis.Location = new System.Drawing.Point(319, 237);
            this.btnCekis.Name = "btnCekis";
            this.btnCekis.Size = new System.Drawing.Size(115, 47);
            this.btnCekis.TabIndex = 33;
            this.btnCekis.Text = "Čekis";
            this.btnCekis.UseVisualStyleBackColor = true;
            this.btnCekis.Click += new System.EventHandler(this.BtnCekis_Click);
            // 
            // PradinioLangoForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(997, 561);
            this.Controls.Add(this.btnCekis);
            this.Controls.Add(this.btnIvestiKoda);
            this.Controls.Add(this.lblKodas);
            this.Controls.Add(this.lblPavadinimas);
            this.Controls.Add(this.cmbPrekes);
            this.Controls.Add(this.lblIsvalyti);
            this.Controls.Add(this.btnIdeti);
            this.Controls.Add(this.lblIdekitePinigus);
            this.Controls.Add(this.txbApmokejimas);
            this.Controls.Add(this.btnCekioAtaskaita);
            this.Controls.Add(this.btnApmoketi);
            this.Controls.Add(this.lblprekiuSkaicius);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.tbxSuma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbxPerkamuPrekiuSarasas);
            this.Controls.Add(this.prekenuskenuota_lbl);
            this.Controls.Add(this.patvirtinti_btn);
            this.Controls.Add(this.prekesPridejimas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_skenavimas);
            this.Controls.Add(this.krepselis_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKlasifikatorius);
            this.Name = "PradinioLangoForma";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pradinis langas";
            this.Load += new System.EventHandler(this.PradinioLangoForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKlasifikatorius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button krepselis_btn;
        private System.Windows.Forms.TextBox txb_skenavimas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button prekesPridejimas;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button patvirtinti_btn;
        private System.Windows.Forms.Label prekenuskenuota_lbl;
        private System.Windows.Forms.ListBox lbxPerkamuPrekiuSarasas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxSuma;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label lblprekiuSkaicius;
        private System.Windows.Forms.Button btnApmoketi;
        private System.Windows.Forms.Button btnCekioAtaskaita;
        private System.Windows.Forms.TextBox txbApmokejimas;
        private System.Windows.Forms.Label lblIdekitePinigus;
        private System.Windows.Forms.Button btnIdeti;
        private System.Windows.Forms.Label lblIsvalyti;
        private System.Windows.Forms.ComboBox cmbPrekes;
        private System.Windows.Forms.Label lblPavadinimas;
        private System.Windows.Forms.Label lblKodas;
        private System.Windows.Forms.Button btnIvestiKoda;
        private System.Windows.Forms.Button btnCekis;
    }
}

