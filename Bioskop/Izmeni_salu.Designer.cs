
namespace Bioskop
{
    partial class Izmeni_salu
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
            this.btnIzmeniSalu = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBrojMesta = new System.Windows.Forms.TextBox();
            this.tbBrojSale = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnIzmeniSalu);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbBrojMesta);
            this.panel1.Controls.Add(this.tbBrojSale);
            this.panel1.Location = new System.Drawing.Point(157, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 288);
            this.panel1.TabIndex = 1;
            // 
            // btnIzmeniSalu
            // 
            this.btnIzmeniSalu.Location = new System.Drawing.Point(130, 150);
            this.btnIzmeniSalu.Name = "btnIzmeniSalu";
            this.btnIzmeniSalu.Size = new System.Drawing.Size(259, 44);
            this.btnIzmeniSalu.TabIndex = 16;
            this.btnIzmeniSalu.Text = "Izmeni salu";
            this.btnIzmeniSalu.UseVisualStyleBackColor = true;
            this.btnIzmeniSalu.Click += new System.EventHandler(this.btnIzmeniSalu_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(209, 42);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 17);
            this.lblID.TabIndex = 15;
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Broj mesta:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "ID:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Broj sale:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbBrojMesta
            // 
            this.tbBrojMesta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBrojMesta.Location = new System.Drawing.Point(212, 115);
            this.tbBrojMesta.Name = "tbBrojMesta";
            this.tbBrojMesta.Size = new System.Drawing.Size(177, 22);
            this.tbBrojMesta.TabIndex = 1;
            this.tbBrojMesta.TextChanged += new System.EventHandler(this.tbBrojMesta_TextChanged);
            // 
            // tbBrojSale
            // 
            this.tbBrojSale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBrojSale.Location = new System.Drawing.Point(212, 75);
            this.tbBrojSale.Name = "tbBrojSale";
            this.tbBrojSale.Size = new System.Drawing.Size(177, 22);
            this.tbBrojSale.TabIndex = 0;
            this.tbBrojSale.TextChanged += new System.EventHandler(this.tbBrojSale_TextChanged);
            // 
            // Izmeni_salu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Izmeni_salu";
            this.Text = "Izmeni_salu";
            this.Load += new System.EventHandler(this.Izmeni_salu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBrojMesta;
        private System.Windows.Forms.TextBox tbBrojSale;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnIzmeniSalu;
    }
}