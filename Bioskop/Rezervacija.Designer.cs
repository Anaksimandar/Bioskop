
namespace Bioskop
{
    partial class Rezervacija
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
            this.lblNaslov = new System.Windows.Forms.Label();
            this.dtPocetniDatum = new System.Windows.Forms.DateTimePicker();
            this.panelRezervacija = new System.Windows.Forms.Panel();
            this.lbPrikazProjekcija = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbUkupnaCena = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numUpDownBrojMesta = new System.Windows.Forms.NumericUpDown();
            this.btnRezervisi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPrikaziDostupneProjekcije = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNaziv = new System.Windows.Forms.ComboBox();
            this.cbSala = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtKrajnjiDatum = new System.Windows.Forms.DateTimePicker();
            this.lblIdKupac = new System.Windows.Forms.Label();
            this.lblImeKupca = new System.Windows.Forms.Label();
            this.panelRezervacija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBrojMesta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(341, 0);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(293, 32);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "Rezervacije projekcije";
            this.lblNaslov.Click += new System.EventHandler(this.lblNaslov_Click);
            // 
            // dtPocetniDatum
            // 
            this.dtPocetniDatum.CustomFormat = "dd/MM/yyyy";
            this.dtPocetniDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPocetniDatum.Location = new System.Drawing.Point(15, 24);
            this.dtPocetniDatum.Name = "dtPocetniDatum";
            this.dtPocetniDatum.Size = new System.Drawing.Size(249, 22);
            this.dtPocetniDatum.TabIndex = 1;
            this.dtPocetniDatum.ValueChanged += new System.EventHandler(this.dtPocetniDatum_ValueChanged);
            // 
            // panelRezervacija
            // 
            this.panelRezervacija.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelRezervacija.Controls.Add(this.lbPrikazProjekcija);
            this.panelRezervacija.Controls.Add(this.label7);
            this.panelRezervacija.Controls.Add(this.tbUkupnaCena);
            this.panelRezervacija.Controls.Add(this.label6);
            this.panelRezervacija.Controls.Add(this.numUpDownBrojMesta);
            this.panelRezervacija.Controls.Add(this.btnRezervisi);
            this.panelRezervacija.Controls.Add(this.label5);
            this.panelRezervacija.Controls.Add(this.btnPrikaziDostupneProjekcije);
            this.panelRezervacija.Controls.Add(this.label3);
            this.panelRezervacija.Controls.Add(this.label4);
            this.panelRezervacija.Controls.Add(this.cbNaziv);
            this.panelRezervacija.Controls.Add(this.cbSala);
            this.panelRezervacija.Controls.Add(this.label1);
            this.panelRezervacija.Controls.Add(this.label2);
            this.panelRezervacija.Controls.Add(this.dtKrajnjiDatum);
            this.panelRezervacija.Controls.Add(this.dtPocetniDatum);
            this.panelRezervacija.Location = new System.Drawing.Point(12, 113);
            this.panelRezervacija.Name = "panelRezervacija";
            this.panelRezervacija.Size = new System.Drawing.Size(909, 482);
            this.panelRezervacija.TabIndex = 2;
            // 
            // lbPrikazProjekcija
            // 
            this.lbPrikazProjekcija.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbPrikazProjekcija.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbPrikazProjekcija.FormattingEnabled = true;
            this.lbPrikazProjekcija.ItemHeight = 16;
            this.lbPrikazProjekcija.Location = new System.Drawing.Point(15, 148);
            this.lbPrikazProjekcija.Name = "lbPrikazProjekcija";
            this.lbPrikazProjekcija.Size = new System.Drawing.Size(884, 244);
            this.lbPrikazProjekcija.TabIndex = 16;
            this.lbPrikazProjekcija.SelectedIndexChanged += new System.EventHandler(this.PromenaSelektovanogElementa);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(181, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ukupna cena:";
            // 
            // tbUkupnaCena
            // 
            this.tbUkupnaCena.Location = new System.Drawing.Point(185, 440);
            this.tbUkupnaCena.Name = "tbUkupnaCena";
            this.tbUkupnaCena.Size = new System.Drawing.Size(122, 22);
            this.tbUkupnaCena.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Broj mesta:";
            // 
            // numUpDownBrojMesta
            // 
            this.numUpDownBrojMesta.Location = new System.Drawing.Point(22, 440);
            this.numUpDownBrojMesta.Name = "numUpDownBrojMesta";
            this.numUpDownBrojMesta.Size = new System.Drawing.Size(120, 22);
            this.numUpDownBrojMesta.TabIndex = 12;
            this.numUpDownBrojMesta.ValueChanged += new System.EventHandler(this.numUpDownBrojMesta_ValueChanged);
            // 
            // btnRezervisi
            // 
            this.btnRezervisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezervisi.Location = new System.Drawing.Point(423, 409);
            this.btnRezervisi.Name = "btnRezervisi";
            this.btnRezervisi.Size = new System.Drawing.Size(476, 70);
            this.btnRezervisi.TabIndex = 11;
            this.btnRezervisi.Text = "Rezervisi";
            this.btnRezervisi.UseVisualStyleBackColor = true;
            this.btnRezervisi.Click += new System.EventHandler(this.btnRezervisi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Repertoar bioskopa";
            // 
            // btnPrikaziDostupneProjekcije
            // 
            this.btnPrikaziDostupneProjekcije.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziDostupneProjekcije.Location = new System.Drawing.Point(15, 73);
            this.btnPrikaziDostupneProjekcije.Name = "btnPrikaziDostupneProjekcije";
            this.btnPrikaziDostupneProjekcije.Size = new System.Drawing.Size(884, 49);
            this.btnPrikaziDostupneProjekcije.TabIndex = 7;
            this.btnPrikaziDostupneProjekcije.Text = "Prikazi dostupne projekcije";
            this.btnPrikaziDostupneProjekcije.UseVisualStyleBackColor = true;
            this.btnPrikaziDostupneProjekcije.Click += new System.EventHandler(this.btnPrikaziDostupneProjekcije_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pocetni datum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Krajnji datum:";
            // 
            // cbNaziv
            // 
            this.cbNaziv.FormattingEnabled = true;
            this.cbNaziv.Location = new System.Drawing.Point(729, 22);
            this.cbNaziv.Name = "cbNaziv";
            this.cbNaziv.Size = new System.Drawing.Size(170, 24);
            this.cbNaziv.TabIndex = 4;
            // 
            // cbSala
            // 
            this.cbSala.FormattingEnabled = true;
            this.cbSala.Location = new System.Drawing.Point(536, 22);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(170, 24);
            this.cbSala.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(532, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sala:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(734, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Naziv:";
            // 
            // dtKrajnjiDatum
            // 
            this.dtKrajnjiDatum.CustomFormat = "dd/MM/yyyy";
            this.dtKrajnjiDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtKrajnjiDatum.Location = new System.Drawing.Point(270, 24);
            this.dtKrajnjiDatum.Name = "dtKrajnjiDatum";
            this.dtKrajnjiDatum.Size = new System.Drawing.Size(260, 22);
            this.dtKrajnjiDatum.TabIndex = 2;
            // 
            // lblIdKupac
            // 
            this.lblIdKupac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdKupac.AutoSize = true;
            this.lblIdKupac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdKupac.Location = new System.Drawing.Point(338, 78);
            this.lblIdKupac.Name = "lblIdKupac";
            this.lblIdKupac.Size = new System.Drawing.Size(0, 20);
            this.lblIdKupac.TabIndex = 3;
            // 
            // lblImeKupca
            // 
            this.lblImeKupca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImeKupca.AutoSize = true;
            this.lblImeKupca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImeKupca.Location = new System.Drawing.Point(464, 78);
            this.lblImeKupca.Name = "lblImeKupca";
            this.lblImeKupca.Size = new System.Drawing.Size(0, 20);
            this.lblImeKupca.TabIndex = 4;
            // 
            // Rezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 622);
            this.Controls.Add(this.lblImeKupca);
            this.Controls.Add(this.lblIdKupac);
            this.Controls.Add(this.panelRezervacija);
            this.Controls.Add(this.lblNaslov);
            this.Name = "Rezervacija";
            this.Text = "Rezervacija";
            this.Load += new System.EventHandler(this.Rezervacija_Load);
            this.panelRezervacija.ResumeLayout(false);
            this.panelRezervacija.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBrojMesta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.DateTimePicker dtPocetniDatum;
        private System.Windows.Forms.Panel panelRezervacija;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPrikaziDostupneProjekcije;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbNaziv;
        private System.Windows.Forms.ComboBox cbSala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtKrajnjiDatum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbUkupnaCena;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numUpDownBrojMesta;
        private System.Windows.Forms.Button btnRezervisi;
        private System.Windows.Forms.ListBox lbPrikazProjekcija;
        private System.Windows.Forms.Label lblIdKupac;
        private System.Windows.Forms.Label lblImeKupca;
    }
}