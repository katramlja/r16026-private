using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

namespace Care
{
    public partial class NoviSticenik : Form
    { 

        List<Sticenik> listaSticenika = new List<Sticenik>();

        public NoviSticenik()
        {
            InitializeComponent();
            UkloniSticenika.Visible = false;
            DodajLijekove.Enabled = true;
            DodajSliku.Enabled = true;
            Izlaz.Enabled = true;
            Spremi.Enabled = true;
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
            Provjeri(UnosIme,NazivIme);
        }

        private void UnosPrezime_TextChanged(object sender, EventArgs e)
        {
            Provjeri(UnosPrezime,NazivPrezime);
        }

        private void UnosOIB_TextChanged(object sender, EventArgs e)
        {
            Provjeri(UnosOIB,NazivOIB);
        }

        private void UnosMjestoRodenja_TextChanged(object sender, EventArgs e)
        {
            Provjeri(UnosMjestoRodenja,NazivMjestoRodenja);
        }

        private void UnosBrOsobne_TextChanged(object sender, EventArgs e)
        {
            Provjeri(UnosBrOsobne,NazivBrOsobne);
        }


        private void UnosAdresaPrebivalista_TextChanged(object sender, EventArgs e)
        {
            Provjeri(UnosAdresaPrebivalista,NazivAdresaPrebivalista);
        }

        private void UnosTelefon_TextChanged(object sender, EventArgs e)
        {
            Provjeri(UnosTelefon,NazivTelefon);
        }

        private void UnosKontaktOsoba_TextChanged(object sender, EventArgs e)
        {
            Provjeri(UnosKontaktOsoba,NazivKontaktOsoba);
        }

        private void UnosTelKontaktOsobe_TextChanged(object sender, EventArgs e)
        {
            Provjeri(UnosTelKontaktOsobe,NazivTelKontaktOsobe);
        }

        private void UnosRazlogSmjestaja_TextChanged(object sender, EventArgs e)
        {
            Provjeri(UnosRazlogSmjestaja,NazivRazlogSmjestaja);
        }

        private void UnosMjestoIzdavanjaOsobne_TextChanged(object sender, EventArgs e)
        {
            Provjeri(UnosMjestoIzdavanjaOsobne,NazivMjestoIzdavanjaOsobne);
        }

        private void Izlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NazivIme_Click(object sender, EventArgs e)
        {
            ActiveControl = UnosIme;
        }

        private void Sticenik_Load(object sender, EventArgs e)
        {

            OdabirOdjela.DataSource = Odjel.DohvatiOdjele();
            OdabirSobe.DataSource = Soba.DohvatiSobeUOdjelu(OdabirOdjela.SelectedValue.ToString());
            OdabirSkrbitelja.DataSource = Skrbitelj.DohvatiSkrbitelje();
            
           Odjel odabraniOdjel = OdabirOdjela.SelectedItem as Odjel;

            OdabirSobe.DataSource = Soba.DohvatiSobe(odabraniOdjel);

            if (noviSticenik != null)
            {
                UnosIme.Text = noviSticenik.Ime;
                UnosPrezime.Text = noviSticenik.Prezime;
                UnosOIB.Text = noviSticenik.OIBSticenika.ToString();
                UnosMjestoRodenja.Text = noviSticenik.MjestoRođenja;
                UnosBrOsobne.Text = noviSticenik.BrojOsobneIskazncie;
                UnosMjestoIzdavanjaOsobne.Text = noviSticenik.MjestoIzdavanjaOsobne;
                UnosAdresaPrebivalista.Text = noviSticenik.AdresaPrebivalista;
                UnosTelefon.Text = noviSticenik.Telefon.ToString();
                UnosKontaktOsoba.Text = noviSticenik.KontaktOsoba;
                UnosTelKontaktOsobe.Text = noviSticenik.KontaktTelefon.ToString();
                UnosRazlogSmjestaja.Text = noviSticenik.RazlogSmještaja;
            }

                
        }

        private void NazivRazlogSmjestaja_Click(object sender, EventArgs e)
        {
            ActiveControl = UnosRazlogSmjestaja;
        }

        private void NazivPrezime_Click(object sender, EventArgs e)
        {
            ActiveControl = UnosPrezime;
        }

        private void NazivOIB_Click(object sender, EventArgs e)
        {
            ActiveControl = UnosOIB;
        }

