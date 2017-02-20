using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Care
{
    public partial class Prijava : Form
    {
        public Prijava()
        {
            InitializeComponent();
        }

        private void Ime_TextChanged(object sender, EventArgs e)
        {
            if (Ime.Text == "") NazivIme.Visible = true;
            else NazivIme.Visible = false;
        }

        private void Lozinka_TextChanged(object sender, EventArgs e)
        {
            if (Lozinka.Text == "") NazivLozinka.Visible = true;
            else NazivLozinka.Visible = false;
        }

        private void ImeLabel_Click(object sender, EventArgs e)
        {
            ActiveControl = Ime;
        }

        private void LozinkaLabel_Click(object sender, EventArgs e)
        {
            ActiveControl = Lozinka;
        }

        private void PrijaviSe_Click(object sender, EventArgs e)
        {
            string sqlUpit = "SELECT KorisničkoIme, Lozinka FROM Skrbitelji WHERE KorisničkoIme = '" + Ime.Text + "' AND Lozinka = '" + Lozinka.Text + "'";

            if (SQLServer.Instance.DohvatiVrijednost(sqlUpit) == null || Ime.Text == "" || Lozinka.Text == "")
            {
                Pogreska.Visible = true;
            }
            else
            {
                string sqlUpit1 = "SELECT Administrator FROM Skrbitelji WHERE KorisničkoIme = '" + Ime.Text + "' AND Lozinka = '" + Lozinka.Text + "'";
                if (bool.Parse(SQLServer.Instance.DohvatiVrijednost(sqlUpit1).ToString()) == true)
                {
                    TrenutniKorisnik.Korisnik = "admin";
                }
                else
                {
                    TrenutniKorisnik.Korisnik = "skrbitelj";
                }
                string sqlUpit2 = "SELECT OIB_Skrbitelja FROM Skrbitelji WHERE  KorisničkoIme = '" + Ime.Text + "' AND Lozinka = '" + Lozinka.Text + "'";
                TrenutniKorisnik.OIBKorisnika = SQLServer.Instance.DohvatiVrijednost(sqlUpit2).ToString();
                Pogreska.Visible = false;
                GlavnaForma glavnaForma = new GlavnaForma();
                glavnaForma.Show();
                glavnaForma.RefPrijava = this;
                Ime.Clear();
                Lozinka.Clear();
                this.Hide();


            }
        }
    }
}

