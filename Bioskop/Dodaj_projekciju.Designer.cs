
namespace Bioskop
{
    partial class Dodaj_projekciju
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
            this.cbListaSala = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbListaFilmova = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbVremePocetkaProjekcije = new System.Windows.Forms.TextBox();
            this.tbDatumProjekcije = new System.Windows.Forms.TextBox();
            this.btnDodajProjekciju = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCenaKarte = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbCenaKarte);
            this.panel1.Controls.Add(this.btnDodajProjekciju);
            this.panel1.Controls.Add(this.cbListaSala);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbListaFilmova);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbVremePocetkaProjekcije);
            this.panel1.Controls.Add(this.tbDatumProjekcije);
            this.panel1.Location = new System.Drawing.Point(81, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 310);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbListaSala
            // 
            this.cbListaSala.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbListaSala.FormattingEnabled = true;
            this.cbListaSala.Location = new System.Drawing.Point(304, 226);
            this.cbListaSala.Name = "cbListaSala";
            this.cbListaSala.Size = new System.Drawing.Size(164, 24);
            this.cbListaSala.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sala:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Film:";
            // 
            // cbListaFilmova
            // 
            this.cbListaFilmova.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbListaFilmova.FormattingEnabled = true;
            this.cbListaFilmova.Location = new System.Drawing.Point(304, 187);
            this.cbListaFilmova.Name = "cbListaFilmova";
            this.cbListaFilmova.Size = new System.Drawing.Size(164, 24);
            this.cbListaFilmova.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vreme pocetka projekcije";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datum projekcije:";
            // 
            // tbVremePocetkaProjekcije
            // 
            this.tbVremePocetkaProjekcije.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbVremePocetkaProjekcije.Location = new System.Drawing.Point(304, 149);
            this.tbVremePocetkaProjekcije.Name = "tbVremePocetkaProjekcije";
            this.tbVremePocetkaProjekcije.Size = new System.Drawing.Size(164, 22);
            this.tbVremePocetkaProjekcije.TabIndex = 1;
            // 
            // tbDatumProjekcije
            // 
            this.tbDatumProjekcije.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDatumProjekcije.Location = new System.Drawing.Point(304, 112);
            this.tbDatumProjekcije.Name = "tbDatumProjekcije";
            this.tbDatumProjekcije.Size = new System.Drawing.Size(164, 22);
            this.tbDatumProjekcije.TabIndex = 0;
            // 
            // btnDodajProjekciju
            // 
            this.btnDodajProjekciju.Location = new System.Drawing.Point(134, 256);
            this.btnDodajProjekciju.Name = "btnDodajProjekciju";
            this.btnDodajProjekciju.Size = new System.Drawing.Size(334, 51);
            this.btnDodajProjekciju.TabIndex = 8;
            this.btnDodajProjekciju.Text = "Dodaj projekciju";
            this.btnDodajProjekciju.UseVisualStyleBackColor = true;
            this.btnDodajProjekciju.Click += new System.EventHandler(this.btnDodajProjekciju_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cena karte:";
            // 
            // tbCenaKarte
            // 
            this.tbCenaKarte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCenaKarte.Location = new System.Drawing.Point(304, 75);
            this.tbCenaKarte.Name = "tbCenaKarte";
            this.tbCenaKarte.Size = new System.Drawing.Size(164, 22);
            this.tbCenaKarte.TabIndex = 9;
            // 
            // Dodaj_projekciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Dodaj_projekciju";
            this.Text = "Dodaj_projekciju";
            this.Load += new System.EventHandler(this.Dodaj_projekciju_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbVremePocetkaProjekcije;
        private System.Windows.Forms.TextBox tbDatumProjekcije;
        private System.Windows.Forms.ComboBox cbListaSala;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbListaFilmova;
        private System.Windows.Forms.Button btnDodajProjekciju;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCenaKarte;
    }
}