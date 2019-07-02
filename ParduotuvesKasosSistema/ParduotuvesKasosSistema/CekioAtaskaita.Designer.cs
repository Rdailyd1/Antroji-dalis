namespace ParduotuvesKasosSistema
{
    partial class CekioForma
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
            this.lblSuma = new System.Windows.Forms.Label();
            this.tbxCekioSuma = new System.Windows.Forms.TextBox();
            this.lbxCekis = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblSuma.Location = new System.Drawing.Point(167, 356);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(64, 13);
            this.lblSuma.TabIndex = 27;
            this.lblSuma.Text = "Suma, eur";
            // 
            // tbxCekioSuma
            // 
            this.tbxCekioSuma.Location = new System.Drawing.Point(237, 353);
            this.tbxCekioSuma.Name = "tbxCekioSuma";
            this.tbxCekioSuma.Size = new System.Drawing.Size(146, 20);
            this.tbxCekioSuma.TabIndex = 26;
            // 
            // lbxCekis
            // 
            this.lbxCekis.FormattingEnabled = true;
            this.lbxCekis.Location = new System.Drawing.Point(191, 98);
            this.lbxCekis.Name = "lbxCekis";
            this.lbxCekis.Size = new System.Drawing.Size(192, 238);
            this.lbxCekis.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(215, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Pirkimo čekis";
            // 
            // CekioForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.tbxCekioSuma);
            this.Controls.Add(this.lbxCekis);
            this.Controls.Add(this.label1);
            this.Name = "CekioForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Čekis";
            this.Load += new System.EventHandler(this.CekioForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.TextBox tbxCekioSuma;
        private System.Windows.Forms.ListBox lbxCekis;
        private System.Windows.Forms.Label label1;
    }
}