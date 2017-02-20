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
    public partial class NoviLijek : Form
    {
        public NoviLijek()
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

        private void Izlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UnosNazivLijeka_TextChanged(object sender, EventArgs e)
        {
            Provjeri(UnosNazivLijeka,NazivNazivLijeka);
        }

        private void UnosOpisPrimjena_TextChanged(object sender, EventArgs e)
        {
            Provjeri(UnosOpisPrimjena,NazivOpisIPrimjena);
        }

        private void UnosProizvodac_TextChanged(object sender, EventArgs e)
        {
            Provjeri(UnosProizvodac,NazivProizvodac);
        }

        private void NazivNazivLijeka_Click(object sender, EventArgs e)
        {
            ActiveControl = UnosNazivLijeka;
        }

        private void NazivOpisIPrimjena_Click(object sender, EventArgs e)
        {
            ActiveControl = UnosOpisPrimjena;
        }

        private void NazivProizvodac_Click(object sender, EventArgs e)
        {
            ActiveControl = UnosProizvodac;
        }
        private void Dodaj_Click(object sender, EventArgs e)
        {
            try {
                Lijek noviLijek = new Lijek();
                noviLijek.Naziv_lijeka = UnosNazivLijeka.Text;
                noviLijek.Opis_i_primjena = UnosOpisPrimjena.Text;
                noviLijek.Proizvođač = UnosProizvodac.Text;
                noviLijek.Spremi();
                MessageBox.Show("Uspješno ste dodali lijek!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
