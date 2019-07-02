using ParduotuvesKasosSistemaBL;

namespace ParduotuvesKasosSistema
{
    partial class KrepselioForma
    {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblkrepselioSuma = new System.Windows.Forms.Label();
            this.tbxSuma = new System.Windows.Forms.TextBox();
            this.lbxKrepselioSarasas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(260, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Krepšelio prekių sąrašas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prekės pavadinimas, kiekis, kaina";
            // 
            // lblkrepselioSuma
            // 
            this.lblkrepselioSuma.AutoSize = true;
            this.lblkrepselioSuma.Location = new System.Drawing.Point(129, 317);
            this.lblkrepselioSuma.Name = "lblkrepselioSuma";
            this.lblkrepselioSuma.Size = new System.Drawing.Size(99, 13);
            this.lblkrepselioSuma.TabIndex = 5;
            this.lblkrepselioSuma.Text = "Krepšelio suma, eur";
            // 
            // tbxSuma
            // 
            this.tbxSuma.Location = new System.Drawing.Point(132, 333);
            this.tbxSuma.Name = "tbxSuma";
            this.tbxSuma.Size = new System.Drawing.Size(100, 20);
            this.tbxSuma.TabIndex = 6;
            // 
            // lbxKrepselioSarasas
            // 
            this.lbxKrepselioSarasas.FormattingEnabled = true;
            this.lbxKrepselioSarasas.HorizontalScrollbar = true;
            this.lbxKrepselioSarasas.Location = new System.Drawing.Point(132, 104);
            this.lbxKrepselioSarasas.Name = "lbxKrepselioSarasas";
            this.lbxKrepselioSarasas.ScrollAlwaysVisible = true;
            this.lbxKrepselioSarasas.Size = new System.Drawing.Size(183, 212);
            this.lbxKrepselioSarasas.TabIndex = 18;
            this.lbxKrepselioSarasas.SelectedIndexChanged += new System.EventHandler(this.LbxCekioSarasas_SelectedIndexChanged);
            // 
            // KrepselioForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxKrepselioSarasas);
            this.Controls.Add(this.tbxSuma);
            this.Controls.Add(this.lblkrepselioSuma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KrepselioForma";
            this.Text = "KrepselioForma";
            this.Load += new System.EventHandler(this.KrepselioForma_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblkrepselioSuma;
        private System.Windows.Forms.TextBox tbxSuma;
        private System.Windows.Forms.ListBox lbxKrepselioSarasas;
    }
}