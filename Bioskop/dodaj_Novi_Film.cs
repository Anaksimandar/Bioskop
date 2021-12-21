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
    public partial class dodaj_Novi_Film : Form
    {
        Film novi_film;
        public dodaj_Novi_Film()
        {
            InitializeComponent();
            
        }

        private void dodaj_Novi_Film_Load(object sender, EventArgs e)
        {

        }

        private void btnDodajFilm_Click(object sender, EventArgs e)
        {
            int godine;
            int duzina;
            bool provera_naziv = Validacija.proveraString(tbNaziv.Text);
            bool provera_zanr = Validacija.proveraString(tbZanr.Text);
            
            bool provera_god = Int32.TryParse(tbGraniceGodina.Text,out godine);
            bool provera_duzina = Int32.TryParse(tbDuzinaTrajanja.Text, out duzina);
            if(provera_duzina == true && provera_god == true && provera_naziv == true && provera_zanr == true)
            {
                novi_film = new Film(tbNaziv.Text,tbZanr.Text,duzina,godine);
                Film.dodaj_film(novi_film);
                Film.upisi_film(Film.vrati_film());
                MessageBox.Show("Film je uspesno kreiran" + novi_film.film_info());


            }
            else
            {
                MessageBox.Show("Neispravan unos");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
