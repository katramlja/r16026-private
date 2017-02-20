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
    public partial class NovaSoba : Form
    {
        private Soba novaSoba = null;

        public NovaSoba()
        {
            InitializeComponent();
            
        }
        public NovaSoba(Soba odabranaSoba)
        {
            InitializeComponent();
            novaSoba = odabranaSoba; 
        }

        private void SobeOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            if (novaSoba == null)
            {
                novaSoba = new Soba();
            }
            novaSoba.Broj_sobe = int.Parse(UnosBrojSobe.Text);
            novaSoba.Odjel = int.Parse(OdabirOdjela.SelectedValue.ToString());
            novaSoba.Spremi();
            this.Close();
        }

        private void Izlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NovaSoba_Load(object sender, EventArgs e)
        {
            OdabirOdjela.DataSource = Odjel.DohvatiOdjele();
            /*
            if (novaSoba != null)
            {
                UnosBrojSobe.Text = novaSoba.Broj_sobe.ToString();

                for (int i = 0; i < OdabirOdjela.Items.Count; i++)
                {
                    OdabirOdjela.SelectedIndex = i;
                    if ((OdabirOdjela.SelectedItem as Odjel).ID_Odjela == novaSoba.odjel.ID_Odjela)
                    {
                        break;
                    }
                }
            }*/
        }

    }
}
