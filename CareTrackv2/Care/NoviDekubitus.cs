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
    public partial class NoviDekubitus : Form
    {
        public NoviDekubitus()
        {
            InitializeComponent();
        }
        public string OIBOdabranogSticenika;
        public NoviDekubitus(Sticenik OdabraniSticenik)
        {
            InitializeComponent();
            OIBOdabranogSticenika = OdabraniSticenik.OIBSticenika;
            Sticenik odabraniSticenik = OdabraniSticenik;
            UnosŠtićenikaDekubitusa.Text = odabraniSticenik.Ime + " " + odabraniSticenik.Prezime;
            OdgovorniSkrbitelj.DataSource = Skrbitelj.DohvatiSkrbitelje();
            OdgovorniSkrbitelj.ValueMember = "OIBSkrbitelja";
            OdgovorniSkrbitelj.DisplayMember = "ImeIPrezime";
        }

        private void PraćenjeDekubitusaOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private  Praćenje_dekubitusa novoPraćenje= null;
        private Dekubitus noviDekubitus=null;

        bool update = false;

        private void PraćenjeDekubitusaDodaj_Click(object sender, EventArgs e)
        {
           
                if (novoPraćenje == null )
                {
                    novoPraćenje = new Praćenje_dekubitusa();
                    
                }

                if (noviDekubitus == null)
                {
                    noviDekubitus = new Dekubitus();
                }
                DateTime dat = PraćenjeDekubitusaDatumNastanka.Value;
                novoPraćenje.Datum_nastanka = dat.ToString("yyyyMMdd");
                novoPraćenje.Lokacija_dekubitusa = PraćenjeDekubitusaLokacija.Text;
                novoPraćenje.Opis_dekubitusa = PraćenjeDekubitusaOpis.Text;

                noviDekubitus.SkrbiteljiOIB_Skrbitelja = (OdgovorniSkrbitelj.SelectedValue).ToString();
                noviDekubitus.ŠtićeniciOIB_Štićenika = OIBOdabranogSticenika;
                try
                {
                    novoPraćenje.Slika = Convert.ToBase64String(File.ReadAllBytes(dialog.FileName));
                }

                catch (Exception ex) 
                {
                MessageBox.Show(ex.Message);
                }

                int IDDekubitusa;

                if (update == false)
                {
                    noviDekubitus.Spremi();
                    string upit = "select max(ID_Dekubitusa) from dekubitusi";
                    IDDekubitusa = int.Parse(SQLServer.Instance.DohvatiVrijednost(upit).ToString());
                    novoPraćenje.Spremi(IDDekubitusa);
                }
                else novoPraćenje.Spremi(d.DekubitusiID_Dekubitusa);

            
                obj.OsvjeziDekubituse();
                this.Close();
           
            
        }

        PratiŠtićenika obj = (PratiŠtićenika)Application.OpenForms["PratiŠtićenika"];

        MemoryStream ms;
        public static int duljinaZapisaSlikeDekubitus;
        OpenFileDialog dialog = new OpenFileDialog();
      
        private void PraćenjeDekubitusaDodajSlike_Click(object sender, EventArgs e)
        {
            try
            {
                dialog.Filter = "jpeg|*.jpg|bmp|*.bmp|png|*.png";
                DialogResult rezultat = dialog.ShowDialog();
                if (rezultat == DialogResult.OK)
                {
                    PraćenjeDekubitusaSlika1.Image = Image.FromFile(dialog.FileName);
                    duljinaZapisaSlikeDekubitus = dialog.FileName.Length;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        Praćenje_dekubitusa d = new Praćenje_dekubitusa();

        public void PrikaziDekubitus(Praćenje_dekubitusa dekubitus)
        {
            d = dekubitus;
            update = true;
            UnosŠtićenikaDekubitusa.Visible = false;
            KrajDekubitusa.Visible = true;
            label5.Visible = false;

            PraćenjeDekubitusaDodaj.Text = "Pohrani promjene";
            try
                {
                    MemoryStream ms = new MemoryStream(Convert.FromBase64String(dekubitus.Slika));
                    PraćenjeDekubitusaSlika1.Image = Image.FromStream(ms, true, true);
                }
                catch (Exception)
                {
                    //PraćenjeDekubitusaSlika1.Image = null;
                }
            PraćenjeDekubitusaDatumNastanka.Text = dekubitus.Datum_nastanka;
            string sqlUpit = "SELECT Dekubitusi.SkrbiteljiOIB_Skrbitelja FROM Dekubitusi,Praćenje_dekubitusa WHERE Dekubitusi.ID_Dekubitusa= " + dekubitus.DekubitusiID_Dekubitusa;
            OdgovorniSkrbitelj.DataSource = Skrbitelj.DohvatiSkrbitelje();
            OdgovorniSkrbitelj.SelectedValue = SQLServer.Instance.DohvatiVrijednost(sqlUpit);
          
            string sqlUpit2 = "SELECT Dekubitusi.ŠtićeniciOIB_Štićenika FROM Dekubitusi,Praćenje_dekubitusa WHERE Dekubitusi.ID_Dekubitusa= " + dekubitus.DekubitusiID_Dekubitusa;
            OIBOdabranogSticenika = SQLServer.Instance.DohvatiVrijednost(sqlUpit2).ToString();
          
            PraćenjeDekubitusaLokacija.Text = dekubitus.Lokacija_dekubitusa;
            PraćenjeDekubitusaOpis.Text = dekubitus.Opis_dekubitusa;

            
         }
        

        private void NoviDekubitus_Load(object sender, EventArgs e)
        {
            KrajDekubitusa.Visible = false;
            PraćenjeDekubitusaDodaj.Text = "U redu";
        }

        private void KrajDekubitusa_Click(object sender, EventArgs e)
        {
            novoPraćenje = new Praćenje_dekubitusa();
            DateTime dat2 = DateTime.Now;
            string sqlUpit = "UPDATE Praćenje_dekubitusa SET Datum_prestanka = '" + dat2.ToString("yyyyMMdd") + "' WHERE DekubitusiID_Dekubitusa = '"+d.DekubitusiID_Dekubitusa+"'";
            SQLServer.Instance.IzvrsiUpit(sqlUpit);
            this.Close();
        }
    
    }
}
