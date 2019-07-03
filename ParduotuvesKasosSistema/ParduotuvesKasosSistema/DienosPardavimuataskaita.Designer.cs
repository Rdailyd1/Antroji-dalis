using ParduotuvesKasosSistemaBL;
namespace ParduotuvesKasosSistema
{
    partial class PardavimuAtaskaita
    {
     
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
            this.lblDienosPardavimuAtaskaita = new System.Windows.Forms.Label();
            this.lbxCekioAtaskaita = new System.Windows.Forms.ListBox();
            this.lblSuma = new System.Windows.Forms.Label();
            this.tbxCekiuSuma = new System.Windows.Forms.TextBox();
            this.lblAtsisiustiAtaskaita = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblDienosPardavimuAtaskaita
            // 
            this.lblDienosPardavimuAtaskaita.AutoSize = true;
            this.lblDienosPardavimuAtaskaita.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblDienosPardavimuAtaskaita.Location = new System.Drawing.Point(190, 49);
            this.lblDienosPardavimuAtaskaita.Name = "lblDienosPardavimuAtaskaita";
            this.lblDienosPardavimuAtaskaita.Size = new System.Drawing.Size(193, 24);
            this.lblDienosPardavimuAtaskaita.TabIndex = 2;
            this.lblDienosPardavimuAtaskaita.Text = "Pardavimų ataskaita";
            // 
            // lbxCekioAtaskaita
            // 
            this.lbxCekioAtaskaita.FormattingEnabled = true;
            this.lbxCekioAtaskaita.Location = new System.Drawing.Point(191, 88);
            this.lbxCekioAtaskaita.Name = "lbxCekioAtaskaita";
            this.lbxCekioAtaskaita.Size = new System.Drawing.Size(192, 238);
            this.lbxCekioAtaskaita.TabIndex = 3;
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblSuma.Location = new System.Drawing.Point(167, 346);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(64, 13);
            this.lblSuma.TabIndex = 23;
            this.lblSuma.Text = "Suma, eur";
            // 
            // tbxCekiuSuma
            // 
            this.tbxCekiuSuma.Location = new System.Drawing.Point(237, 343);
            this.tbxCekiuSuma.Name = "tbxCekiuSuma";
            this.tbxCekiuSuma.Size = new System.Drawing.Size(146, 20);
            this.tbxCekiuSuma.TabIndex = 22;
            // 
            // lblAtsisiustiAtaskaita
            // 
            this.lblAtsisiustiAtaskaita.AutoSize = true;
            this.lblAtsisiustiAtaskaita.Location = new System.Drawing.Point(167, 388);
            this.lblAtsisiustiAtaskaita.Name = "lblAtsisiustiAtaskaita";
            this.lblAtsisiustiAtaskaita.Size = new System.Drawing.Size(121, 13);
            this.lblAtsisiustiAtaskaita.TabIndex = 79;
            this.lblAtsisiustiAtaskaita.TabStop = true;
            this.lblAtsisiustiAtaskaita.Text = "Atsisiųsti excel ataskaitą";
            this.lblAtsisiustiAtaskaita.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblAtsisiustiAtaskaita_LinkClicked);
            // 
            // PardavimuAtaskaita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 450);
            this.Controls.Add(this.lblAtsisiustiAtaskaita);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.tbxCekiuSuma);
            this.Controls.Add(this.lbxCekioAtaskaita);
            this.Controls.Add(this.lblDienosPardavimuAtaskaita);
            this.Name = "PardavimuAtaskaita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pardavimų ataskaita";
            this.Load += new System.EventHandler(this.DienosPardavimuAtaskaita_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDienosPardavimuAtaskaita;
        private System.Windows.Forms.ListBox lbxCekioAtaskaita;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.TextBox tbxCekiuSuma;
        private System.Windows.Forms.LinkLabel lblAtsisiustiAtaskaita;
    }
}