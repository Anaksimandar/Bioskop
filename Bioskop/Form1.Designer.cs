
namespace Bioskop
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.adminStrana = new System.Windows.Forms.TabPage();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.btnPotvrdaRegistracijeAdmin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAdminLozinka = new System.Windows.Forms.TextBox();
            this.tbAdminKorisnickoIme = new System.Windows.Forms.TextBox();
            this.korisnikStrana = new System.Windows.Forms.TabPage();
            this.btnRegistrujSe = new System.Windows.Forms.Button();
            this.btnUlogujSe = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.adminStrana.SuspendLayout();
            this.adminPanel.SuspendLayout();
            this.korisnikStrana.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.adminStrana);
            this.tabControl1.Controls.Add(this.korisnikStrana);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 454);
            this.tabControl1.TabIndex = 0;
            // 
            // adminStrana
            // 
            this.adminStrana.Controls.Add(this.adminPanel);
            this.adminStrana.Location = new System.Drawing.Point(4, 25);
            this.adminStrana.Name = "adminStrana";
            this.adminStrana.Size = new System.Drawing.Size(795, 425);
            this.adminStrana.TabIndex = 0;
            this.adminStrana.Text = "Administracija";
            this.adminStrana.UseVisualStyleBackColor = true;
            this.adminStrana.Click += new System.EventHandler(this.adminStrana_Click);
            // 
            // adminPanel
            // 
            this.adminPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adminPanel.BackColor = System.Drawing.Color.PapayaWhip;
            this.adminPanel.Controls.Add(this.btnPotvrdaRegistracijeAdmin);
            this.adminPanel.Controls.Add(this.label3);
            this.adminPanel.Controls.Add(this.label1);
            this.adminPanel.Controls.Add(this.tbAdminLozinka);
            this.adminPanel.Controls.Add(this.tbAdminKorisnickoIme);
            this.adminPanel.Location = new System.Drawing.Point(172, 60);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(450, 300);
            this.adminPanel.TabIndex = 0;
            // 
            // btnPotvrdaRegistracijeAdmin
            // 
            this.btnPotvrdaRegistracijeAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPotvrdaRegistracijeAdmin.Location = new System.Drawing.Point(87, 204);
            this.btnPotvrdaRegistracijeAdmin.Name = "btnPotvrdaRegistracijeAdmin";
            this.btnPotvrdaRegistracijeAdmin.Size = new System.Drawing.Size(255, 49);
            this.btnPotvrdaRegistracijeAdmin.TabIndex = 7;
            this.btnPotvrdaRegistracijeAdmin.Text = "Potvrdi";
            this.btnPotvrdaRegistracijeAdmin.UseVisualStyleBackColor = true;
            this.btnPotvrdaRegistracijeAdmin.Click += new System.EventHandler(this.btnPotvrdaRegistracijeAdmin_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lozinka:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Korisnicko ime:";
            // 
            // tbAdminLozinka
            // 
            this.tbAdminLozinka.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAdminLozinka.Location = new System.Drawing.Point(149, 126);
            this.tbAdminLozinka.Name = "tbAdminLozinka";
            this.tbAdminLozinka.Size = new System.Drawing.Size(193, 22);
            this.tbAdminLozinka.TabIndex = 2;
            this.tbAdminLozinka.UseSystemPasswordChar = true;
            // 
            // tbAdminKorisnickoIme
            // 
            this.tbAdminKorisnickoIme.AcceptsReturn = true;
            this.tbAdminKorisnickoIme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAdminKorisnickoIme.Location = new System.Drawing.Point(149, 62);
            this.tbAdminKorisnickoIme.Name = "tbAdminKorisnickoIme";
            this.tbAdminKorisnickoIme.Size = new System.Drawing.Size(193, 22);
            this.tbAdminKorisnickoIme.TabIndex = 0;
            // 
            // korisnikStrana
            // 
            this.korisnikStrana.Controls.Add(this.btnRegistrujSe);
            this.korisnikStrana.Controls.Add(this.btnUlogujSe);
            this.korisnikStrana.Location = new System.Drawing.Point(4, 25);
            this.korisnikStrana.Name = "korisnikStrana";
            this.korisnikStrana.Size = new System.Drawing.Size(795, 425);
            this.korisnikStrana.TabIndex = 1;
            this.korisnikStrana.Text = "Korisnik";
            this.korisnikStrana.UseVisualStyleBackColor = true;
            this.korisnikStrana.Click += new System.EventHandler(this.korisnikStrana_Click);
            // 
            // btnRegistrujSe
            // 
            this.btnRegistrujSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrujSe.Location = new System.Drawing.Point(23, 257);
            this.btnRegistrujSe.Name = "btnRegistrujSe";
            this.btnRegistrujSe.Size = new System.Drawing.Size(747, 135);
            this.btnRegistrujSe.TabIndex = 1;
            this.btnRegistrujSe.Text = "Registruj se";
            this.btnRegistrujSe.UseVisualStyleBackColor = true;
            this.btnRegistrujSe.Click += new System.EventHandler(this.btnRegistrujSe_Click);
            // 
            // btnUlogujSe
            // 
            this.btnUlogujSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUlogujSe.Location = new System.Drawing.Point(23, 75);
            this.btnUlogujSe.Name = "btnUlogujSe";
            this.btnUlogujSe.Size = new System.Drawing.Size(747, 135);
            this.btnUlogujSe.TabIndex = 0;
            this.btnUlogujSe.Text = "Prijavi se";
            this.btnUlogujSe.UseVisualStyleBackColor = true;
            this.btnUlogujSe.Click += new System.EventHandler(this.btnUlogujSe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.adminStrana.ResumeLayout(false);
            this.adminPanel.ResumeLayout(false);
            this.adminPanel.PerformLayout();
            this.korisnikStrana.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage adminStrana;
        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.Button btnPotvrdaRegistracijeAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAdminLozinka;
        private System.Windows.Forms.TextBox tbAdminKorisnickoIme;
        private System.Windows.Forms.TabPage korisnikStrana;
        private System.Windows.Forms.Button btnRegistrujSe;
        private System.Windows.Forms.Button btnUlogujSe;
    }
}

