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
    public partial class RadnaKnjiga : Form
    {
        public RadnaKnjiga()
        {
            InitializeComponent();
        }
        
        private void Uredu_Click(object sender, EventArgs e)
        {
            List<Sticenik> listaSticenika = Sticenik.DohvatiSticenikePoSkrbitelju(OdabirSkrbitelja.SelectedValue.ToString());
            PrikazSticenici.DataSource = listaSticenika;

            Izbornik i = new Izbornik();
            i.SakrijStupceSticenici(PrikazSticenici);
        }

        private void RadnaKnjiga_Load(object sender, EventArgs e)
        {
            OdabirSkrbitelja.DataSource = Skrbitelj.DohvatiSkrbitelje();
        }


        private void PrikazSticenici_SelectionChanged(object sender, EventArgs e)
        {
            List<Mjerenje> listaMjerenja = Mjerenje.DohvatiMjerenjePoDatumuISticeniku(PrikazSticenici.CurrentRow.DataBoundItem as Sticenik, OdabirDatuma.Value);
            PrikazMjerenja.DataSource = listaMjerenja;
            PratiŠtićenika ps = new PratiŠtićenika();
            ps.SakrijStupceMjerenja(PrikazMjerenja);

            List<Izvješće_o_incidentu> listaIzvjesca = Izvješće_o_incidentu.DohvatiIzvješćeOIncidentuPoDatumuISticeniku(PrikazSticenici.CurrentRow.DataBoundItem as Sticenik, OdabirDatuma.Value);
            PrikazIncidenti.DataSource = listaIzvjesca;
            ps.SakrijStupceIncidenti(PrikazIncidenti);

            List<Praćenje_dekubitusa> listaPraćenjaDekubitusa = Praćenje_dekubitusa.DohvatiDekubitusPoŠtićenikuIDatumu(PrikazSticenici.CurrentRow.DataBoundItem as Sticenik, OdabirDatuma.Value);
            PrikazDekubitus.DataSource = listaPraćenjaDekubitusa;
            ps.SakrijStupceDekubitusi(PrikazDekubitus);
        }

        private void Izlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
