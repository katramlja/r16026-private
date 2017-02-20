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
    public partial class Izbornik : Form
    {
  
        public Izbornik()
        {
            InitializeComponent();
        }

        private void Izbornik_Load(object sender, EventArgs e)
        {
            if (TrenutniKorisnik.Korisnik == "skrbitelj")
            {
                groupBox2.Visible = false;
                Uredi.Visible = false;
                PrikazSkrbitelji.Visible = false;
                PrikazRadnaKnjiga.Visible = false;
            }
        }

        private void DodajSticenika_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Sticenik"] as NoviSticenik == null)
            {
                NoviSticenik sticenik = new NoviSticenik();
                sticenik.MdiParent = ActiveForm;
                sticenik.Show();

            }
        }

        string trenutnoPrikazano = "";

        private void Izlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrikazSticenici_Click(object sender, EventArgs e)
        {
            trenutnoPrikazano = "sticenici";
            PostaviVelicinu();
            Prikaz.DataSource = Sticenik.DohvatiSticenikePoSkrbitelju(TrenutniKorisnik.OIBKorisnika);
            SakrijStupceSticenici(Prikaz);
            if (TrenutniKorisnik.Korisnik == "admin")
            {
                Prikaz.DataSource = Sticenik.DohvatiSticenike();
            }


         
        }

        public void OsvjeziSticenike()
        {
            Prikaz.DataSource = Sticenik.DohvatiSticenike();
        }

        private void PrikazOdjeli_Click(object sender, EventArgs e)
        {
            trenutnoPrikazano = "odjeli";
            PostaviVelicinu();
            List<Odjel> listaOdjela = Odjel.DohvatiOdjele();
            Prikaz.DataSource = listaOdjela;
            SakrijStupceSobe2(DodatniPrikaz);
   
        }

        private void PrikazSobe_Click(object sender, EventArgs e)
        {
            trenutnoPrikazano = "sobe";
            PostaviVelicinu();
            List<Soba> listaSoba = Soba.DohvatiSveSobe();
            Prikaz.DataSource = listaSoba;
            SakrijStupceSobe(Prikaz);
        }

        private void Prikaz_SelectionChanged(object sender, EventArgs e)
        {
            if (trenutnoPrikazano == "odjeli")
            {
                PrikaziSobeKojePripadajuOdjelima();
            }
            if (trenutnoPrikazano == "sobe")
            {
                PrikaziSticenikeKojiPripadajuSobama();
            }
            if (trenutnoPrikazano == "skrbitelji")
            {
                PrikaziSticenikePoSkrbiteljima();
            }
                 
        }
    
        private void PrikazSkrbitelji_Click(object sender, EventArgs e)
        {
            trenutnoPrikazano = "skrbitelji";
            PostaviVelicinu();
            List<Skrbitelj> listaSkrbitelja = Skrbitelj.DohvatiSkrbitelje();
            Prikaz.DataSource = listaSkrbitelja;
            SakrijStupceSkrbitelji(Prikaz);
        }

        public void OsvjeziSkrbitelje()
        {
            List<Skrbitelj> listaSkrbitelja = Skrbitelj.DohvatiSkrbitelje();
            Prikaz.DataSource = listaSkrbitelja;
        }

        private void PrikaziSobeKojePripadajuOdjelima()
        {

            List<Soba> listaSobaPoOdjelima = Soba.DohvatiSobeUOdjelu(Prikaz.CurrentRow.Cells[0].Value.ToString());
            DodatniPrikaz.DataSource = listaSobaPoOdjelima;
        }

        private void PrikaziSticenikeKojiPripadajuSobama()
        {
            List<Sticenik> listaSticenikaPoSobama = Sticenik.DohvatiSticenikeUSobi(Prikaz.CurrentRow.Cells[0].Value.ToString());
            DodatniPrikaz.DataSource = listaSticenikaPoSobama;
            SakrijStupceSticenici(DodatniPrikaz);
        }

        private void PrikaziSticenikePoSkrbiteljima()
        {
            List<Sticenik> listaSticenikaPoSkrbiteljima = Sticenik.DohvatiSticenikePoSkrbitelju(Prikaz.CurrentRow.Cells[0].Value.ToString());
            DodatniPrikaz.DataSource = listaSticenikaPoSkrbiteljima;
            SakrijStupceSticenici(DodatniPrikaz);
        }

        int visinaPrikaza, visinaDodatnogPrikaza;

        private void DohvatiVelicinuDataGrida_Tick(object sender, EventArgs e)
        {
            visinaPrikaza = Prikaz.Height;
            visinaDodatnogPrikaza = DodatniPrikaz.Height;
            PrikazSticenici_Click(sender, e);
            DohvatiVelicinuDataGrida.Enabled = false;
        }
        

        private void PostaviVelicinu()
        {
            if (trenutnoPrikazano == "sticenici")
            {
                Prikaz.Height = visinaPrikaza;
                DodatniPrikaz.Visible = false;
            }
            else
            {
                Prikaz.Height = visinaPrikaza - visinaDodatnogPrikaza - 10;
                DodatniPrikaz.Visible = true;
            }
        }

        public static NoviSticenik prikazInformacijaOSticeniku = null;
        public static NoviSkrbitelj prikazInformacijaOSkrbitelju = null;
       
        private void UrediSticenika_Click(object sender, EventArgs e)
        {

            if (Prikaz.RowCount > 1 && trenutnoPrikazano == "sticenici")
            {
                prikazInformacijaOSticeniku = new NoviSticenik();
                prikazInformacijaOSticeniku.MdiParent = ActiveForm;
                Sticenik odabraniSticenik = Prikaz.SelectedRows[0].DataBoundItem as Sticenik;
                prikazInformacijaOSticeniku.Show();
                prikazInformacijaOSticeniku.PrikazOdabranogSticenika(odabraniSticenik);

            }
            if (Prikaz.RowCount > 1 && trenutnoPrikazano == "skrbitelji")
            {
                prikazInformacijaOSkrbitelju = new NoviSkrbitelj();
                prikazInformacijaOSkrbitelju.MdiParent = ActiveForm;
                Skrbitelj odabraniSkrbitelj = Prikaz.SelectedRows[0].DataBoundItem as Skrbitelj;
                prikazInformacijaOSkrbitelju.Show();
                prikazInformacijaOSkrbitelju.PrikazOdabranogSkrbitelja(odabraniSkrbitelj);

            }
        }

        private void PraćenjeŠtićenika_Click(object sender, EventArgs e)
        {
            if (Prikaz.RowCount > 1)
            {
                PratiŠtićenika prati = new PratiŠtićenika();
                prati.MdiParent = ActiveForm;
                Sticenik odabraniSticenik = Prikaz.SelectedRows[0].DataBoundItem as Sticenik;
                prati.Show();
                prati.PrikazOdabranogSticenika(odabraniSticenik);

            }
        }

        public void SakrijStupceSticenici(DataGridView data)
        {
            
            data.Columns["Slika2"].Visible = false;
            data.Columns["MjestoIzdavanjaOsobne"].Visible = false;
            data.Columns["RazlogSmještaja"].Visible = false;
            data.Columns["Pusenje"].Visible = false;
            data.Columns["KontaktOsoba"].Visible = false;
            data.Columns["KontaktTelefon"].Visible = false;
            data.Columns["soba"].Visible = false;

            data.Columns["OIBSticenika"].HeaderText = "OIB";
            data.Columns["BrojOsobneIskazncie"].HeaderText = "Broj osobne iskaznice";
            data.Columns["MjestoRođenja"].HeaderText = "Mjesto rođenja";
            data.Columns["DatumRođenja"].HeaderText = "Datum rođenja";
            data.Columns["AdresaPrebivalista"].HeaderText = "Adresa";

        }

        private void SakrijStupceSkrbitelji(DataGridView data)
        {
            data.Columns["KorisnickoIme"].Visible = false;
            data.Columns["Lozinka"].Visible = false;
            data.Columns["ImeIPrezime"].Visible = false;

            data.Columns["OIBSkrbitelja"].HeaderText = "OIB";
        }

        private void SakrijStupceSobe(DataGridView data)
        {
            data.Columns["Odjel"].Visible = false;
        }

        private void SakrijStupceSobe2(DataGridView data)
        {
            data.Columns["ImeOdjela"].Visible = false;
        }

        private void DodajDjelatnika_Click_1(object sender, EventArgs e)
        {
            NoviSkrbitelj noviSkrbitelj = new NoviSkrbitelj();
            noviSkrbitelj.Show();
        }

        private void PrikazRadnaKnjiga_Click(object sender, EventArgs e)
        {
            RadnaKnjiga rk = new RadnaKnjiga();
            rk.Show();
        }
    }
}
