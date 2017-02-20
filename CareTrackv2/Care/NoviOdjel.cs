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
    public partial class NoviOdjel : Form
    {
        public NoviOdjel()
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

        private void UnosNazivOdjela_TextChanged(object sender, EventArgs e)
        {
            Provjeri(UnosNazivOdjela,NazivNazivOdjela);
        }


        private void NazivNazivOdjela_Click(object sender, EventArgs e)
        {
            ActiveControl = UnosNazivOdjela;
        }

        private void Izlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UnosBrojOdjela_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private Odjel noviOdjel;
        private void Dodaj_Click(object sender, EventArgs e)
        {
            if (noviOdjel == null)
            {
                noviOdjel = new Odjel();
            }
            noviOdjel.Naziv_odjela = UnosNazivOdjela.Text;
            noviOdjel.Spremi();
            this.Close();
        }
    }
}
