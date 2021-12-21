using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bioskop
{
    class Validacija
    {
        public static bool proveraString(string podatak)
        {
            if (podatak == "")
            {
                return false;
            }
            int provera = 0;
            int.TryParse(podatak, out provera);
            if (provera == 1)
            {
                return false;
            }
            return true;
        }

        public static bool registracija(string mail, string lozinka1, string lozinka2)
        {
            bool prov_mail = false;

            bool prov_iste = false;
            prov_mail = proveraMail(mail);


            if (proveraLozinka(lozinka1, lozinka2))
            {
                prov_iste = true;

            }
            if (prov_iste && prov_mail)
            {
                return true;
            }
            return false;
        }
        public static bool proveraMail(String mail)
        {
            if (mail == "")
            {
                return false;
            }
            foreach (Kupac k in Kupac.vrati_listu_kupaca())
            {
                if (k.get_mail() == mail)
                {
                    return false;
                }
            }
            var provera = new EmailAddressAttribute();
            return provera.IsValid(mail);
        }
        public static bool proveraLozinka(string lozinka1, string lozinka2)
        {

            bool validne = false;
            if (lozinka1.Length > 6 && lozinka2.Length > 6 && lozinka1 == lozinka2)
            {
                validne = true;
            }
            return validne;


        }
        public static bool proveraTelefon(string broj_telefona)
        {
            if (broj_telefona == "")
            {
                return false;
            }
            Regex regex = new Regex("^[0-9]{9}");
            MatchCollection nadjeni = regex.Matches(broj_telefona);
            if (nadjeni.Count == 1)
            {
                return true;
            }
            return false;
        }
        public static bool proveraDatum(string datum)
        {
            if (datum == "")
            {
                return false;
            }
            try
            {
                CultureInfo srbija = new CultureInfo("sr");
                string format = "dd/MM/yyyy";

                DateTime datum_rodjenja = DateTime.ParseExact(datum, format, srbija, DateTimeStyles.None);

                return true;
            }
            catch (Exception e)
            {
                return false;

            }



        }
        public static bool proveraSatMinut(string uneto_vreme)
        {
            CultureInfo srb = new CultureInfo("sr");
            string format = "HH/mm";
            DateTime rezultat;

            if (uneto_vreme == "")
            {
                return false;
            }

            bool tacan_unos = DateTime.TryParseExact(uneto_vreme, format, srb, DateTimeStyles.None, out rezultat);
            if (tacan_unos)
            {
                return true;
            }
            return false;
        }
    }
}
