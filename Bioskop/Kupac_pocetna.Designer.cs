
namespace Bioskop
{
    partial class Kupac_pocetna
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnObrisiRezervaciju = new System.Windows.Forms.Button();
            this.btnPrikaziRezervacije = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKupacRezervacije = new System.Windows.Forms.ComboBox();
            this.lblImeKupcaPocetna = new System.Windows.Forms.Label();
            this.lblIdKupacPocetna = new System.Windows.Forms.Label();
            this.btnDodajRezervaciju = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnObrisiRezervaciju);
            this.panel1.Controls.Add(this.btnPrikaziRezervacije);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbKupacRezervacije);
            this.panel1.Controls.Add(this.lblImeKupcaPocetna);
            this.panel1.Controls.Add(this.lblIdKupacPocetna);
            this.panel1.Controls.Add(this.btnDodajRezervaciju);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(149, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 380);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnObrisiRezervaciju
            // 
            this.btnObrisiRezervaciju.Location = new System.Drawing.Point(105, 241);
            this.btnObrisiRezervaciju.Name = "btnObrisiRezervaciju";
            this.btnObrisiRezervaciju.Size = new System.Drawing.Size(286, 46);
            this.btnObrisiRezervaciju.TabIndex = 8;
            this.btnObrisiRezervaciju.Text = "Obrisi rezervaciju";
            this.btnObrisiRezervaciju.UseVisualStyleBackColor = true;
            this.btnObrisiRezervaciju.Click += new System.EventHandler(this.btnObrisiRezervaciju_Click);
            // 
            // btnPrikaziRezervacije
            // 
            this.btnPrikaziRezervacije.Location = new System.Drawing.Point(105, 139);
            this.btnPrikaziRezervacije.Name = "btnPrikaziRezervacije";
            this.btnPrikaziRezervacije.Size = new System.Drawing.Size(286, 44);
            this.btnPrikaziRezervacije.TabIndex = 7;
            this.btnPrikaziRezervacije.Text = "Prikazi rezervacije";
            this.btnPrikaziRezervacije.UseVisualStyleBackColor = true;
            this.btnPrikaziRezervacije.Click += new System.EventHandler(this.btnPrikaziRezervacije_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prikazi dostupne rezervacije:";
            // 
            // cbKupacRezervacije
            // 
            this.cbKupacRezervacije.FormattingEnabled = true;
            this.cbKupacRezervacije.Location = new System.Drawing.Point(105, 100);
            this.cbKupacRezervacije.Name = "cbKupacRezervacije";
            this.cbKupacRezervacije.Size = new System.Drawing.Size(286, 24);
            this.cbKupacRezervacije.TabIndex = 6;
            this.cbKupacRezervacije.SelectedIndexChanged += new System.EventHandler(this.PromenaIndexa);
            // 
            // lblImeKupcaPocetna
            // 
            this.lblImeKupcaPocetna.AutoSize = true;
            this.lblImeKupcaPocetna.Location = new System.Drawing.Point(220, 66);
            this.lblImeKupcaPocetna.Name = "lblImeKupcaPocetna";
            this.lblImeKupcaPocetna.Size = new System.Drawing.Size(0, 17);
            this.lblImeKupcaPocetna.TabIndex = 5;
            // 
            // lblIdKupacPocetna
            // 
            this.lblIdKupacPocetna.AutoSize = true;
            this.lblIdKupacPocetna.Location = new System.Drawing.Point(107, 66);
            this.lblIdKupacPocetna.Name = "lblIdKupacPocetna";
            this.lblIdKupacPocetna.Size = new System.Drawing.Size(0, 17);
            this.lblIdKupacPocetna.TabIndex = 4;
            // 
            // btnDodajRezervaciju
            // 
            this.btnDodajRezervaciju.Location = new System.Drawing.Point(105, 189);
            this.btnDodajRezervaciju.Name = "btnDodajRezervaciju";
            this.btnDodajRezervaciju.Size = new System.Drawing.Size(286, 46);
            this.btnDodajRezervaciju.TabIndex = 3;
            this.btnDodajRezervaciju.Text = "Dodaj rezervaciju";
            this.btnDodajRezervaciju.UseVisualStyleBackColor = true;
            this.btnDodajRezervaciju.Click += new System.EventHandler(this.btnDodajRezervaciju_Click);
            // 
            // Kupac_pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Kupac_pocetna";
            this.Text = "Kupac_pocetna";
            this.Load += new System.EventHandler(this.Kupac_pocetna_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblImeKupcaPocetna;
        private System.Windows.Forms.Label lblIdKupacPocetna;
        private System.Windows.Forms.Button btnDodajRezervaciju;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKupacRezervacije;
        private System.Windows.Forms.Button btnPrikaziRezervacije;
        private System.Windows.Forms.Button btnObrisiRezervaciju;
    }
}