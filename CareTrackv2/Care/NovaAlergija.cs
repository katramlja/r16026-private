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
    public partial class NovaAlergija : Form
    {
        public NovaAlergija()
        {
            InitializeComponent();
        }

        private void UnosAlergije_TextChanged(object sender, EventArgs e)
        {
            if (UnosAlergija.Text != "")
            {
                NazivAlergija.Visible = false;
            }
            else
            {
                NazivAlergija.Visible = true;
            }
        }

        private void Izlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            UnosAlergija.Text = "";
        }

        private void NazivAlergija_Click(object sender, EventArgs e)
        {
            ActiveControl = UnosAlergija;
        }
    }
}
