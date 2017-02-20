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
    public partial class NovoIzvješće_o_incidentu : Form
    {
        public Sticenik odabraniSticenik = null;
        public NovoIzvješće_o_incidentu()
        {
            InitializeComponent();
        }
       
        public NovoIzvješće_o_incidentu(Sticenik OdabraniSticenik)
        {
            InitializeComponent();
            odabraniSticenik = OdabraniSticenik;
            OpisIncidenta.Text = " ";
            UnosŠtićenika.Text = odabraniSticenik.Ime + " " + odabraniSticenik.Prezime;
            UnosOIB_Skrbitelja.DataSource = Skrbitelj.DohvatiSkrbitelje();
        }
        public NovoIzvješće_o_incidentu(Izvješće_o_incidentu novoIzvješće)
        {
            InitializeComponent();
            try
            {
                novoIzvješće.ID_Izvješća = novoIzvješće.ID_Izvješća;
                novoIzvješće.Opis = novoIzvješće.Opis;
                novoIzvješće.SkrbiteljiOIB_Skrbitelja = novoIzvješće.SkrbiteljiOIB_Skrbitelja;
                novoIzvješće.ŠtićeniciOIB_Štićenika = novoIzvješće.ŠtićeniciOIB_Štićenika;
                novoIzvješće.Vrijeme_početka_incidenta = novoIzvješće.Vrijeme_početka_incidenta;
                novoIzvješće.Vrijeme_završetka_incidenta = novoIzvješće.Vrijeme_završetka_incidenta;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Izlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public Izvješće_o_incidentu novoIzvješće = null;

        PratiŠtićenika obj = (PratiŠtićenika)Application.OpenForms["PratiŠtićenika"];

        private void Spremi_Click(object sender, EventArgs e)
        {
            try
            {
                if (novoIzvješće == null)
                {
                    novoIzvješće = new Izvješće_o_incidentu();
                }
                novoIzvješće.Opis = UnosOpisaIncidenta.Text;
                novoIzvješće.Vrijeme_početka_incidenta = UnosVrijemePočetkaIncidenta.Value.Date.ToString("yyyy-MM-dd HH:MM:ss");
                novoIzvješće.Vrijeme_završetka_incidenta = UnosVrijemeZavršetkaIncidenta.Value.ToString("yyyy-MM-dd HH:MM:ss");
                novoIzvješće.ŠtićeniciOIB_Štićenika = odabraniSticenik.OIBSticenika;
                novoIzvješće.SkrbiteljiOIB_Skrbitelja = (UnosOIB_Skrbitelja.SelectedValue).ToString();
                novoIzvješće.Spremi();
                obj.OsvjeziIncidente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();

        }
      
    }
}
