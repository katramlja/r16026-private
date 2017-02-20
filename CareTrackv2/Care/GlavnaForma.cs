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
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
        }

        public Form RefPrijava { get; set; }

        private void GlavnaForma_Load(object sender, EventArgs e)
        {
            PrikaziIzbornik_Click(sender, e);
            foreach (var c in Controls)
            {
                if (c is MdiClient)
                {
                    var glavnaForma = (MdiClient)c;
                    glavnaForma.BackColor = Color.LightCyan;
                    return;
                }
            }

        }

        private void GlavnaForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefPrijava.Show();
        }

        private void Odjava_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void DodajSticenika_Click(object sender, EventArgs e)
        {
           if (Application.OpenForms["Sticenik"] as NoviSticenik == null)
           {
                NoviSticenik sticenik = new NoviSticenik();
                sticenik.MdiParent = this;
                sticenik.Show();
                PostaviVelicinu(sticenik);
           }
        }

        private void DodajDjelatnika_Click(object sender, EventArgs e)
        {

        }

        private void DodajOdjele_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Odjeli"] as NoviOdjel == null)
            {
                NoviOdjel odjel = new NoviOdjel();
                odjel.MdiParent = this;
                odjel.Show();
            }
        }

        private void DodajSobe_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Sobe"] as NovaSoba == null)
            {
                NovaSoba soba = new NovaSoba();
                soba.MdiParent = this;
                soba.Show();
            }

        }

        private void DodajAlergije_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Alergije"] as NovaAlergija == null)
            {
                NovaAlergija alergija = new NovaAlergija();
                alergija.MdiParent = this;
                alergija.Show();
            }

        }
        
        private void DodajLijekove_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Lijekovi"] as NoviLijek == null)
            {
                NoviLijek lijek = new NoviLijek();
                lijek.MdiParent = this;
                lijek.Show();
            }


        }

        private void KrajRada_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PrikaziIzbornik_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["Izbornik"] as Izbornik == null)
            {
                Izbornik izbornik = new Izbornik();
                izbornik.MdiParent = this;
                izbornik.Show();
                PostaviVelicinu(izbornik);

            }
        }
        private void PostaviVelicinu(Form forma)
        {
            forma.Height = this.Height - 66;
            forma.Width = this.Width - 20;
        }

        private void dekubitusaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PretraživanjeDekubitusa novoPretraživanje = new PretraživanjeDekubitusa();
            novoPretraživanje.Show();
        }

        private void mjerenjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikažiMjerenje noviPrikaz = new PrikažiMjerenje();
            noviPrikaz.Show();
        }

        private void izvješćaOIncidentuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TražiIzvješće novoIzvješće = new TražiIzvješće();
            novoIzvješće.Show();
        }
    }
}
