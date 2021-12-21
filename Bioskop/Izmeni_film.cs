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
    public partial class Izmeni_film : Form
    {
        
        public Izmeni_film()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Izmeni_film_Load(object sender, EventArgs e)
        {
            foreach (Film f in Film.vrati_film())
            {
                if (f.get_id() == Int32.Parse(lblID.Text))
                {
                    tbNaziv.Text = f.get_naziv();
                    tbZanr.Text = f.get_zanr();
                    tbDuzinaTrajanja.Text = f.get_duzina().ToString();
                    tbGraniceGodina.Text = f.get_granica().ToString();

                }
            }
            
        }

        private void btnIzmeniFilm_Click(object sender, EventArgs e)
        {
            int godine;
            int duzina;
            bool provera_naziv = Validacija.proveraString(tbNaziv.Text);
            bool provera_zanr = Validacija.proveraString(tbZanr.Text);

            bool provera_god = Int32.TryParse(tbGraniceGodina.Text, out godine);
            bool provera_duzina = Int32.TryParse(tbDuzinaTrajanja.Text, out duzina);
            if (provera_duzina == true && provera_god == true && provera_naziv == true && provera_zanr == true)
            {
                foreach(Film f in Film.vrati_film())
                {
                    if(f.get_id() == Int32.Parse(lblID.Text))
                    {
                        f.set_naziv(tbNaziv.Text);
                        f.set_zanr(tbZanr.Text);
                        f.set_duzina(Int32.Parse(tbDuzinaTrajanja.Text));
                        f.set_granice(Int32.Parse(tbGraniceGodina.Text));
                        Film.upisi_film(Film.vrati_film());
                        MessageBox.Show($"Film je izmenjen! Naziv:{f.get_naziv()}Zanr:{f.get_zanr()}Duzina:{f.get_duzina()}Granice:{f.get_granica()}");
                        break;
                    }
                }

                


            }
            else
            {
                MessageBox.Show("Neispravan unos");
            }
        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbGraniceGodina_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDuzinaTrajanja_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbZanr_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNaziv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
