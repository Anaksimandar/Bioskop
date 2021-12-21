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
    
    public partial class Dodaj_Novu_Salu : Form
    {
        Sala nova_sala;
        public Dodaj_Novu_Salu()
        {
            InitializeComponent();
            nova_sala = new Sala();
        }

        private void btnDodajSalu_Click(object sender, EventArgs e)
        {
            int provera_sala;
            int provera_mesta;
            bool dobar_format1 = Int32.TryParse(tbBrojSale.Text, out provera_sala);
            bool dobar_format2 = Int32.TryParse(tbBrojMesta.Text, out provera_mesta);
            if(dobar_format1 && dobar_format2 && provera_mesta>0 && provera_sala >0)
            {
                nova_sala = new Sala(provera_sala,provera_mesta);
                Sala.dodaj_salu(nova_sala);
                
                Sala.upisi_salu(Sala.vrati_listu_sala());
                
                MessageBox.Show("Sala je uspesno dodata" + nova_sala.sala_info());
                
            }
            else
            {
                MessageBox.Show("Unesite prirodne brojeve");
            }
            
        }

        private void Dodaj_Novu_Salu_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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
