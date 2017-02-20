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
    public partial class NoviSkrbitelj : Form
    {
        public NoviSkrbitelj()
        {
            InitializeComponent();
        }

    

        void Provjeri(TextBox textBox, Label label)
        {
            if (textBox.Text != "")
            {
                label.Visible = false;
            }
            else
            {
                label.Visible = true;
            }
        }

        private void UnosIme_TextChanged(object sender, EventArgs e)
        {
            Provjeri(UnosIme, NazivIme);
        }

        private void UnosPrezime_TextChanged_1(object sender, EventArgs e)
        {
            Provjeri(UnosPrezime, NazivPrezime);
        }

        private void UnosOIB_TextChanged_1(object sender, EventArgs e)
        {
            Provjeri(UnosOIB, OIB);
        }

        private void UnosIme_Click(object sender, EventArgs e)
        {
            ActiveControl = UnosIme;
        }

        private void UnosPrezime_Click(object sender, EventArgs e)
        {
            ActiveControl = UnosPrezime;
        }

        private void UnosOIB_Click(object sender, EventArgs e)
        {
            ActiveControl = UnosOIB;
        }

        private void Izlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Skrbitelj noviSkrbitelj = null;
        Izbornik obj = (Izbornik)Application.OpenForms["Izbornik"];
        private void Spremi_Click(object sender, EventArgs e)
        {
            if (noviSkrbitelj == null)
            {
                noviSkrbitelj = new Skrbitelj();
            }

            noviSkrbitelj.Ime = UnosIme.Text;
            noviSkrbitelj.Prezime = UnosPrezime.Text;
            noviSkrbitelj.OIBSkrbitelja = UnosOIB.Text;
            noviSkrbitelj.KorisnickoIme = UnosKorisnickoIme.Text;
            noviSkrbitelj.Lozinka = UnosLozinka.Text;

            if (radioButton1.Checked == true)
            {
                noviSkrbitelj.Administrator = true;
            }
            else noviSkrbitelj.Administrator = false;

            noviSkrbitelj.Spremi();
            obj.OsvjeziSkrbitelje();
            this.Close();
        }

        private void NazivPrezime_Click(object sender, EventArgs e)
        {
            ActiveControl = UnosPrezime;
        }

        private void NazivIme_Click(object sender, EventArgs e)
        {
            ActiveControl = UnosIme;
        }

        private void OIB_Click(object sender, EventArgs e)
        {
            ActiveControl = UnosOIB;
        }

        private void UnosOIB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void NazivKorisnickoIme_Click(object sender, EventArgs e)
        {
            ActiveControl = UnosKorisnickoIme;
        }

        private void NazivLozinka_Click(object sender, EventArgs e)
        {
            ActiveControl = UnosLozinka;
        }

        private void UnosKorisnickoIme_TextChanged(object sender, EventArgs e)
        {
            Provjeri(UnosKorisnickoIme,NazivKorisnickoIme);
        }

        private void UnosLozinka_TextChanged(object sender, EventArgs e)
        {
            Provjeri(UnosLozinka,NazivLozinka);
        }

        public Skrbitelj OdabraniSkrbitelj;
        public void PrikazOdabranogSkrbitelja(Skrbitelj odabraniSkrbitelj)
        {
            OdabraniSkrbitelj = odabraniSkrbitelj;
            try
            {

                UnosIme.Text = OdabraniSkrbitelj.Ime;
                UnosPrezime.Text = OdabraniSkrbitelj.Prezime;
                UnosOIB.Text = OdabraniSkrbitelj.OIBSkrbitelja;
                UnosKorisnickoIme.Text = OdabraniSkrbitelj.KorisnickoIme;
                UnosLozinka.Text = odabraniSkrbitelj.Lozinka;
                if (OdabraniSkrbitelj.Administrator == true)
                {
                    radioButton1.Checked = true;
                }
                else radioButton2.Checked = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Obriši_Click(object sender, EventArgs e)
        {
            if (noviSkrbitelj == null)
            {
                noviSkrbitelj = new Skrbitelj();
            }
            noviSkrbitelj.OIBSkrbitelja = UnosOIB.Text;
            noviSkrbitelj.Obrisi();
            obj.OsvjeziSkrbitelje();
            this.Close();
        }
    }
}
