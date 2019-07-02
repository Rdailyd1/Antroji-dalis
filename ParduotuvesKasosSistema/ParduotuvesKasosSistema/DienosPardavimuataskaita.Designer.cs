using ParduotuvesKasosSistemaBL;
namespace ParduotuvesKasosSistema
{
    partial class DienosPardavimuAtaskaita
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbxCekioAtaskaita = new System.Windows.Forms.ListBox();
            this.lblSuma = new System.Windows.Forms.Label();
            this.tbxCekiuSuma = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(215, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prekių čekiai";
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
            // DienosPardavimuAtaskaita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 450);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.tbxCekiuSuma);
            this.Controls.Add(this.lbxCekioAtaskaita);
            this.Controls.Add(this.label1);
            this.Name = "DienosPardavimuAtaskaita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dienos pardavimų ataskaita";
            this.Load += new System.EventHandler(this.DienosPardavimuAtaskaita_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxCekioAtaskaita;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.TextBox tbxCekiuSuma;
    }
}