        private void NazivMjestoRodenja_Click(object sender, EventArgs e)
        {
            ActiveControl = UnosMjestoRodenja;
        }

        private void NazivBrOsobne_Click(object sender, EventArgs e)
        {
            ActiveControl = UnosBrOsobne;
        }

        private void NazivAdresaPrebivalista_Click(object sender, EventArgs e)
        {
            ActiveControl = UnosAdresaPrebivalista;
        }

        private void NazivKontaktOsoba_Click(object sender, EventArgs e)
        {
            ActiveControl = UnosKontaktOsoba;
        }

        private void NazivTelKontaktOsobe_Click(object sender, EventArgs e)
        {
            ActiveControl = UnosTelKontaktOsobe;
        }

        private void NazivTelefon_Click(object sender, EventArgs e)
        {
            ActiveControl = UnosTelefon;
        }

        private void NazivMjestoIzdavanjaOsobne_Click(object sender, EventArgs e)
        {
            ActiveControl = UnosMjestoIzdavanjaOsobne;
        }

        private void UnosOIB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void UnosBrOsobne_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void UnosTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }



        List<Skrbitelj> listaSkrbitelja = new List<Skrbitelj>();

        private void DodajSkrbitelja_Click(object sender, EventArgs e)
        {
            if (!listaSkrbitelja.Contains(OdabirSkrbitelja.SelectedItem) && OdabirSkrbitelja.SelectedIndex!=-1)
            {
                Skrbitelj sk = new Skrbitelj();
                sk = OdabirSkrbitelja.SelectedItem as Skrbitelj;
                listaSkrbitelja.Add(sk);

                DodaniSkrbitelji.DataSource = null;
                DodaniSkrbitelji.DataSource = listaSkrbitelja;
                DodaniSkrbitelji.DisplayMember = "ImeIPrezime";

            }

        }


        private Štićenici_Težina težinaŠtićenika;
        private void DodajTežinu()
        {
            if (težinaŠtićenika == null)
            {
                težinaŠtićenika= new Štićenici_Težina();
            }
            težinaŠtićenika.Datum_mjerenja= UnosDatumaMjerenja.Value.Date.ToString("yyyyMMdd");
            težinaŠtićenika.Težina = Convert.ToDouble(UnosTezine.Text);
            težinaŠtićenika.ŠtićeniciOIB_Štićenika = noviSticenik.OIBSticenika;
            težinaŠtićenika.Spremi();
        }

        private Štićenici_Visine visinaŠtićenika;
        private void DodajVisinu()
        {
            if (visinaŠtićenika == null)
            {
                visinaŠtićenika = new Štićenici_Visine();
            }
            visinaŠtićenika.Datum_mjerenja = UnosDatumaMjerenja.Value.Date.ToString("yyyyMMdd");
            visinaŠtićenika.Visina = double.Parse(UnosVisine.Text);
            visinaŠtićenika.ŠtićeniciOIB_Štićenika = noviSticenik.OIBSticenika;
            visinaŠtićenika.Spremi();
        }
       

        private void UkloniSkrbitelja_Click(object sender, EventArgs e)
        {
            if (DodaniSkrbitelji.SelectedIndex != -1)
                listaSkrbitelja.Remove(DodaniSkrbitelji.SelectedItem as Skrbitelj);
            DodaniSkrbitelji.DataSource = null;
            DodaniSkrbitelji.DataSource = listaSkrbitelja;
            DodaniSkrbitelji.DisplayMember = "ImeIPrezime";
        }


        private void UnosTezine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void UnosVisine_TextChanged(object sender, EventArgs e)
        {
            IndeksTjelesneMase.Text = IzracunajITM(UnosVisine.Text,UnosTezine.Text).ToString();
        }
        private string IzracunajITM(string visina, string tezina)
        {
            double ITM = 0;
            if (UnosVisine.Text != "" && UnosTezine.Text != "")
            {
                ITM = double.Parse(tezina) / (double.Parse(visina)/100 * double.Parse(visina)/100);
            }
            string stanje = "";
            if (ITM < 20) stanje = "Pothranjenost";
            if (ITM >= 20 && ITM <= 25) stanje = "Idealno stanje";
            if (ITM >= 25 && ITM <= 30) stanje = "Prekomjerena masa";
            if (ITM > 30) stanje = "Pretilost";
            ITM = Math.Round(ITM,1);
            return ITM.ToString()+ ": " +stanje;
        }

