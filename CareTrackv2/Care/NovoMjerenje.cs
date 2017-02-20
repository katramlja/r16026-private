using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Care
{
    public partial class NovoMjerenje : Form
    {

        public NovoMjerenje()
        {
            InitializeComponent();
        }
        public NovoMjerenje(Sticenik OdabraniSticenik) {
            InitializeComponent();
            OIBSticenika.Text = OdabraniSticenik.OIBSticenika;
            OIBSticenika.Visible = false;
        }
       
        private void Mjerenja_Load(object sender, EventArgs e)
        {
            DatumMjerenja.Text = DateTime.Now.ToString();
            SakrijZnakove();
        }

        private void IzlazIzMjerenja_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SakrijZnakove()
        {
            TlakDobar.Visible = false;
            TlakLos.Visible = false;
            PulsDobar.Visible = false;
            PulsLos.Visible = false;
            TempDobra.Visible = false;
            TempLosa.Visible = false;
            SecerDobar.Visible = false;
            SecerLos.Visible = false;
        }

        PratiŠtićenika obj = (PratiŠtićenika)Application.OpenForms["PratiŠtićenika"];

        private void DodajMjerenje_Click(object sender, EventArgs e)
        {
            SakrijZnakove();
           try
            {
                Mjerenje novoMjerenje = new Mjerenje();
                DateTime dat = DateTime.Now;
                novoMjerenje.DatumIVrijeme = dat.ToString("yyyy-MM-dd HH:MM:ss");
                if (NjegaNijeObavljena.Checked == true)
                 {
                    novoMjerenje.Njega_tijela = false;
                 }
                 else novoMjerenje.Njega_tijela = true;
                 if (PeleneNisuPromjenjene.Checked == true)
                 {
                     novoMjerenje.Pelene = false;
                 }
                 else novoMjerenje.Pelene = true;
                 novoMjerenje.Tlak = float.Parse(UnosTlak.Text);
                 novoMjerenje.Puls = float.Parse(UnosPuls.Text);
                 novoMjerenje.Temperatura = float.Parse(UnosTemperatura.Text);
                 novoMjerenje.Disanje = UnosDisanje.Text;
                 novoMjerenje.Velika_nužda = UnosNužda.Text;
                 novoMjerenje.Količina_urina = UnosUrin.Text;
                 novoMjerenje.Bol = UnosBol.Text;
                 novoMjerenje.Šećer = float.Parse(UnosŠećer.Text);
                 novoMjerenje.ŠtićeniciOIB_Štićenika = OIBSticenika.Text;
                 novoMjerenje.Spremi();
                 MessageBox.Show("Uspješno ste unjeli mjerenje!");
                 obj.OsvjeziMjerenje();
                 this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void PrikaziMjerenje(Mjerenje OdabranoMjerenje)
            {
                DatumMjerenja.Text = OdabranoMjerenje.DatumIVrijeme;
                UnosTlak.Text = OdabranoMjerenje.Tlak.ToString();
                UnosPuls.Text = OdabranoMjerenje.Puls.ToString();
                UnosTemperatura.Text = OdabranoMjerenje.Temperatura.ToString();
                UnosDisanje.Text = OdabranoMjerenje.Disanje;
                UnosNužda.Text = OdabranoMjerenje.Velika_nužda;
                UnosUrin.Text = OdabranoMjerenje.Količina_urina;
                UnosBol.Text = OdabranoMjerenje.Bol;
                UnosŠećer.Text = OdabranoMjerenje.Šećer.ToString();

                if (OdabranoMjerenje.Njega_tijela == true)
                    NjegaObavljena.Checked = true;
                else
                    NjegaNijeObavljena.Checked = true;

                if (OdabranoMjerenje.Pelene == true)
                    PelenePromjenjene.Checked = true;
                else
                    PeleneNisuPromjenjene.Checked = true;
                DodajMjerenje.Visible = false;

            }

        private void UnosTlak_TextChanged(object sender, EventArgs e)
        {
            if (UnosTlak.Text == "")
            {
                TlakDobar.Visible = false;
                TlakLos.Visible = false;
                return;
            }

            if (float.Parse(UnosTlak.Text) < 140)
            {
                TlakDobar.Visible = true;
                TlakLos.Visible = false;
            }
            else
            {
                TlakDobar.Visible = false;
                TlakLos.Visible = true;
            }
        }

        private void UnosPuls_TextChanged(object sender, EventArgs e)
        {
            if (UnosPuls.Text == "")
            {
                PulsDobar.Visible = false;
                PulsLos.Visible = false;
                return;
            }
            if ((float.Parse(UnosPuls.Text) >= 60) && (float.Parse(UnosPuls.Text) <= 100))
            {
                PulsDobar.Visible = true;
                PulsLos.Visible = false;
            }
            else
            {
                PulsDobar.Visible = false;
                PulsLos.Visible = true;
            }
        }

        private void UnosTemperatura_TextChanged(object sender, EventArgs e)
        {
            if (UnosTemperatura.Text == "")
            {
                TempDobra.Visible = false;
                TempLosa.Visible = false;
                return;
            }

            if ((float.Parse(UnosTemperatura.Text) >= 36) && (float.Parse(UnosTemperatura.Text) <= 37))
            {
                TempDobra.Visible = true;
                TempLosa.Visible = false;
            }
            else
            {
                TempDobra.Visible = false;
                TempLosa.Visible = true;
            }
        }

        private void UnosŠećer_TextChanged(object sender, EventArgs e)
        {
            if (UnosŠećer.Text == "")
            {
                SecerDobar.Visible = false;
                SecerLos.Visible = false;
                return;
            }

            if ((float.Parse(UnosŠećer.Text) >= 3.8) && (float.Parse(UnosŠećer.Text) <= 6.9))
            {
                SecerDobar.Visible = true;
                SecerLos.Visible = false;
            }
            else
            {
                SecerDobar.Visible = false;
                SecerLos.Visible = true;
            }
        }
    }
}
