using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bioskop
{
    public partial class Izmeni_salu : Form
    {
        public Izmeni_salu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Izmeni_salu_Load(object sender, EventArgs e)
        {
            foreach(Sala s in Sala.vrati_listu_sala())
            {
                if(s.get_id() == Int32.Parse(lblID.Text)){
                    tbBrojSale.Text = s.get_broj_sale().ToString();
                    tbBrojMesta.Text = s.get_broj_sedista().ToString();
                    break;

                }
            }

        }

        private void btnIzmeniSalu_Click(object sender, EventArgs e)
        {
            int id_sale = Int32.Parse(lblID.Text);
            int provera_sala;
            int provera_mesta;
            bool dobar_format1 = Int32.TryParse(tbBrojSale.Text, out provera_sala);
            bool dobar_format2 = Int32.TryParse(tbBrojMesta.Text, out provera_mesta);
            if (dobar_format1 && dobar_format2 && provera_mesta > 0 && provera_sala > 0)
            {
                foreach (Sala s in Sala.vrati_listu_sala())
                {
                    if(s.get_id() == id_sale)
                    {
                        s.set_broj_sale(provera_sala);
                        s.set_broj_sedista(provera_mesta);
                        Sala.upisi_salu(Sala.vrati_listu_sala());
                        MessageBox.Show($"Uspesno izmenjeni podaci!Broj sale:{s.get_broj_sale()}Broj sedista:{s.get_broj_sedista()}");
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Unesite prirodne brojeve");
            }
        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tbBrojMesta_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbBrojSale_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
