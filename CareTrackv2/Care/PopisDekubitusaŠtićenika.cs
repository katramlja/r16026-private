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
    public partial class PopisDekubitusaŠtićenika : Form
    {
        public PopisDekubitusaŠtićenika()
        {
            InitializeComponent();
        }
        public PopisDekubitusaŠtićenika(string OIBSticenika) {
            InitializeComponent();
            try {
                List<Sticenik> sticenici = Sticenik.DohvatiSticenike();
                foreach (Sticenik s in sticenici) {
                    if (s.OIBSticenika == OIBSticenika) {
                        this.Text = "Popis dekubitusa " + s.Ime + " " + s.Prezime;
                    }
                }
                //popisSvihDekubitusaŠtićenika.DataSource = Praćenje_dekubitusa.DohvatiPraćenjePremaOIBu(OIBSticenika);
            }
            catch (Exception ex){
                MessageBox.Show(ex.ToString());
            }
        }
       
        private void Odaberi_Click(object sender, EventArgs e)
        {
            try
            {                
                if (popisSvihDekubitusaŠtićenika.RowCount > 0)
                {
                    if (popisSvihDekubitusaŠtićenika.SelectedCells.Count == 1)
                    {
                        Praćenje_dekubitusa pd = popisSvihDekubitusaŠtićenika.SelectedRows[0].DataBoundItem as Praćenje_dekubitusa;
                        int idPraćenja = pd.ID_Praćenja_dekubitusa;
                        NoviDekubitus novi = new NoviDekubitus();
                        novi.PrikaziDekubitus(pd);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