        private void UnosTezine_TextChanged(object sender, EventArgs e)
        {
            IndeksTjelesneMase.Text = IzracunajITM(UnosVisine.Text, UnosTezine.Text).ToString();
        }
        
        Izbornik obj = (Izbornik)Application.OpenForms["Izbornik"];
       
        private Sticenik noviSticenik = null;

        private void Spremi_Click(object sender, EventArgs e)
        {
            string greska = "";
            if (UnosIme.Text == "") greska += "Ime\n";
            if (UnosPrezime.Text == "") greska += "Prezime\n";
            if (UnosOIB.Text == "") greska += "OIB\n";
            if (UnosMjestoRodenja.Text == "") greska += "Mjesto rođenja\n";
            if (UnosBrOsobne.Text == "") greska += "Broj osobne iskaznice\n";
            if (UnosMjestoIzdavanjaOsobne.Text == "") greska += "Mjesto izdavanja osobne\n";
            if (UnosAdresaPrebivalista.Text == "") greska += "Adresa prebivališta\n";
            if (UnosTelefon.Text == "") greska += "Telefon\n";
                        
            if (greska == "")
            {
                if (noviSticenik == null)
                {
                    noviSticenik = new Sticenik();
                }
                noviSticenik.Ime = UnosIme.Text;
                noviSticenik.Prezime = UnosPrezime.Text;
                noviSticenik.OIBSticenika = UnosOIB.Text;
                noviSticenik.MjestoRođenja = UnosMjestoRodenja.Text;
                noviSticenik.DatumRođenja = UnosDatumRodenja.Value.Date.ToString("yyyyMMdd");
                noviSticenik.BrojOsobneIskazncie = UnosBrOsobne.Text;
                noviSticenik.MjestoIzdavanjaOsobne = UnosMjestoIzdavanjaOsobne.Text;
                noviSticenik.AdresaPrebivalista = UnosAdresaPrebivalista.Text;
                noviSticenik.Telefon = UnosTelefon.Text;
                noviSticenik.KontaktOsoba = UnosKontaktOsoba.Text;
                noviSticenik.KontaktTelefon = UnosTelKontaktOsobe.Text;
                if (radioButton1.Checked == true)
                {
                    noviSticenik.Pusenje = true;
                }
                else noviSticenik.Pusenje = false;
                noviSticenik.RazlogSmještaja = UnosRazlogSmjestaja.Text;
                noviSticenik.soba = int.Parse(OdabirSobe.SelectedValue.ToString());
                try
                {
                    noviSticenik.Slika2 = Convert.ToBase64String(File.ReadAllBytes(dialog.FileName));
                }
                catch(Exception)
                {
                    //noviSticenik.Slika2 = null;
                }
                noviSticenik.Spremi();
                obj.OsvjeziSticenike();
                noviSticenik.SpremiSkrbitelje(listaSkrbitelja);
                DodajTežinu();
                DodajVisinu();
                OcistiUnose();
                
            }
            else
            {
              MessageBox.Show("Neki podaci nisu ispravno uneseni:\n"+greska, "Greška! Unesite ponovno podatke.",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }            
        }
        public void OcistiUnose() {
            UnosIme.Clear();
            UnosPrezime.Clear();
            UnosOIB.Clear();
            UnosMjestoRodenja.Clear();
            UnosBrOsobne.Clear();
            UnosMjestoIzdavanjaOsobne.Clear();
            UnosAdresaPrebivalista.Clear();
            SlikaSticenika.Image = null;
            UnosTelefon.Clear();
            UnosKontaktOsoba.Clear();
            UnosTelKontaktOsobe.Clear();
            if (radioButton1.Checked == true)
            {
                radioButton1.Checked = false;
            }
            else radioButton2.Checked = false;
            UnosRazlogSmjestaja.Clear();
            UnosTezine.Clear();
            UnosVisine.Clear();
            DodaniSkrbitelji.DataSource = null;
            listaSkrbitelja = null;
        }
        MemoryStream ms;
        public static int duljinaZapisaSlike;
        OpenFileDialog dialog = new OpenFileDialog();
     
        
        private void DodajSliku_Click(object sender, EventArgs e)
        {        
            try
            {
                dialog.Filter = "jpeg|*.jpg|bmp|*.bmp|png|*.png";
                DialogResult rezultat = dialog.ShowDialog();
                if (rezultat == DialogResult.OK)
                {
                   SlikaSticenika.Image = Image.FromFile(dialog.FileName);
                   duljinaZapisaSlike = dialog.FileName.Length;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OdabirOdjela_SelectedIndexChanged(object sender, EventArgs e)
        {
            OdabirSobe.DataSource = Soba.DohvatiSobeUOdjelu(OdabirOdjela.SelectedValue.ToString());
            
        }

        public Sticenik OdabraniSticenik;
  
        public void PrikazOdabranogSticenika(Sticenik odabraniSticenik)
        {
            UkloniSticenika.Visible = true;
            OdabraniSticenik = odabraniSticenik;
            try
            {
                try
                {
                    MemoryStream ms = new MemoryStream(Convert.FromBase64String(OdabraniSticenik.Slika2));
                    SlikaSticenika.Image = Image.FromStream(ms, true, true);
                }
                catch(Exception)
                {
                    SlikaSticenika.Image = null;
                }

                UnosIme.Text = OdabraniSticenik.Ime;
                UnosPrezime.Text = OdabraniSticenik.Prezime;
                UnosOIB.Text = OdabraniSticenik.OIBSticenika;
                UnosDatumRodenja.Text = OdabraniSticenik.DatumRođenja;
                UnosMjestoRodenja.Text = OdabraniSticenik.MjestoRođenja;
                UnosBrOsobne.Text = OdabraniSticenik.BrojOsobneIskazncie;
                UnosMjestoIzdavanjaOsobne.Text = OdabraniSticenik.MjestoIzdavanjaOsobne;
                UnosAdresaPrebivalista.Text = OdabraniSticenik.AdresaPrebivalista;
                UnosTelefon.Text = OdabraniSticenik.Telefon;
                UnosKontaktOsoba.Text = OdabraniSticenik.KontaktOsoba;
                UnosTelKontaktOsobe.Text = OdabraniSticenik.KontaktTelefon;
                UnosRazlogSmjestaja.Text = OdabraniSticenik.RazlogSmještaja;
                string sqlUpit = "SELECT OdjeliID_Odjela from Sobe where ID_Sobe = " + OdabraniSticenik.soba;
                OdabirOdjela.SelectedValue = SQLServer.Instance.DohvatiVrijednost(sqlUpit);

                sqlUpit = "Select Težina from Štićenici_Težina where ŠtićeniciOIB_Štićenika = '" + OdabraniSticenik.OIBSticenika+"'";
                UnosTezine.Text = SQLServer.Instance.DohvatiVrijednost(sqlUpit).ToString();

                sqlUpit= "Select Visina from Štićenici_Visine where ŠtićeniciOIB_Štićenika = '" + OdabraniSticenik.OIBSticenika+"'";
                UnosVisine.Text = SQLServer.Instance.DohvatiVrijednost(sqlUpit).ToString();

                OdabirSobe.SelectedValue = OdabraniSticenik.soba;

                listaSkrbitelja = Skrbitelj.DohvatiSkrbiteljeOdSticenika(odabraniSticenik.OIBSticenika);
                DodaniSkrbitelji.DataSource = listaSkrbitelja;
                DodaniSkrbitelji.DisplayMember="ImeIPrezime";

                if (OdabraniSticenik.Pusenje == true)
                {
                    radioButton1.Checked = true;
                }
                else radioButton2.Checked = true;
                OdabirSobe.Text = OdabraniSticenik.soba.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
          private void DodajDekubitus_Click(object sender, EventArgs e)
        {
            NoviDekubitus noviDekubitus = new NoviDekubitus();
            noviDekubitus.Show();
        }

        private void UkloniSticenika_Click(object sender, EventArgs e)
        {
           if (noviSticenik == null)
            {
                noviSticenik = new Sticenik();
            }
            noviSticenik.OIBSticenika = UnosOIB.Text;
            noviSticenik.Obrisi();
            obj.OsvjeziSticenike();

            this.Close();
        }

        private void DodajLijekove_Click(object sender, EventArgs e)
        {
            LijekŠtićenik noviLijek = new LijekŠtićenik(UnosOIB.Text);
            noviLijek.Show();
        }

        private void UnosVisine_KeyPress(object sender, KeyPressEventArgs e)
        {
                    
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }

        }

    }

    }