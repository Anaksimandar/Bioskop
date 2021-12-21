
namespace Bioskop
{
    partial class Kupac_Login
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
            this.panelKupacLogin = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoginKupac = new System.Windows.Forms.Button();
            this.tbKupacLoginLoz = new System.Windows.Forms.TextBox();
            this.tbKupacLogMail = new System.Windows.Forms.TextBox();
            this.panelKupacLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelKupacLogin
            // 
            this.panelKupacLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelKupacLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelKupacLogin.Controls.Add(this.label2);
            this.panelKupacLogin.Controls.Add(this.label1);
            this.panelKupacLogin.Controls.Add(this.btnLoginKupac);
            this.panelKupacLogin.Controls.Add(this.tbKupacLoginLoz);
            this.panelKupacLogin.Controls.Add(this.tbKupacLogMail);
            this.panelKupacLogin.Location = new System.Drawing.Point(152, 96);
            this.panelKupacLogin.Name = "panelKupacLogin";
            this.panelKupacLogin.Size = new System.Drawing.Size(470, 225);
            this.panelKupacLogin.TabIndex = 5;
            this.panelKupacLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelKupacLogin_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Unesite Vasu lozinku";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Unesite Vasu e-mail adresu:";
            // 
            // btnLoginKupac
            // 
            this.btnLoginKupac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoginKupac.Location = new System.Drawing.Point(140, 157);
            this.btnLoginKupac.Name = "btnLoginKupac";
            this.btnLoginKupac.Size = new System.Drawing.Size(191, 36);
            this.btnLoginKupac.TabIndex = 7;
            this.btnLoginKupac.Text = "Uloguj se";
            this.btnLoginKupac.UseVisualStyleBackColor = true;
            this.btnLoginKupac.Click += new System.EventHandler(this.btnLoginKupac_Click);
            // 
            // tbKupacLoginLoz
            // 
            this.tbKupacLoginLoz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKupacLoginLoz.Location = new System.Drawing.Point(140, 112);
            this.tbKupacLoginLoz.Name = "tbKupacLoginLoz";
            this.tbKupacLoginLoz.Size = new System.Drawing.Size(191, 22);
            this.tbKupacLoginLoz.TabIndex = 6;
            this.tbKupacLoginLoz.UseSystemPasswordChar = true;
            // 
            // tbKupacLogMail
            // 
            this.tbKupacLogMail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKupacLogMail.Location = new System.Drawing.Point(140, 52);
            this.tbKupacLogMail.Name = "tbKupacLogMail";
            this.tbKupacLogMail.Size = new System.Drawing.Size(191, 22);
            this.tbKupacLogMail.TabIndex = 5;
            // 
            // Kupac_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelKupacLogin);
            this.Name = "Kupac_Login";
            this.Text = "Kupac_Login";
            this.Load += new System.EventHandler(this.Kupac_Login_Load);
            this.panelKupacLogin.ResumeLayout(false);
            this.panelKupacLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelKupacLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoginKupac;
        private System.Windows.Forms.TextBox tbKupacLoginLoz;
        private System.Windows.Forms.TextBox tbKupacLogMail;
    }
}