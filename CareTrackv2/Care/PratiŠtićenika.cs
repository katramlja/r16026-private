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

namespace Care
{
    public partial class PratiŠtićenika : Form
    {
        public PratiŠtićenika()
        {
            InitializeComponent();
        }
   
        public void PrikazOdabranogSticenika(Sticenik odabraniSticenik)
        {
            OdabraniSticenik = odabraniSticenik;
            try
            {
                try
                {
                    MemoryStream ms = new MemoryStream(Convert.FromBase64String(OdabraniSticenik.Slika2));
                    SlikaSticenika.Image = Image.FromStream(ms, true, true);
                }
                catch (Exception)
                {
                    SlikaSticenika.Image = null;
                }

                ImeSticenika.Text = OdabraniSticenik.Ime;
                PrezimeSticenika.Text = OdabraniSticenik.Prezime;
                string sqlUpit1 = "SELECT Sobe.Broj_sobe FROM Sobe WHERE ID_Sobe=" + OdabraniSticenik.soba;
                SobaSticenika.Text = (SQLServer.Instance.DohvatiVrijednost(sqlUpit1)).ToString();
                string sqlUpit = "SELECT Odjeli.Naziv_odjela from Odjeli, Sobe where ID_Sobe = " + OdabraniSticenik.soba;
                OdjelSticenika.Text = (SQLServer.Instance.DohvatiVrijednost(sqlUpit)).ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                MemoryStream ms = new MemoryStream(Convert.FromBase64String(OdabraniSticenik.Slika2));
                SlikaSticenika.Image = Image.FromStream(ms, true, true);
            }
            catch (Exception)
            {
                SlikaSticenika.Image = null;
            }
        }

        string trenutnoPrikazano = "";


        private void PratiDekubitus_Click(object sender, EventArgs e)
        {
            NoviDekubitus noviDekubitus = new NoviDekubitus(OdabraniSticenik);
            
            noviDekubitus.Show();
        }
        public Sticenik OdabraniSticenik;
        private void DodajMjerenje_Click(object sender, EventArgs e)
        {
            NovoMjerenje novoMjerenje = new NovoMjerenje(OdabraniSticenik);
            novoMjerenje.Show();
        }
        public Lijekovi_Štićenici lijek;
        public Lijek noviLijek;
        private void PotvrdaLijekova_Click(object sender, EventArgs e)
        {
            PotvrdaOUzimanjuLijekova novaPotvrda = new PotvrdaOUzimanjuLijekova(OdabraniSticenik, lijek, noviLijek);
            novaPotvrda.Show();
        }

        private void Izlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Izvješće_o_incidentu_Click(object sender, EventArgs e)
        {
            NovoIzvješće_o_incidentu novoIzvješće = new NovoIzvješće_o_incidentu(OdabraniSticenik);
            novoIzvješće.Show();
        }

        private void Mjerenja_Click(object sender, EventArgs e)
        {
            trenutnoPrikazano = "Mjerenje";
            List<Mjerenje> listamjerenja = Mjerenje.DohvatiMjerenje(OdabraniSticenik);
            PrikazPracenje.DataSource = listamjerenja;
            SakrijStupceMjerenja(PrikazPracenje);

        }

        public void OsvjeziMjerenje()
        {
            List<Mjerenje> listamjerenja = Mjerenje.DohvatiMjerenje(OdabraniSticenik);
            PrikazPracenje.DataSource = listamjerenja;
        }

        public void OsvjeziIncidente()
        {
            List<Izvješće_o_incidentu> listaIncidenata = Izvješće_o_incidentu.DohvatiIzvješćeOIncidentu(OdabraniSticenik);
            PrikazPracenje.DataSource = listaIncidenata;
        }

        public void OsvjeziDekubituse()
        {
            List<Praćenje_dekubitusa> listaPraćenjaDekubitusa = Praćenje_dekubitusa.DohvatiPraćenjeDekubitusa(OdabraniSticenik);
            PrikazPracenje.DataSource = listaPraćenjaDekubitusa;
        }

        public static NovoMjerenje prikazMjerenja = null;
        public static NoviDekubitus prikazDekubitusa = null;

        private void PrikazPracenje_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (PrikazPracenje.RowCount > 1 && trenutnoPrikazano=="Mjerenje")
            {
                prikazMjerenja = new NovoMjerenje();
                Mjerenje odabranoMjerenje = PrikazPracenje.SelectedRows[0].DataBoundItem as Mjerenje;
                prikazMjerenja.Show();
                prikazMjerenja.PrikaziMjerenje(odabranoMjerenje);
            }

            if (PrikazPracenje.RowCount > 1 && trenutnoPrikazano == "Dekubitusi")
            {
                prikazDekubitusa = new NoviDekubitus();
                Praćenje_dekubitusa odabraniDekubitus = PrikazPracenje.SelectedRows[0].DataBoundItem as Praćenje_dekubitusa;
                prikazDekubitusa.Show();
                prikazDekubitusa.PrikaziDekubitus(odabraniDekubitus);
            }
        }

        public void SakrijStupceMjerenja(DataGridView data)
        {
            data.Columns["ID_Mjerenja"].Visible=false;
            data.Columns["Velika_nužda"].Visible = false;
            data.Columns["Količina_urina"].Visible = false;
            data.Columns["Disanje"].Visible = false;
            data.Columns["Bol"].Visible = false;
            data.Columns["ŠtićeniciOIB_Štićenika"].Visible = false;
        }

        public void SakrijStupceIncidenti(DataGridView data)
        {
            data.Columns["ŠtićeniciOIB_Štićenika"].Visible = false;
            data.Columns["SkrbiteljiOIB_Skrbitelja"].Visible = false;
            data.Columns["ID_Izvješća"].Visible = false;
        }

        public void SakrijStupceDekubitusi(DataGridView data)
        {
            data.Columns["ID_Praćenja_dekubitusa"].Visible = false;
            data.Columns["DekubitusiID_Dekubitusa"].Visible = false;
            data.Columns["Slika"].Visible = false;
        }

        private void Incidenti_Click(object sender, EventArgs e)
        {
            trenutnoPrikazano = "Incidenti";
            List<Izvješće_o_incidentu> listaIncidenti = Izvješće_o_incidentu.DohvatiIzvješćeOIncidentu(OdabraniSticenik);
            PrikazPracenje.DataSource = listaIncidenti;
            SakrijStupceIncidenti(PrikazPracenje);
        }

        private void Dekubitusi_Click(object sender, EventArgs e)
        {
            trenutnoPrikazano = "Dekubitusi";
            List<Praćenje_dekubitusa> listaDekubitusa = Praćenje_dekubitusa.DohvatiPraćenjeDekubitusa(OdabraniSticenik);
            PrikazPracenje.DataSource = listaDekubitusa;
            SakrijStupceDekubitusi(PrikazPracenje);
        }
    }
}
