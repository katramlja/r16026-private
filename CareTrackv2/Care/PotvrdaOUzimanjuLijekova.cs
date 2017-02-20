using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Care
{
    public partial class PotvrdaOUzimanjuLijekova : Form
    {
        public PotvrdaOUzimanjuLijekova()
        {
            InitializeComponent();
        }
        public static string imeSticenika;
        public PotvrdaOUzimanjuLijekova(Sticenik OdabraniSticenik, Lijekovi_Štićenici lijek, Lijek noviLijek) {
            InitializeComponent();
            imeSticenika = OdabraniSticenik.Ime + " " + OdabraniSticenik.Prezime;
            ImeSticenika.Text = imeSticenika;
            List<Lijek> lijekovi = Lijekovi_Štićenici.DohvatiLijekoveSticenika(OdabraniSticenik.OIBSticenika);
            try
            {
                foreach (Lijek l in lijekovi)
                {
                    LijekoviSticenika.Text += l.Naziv_lijeka + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public PotvrdaOUzimanjuLijekova(string imeSticenika) {
            InitializeComponent();
            SystemSounds.Beep.Play();
            ImeSticenika.Visible = false;
            LijekoviSticenika.Text = "Zaboravili ste dati lijek " + imeSticenika + "!";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public Potvrda_o_uzimanju_lijekova potvrda = null;
        public static bool pot = false;
        private void PotvrdiUnos_Click(object sender, EventArgs e)
        {
            try
            {
                potvrda = new Potvrda_o_uzimanju_lijekova();
                potvrda.Datum_potvrde = DateTime.Now;
                potvrda.Spremi();
                pot = true;
                LijekŠtićenik.Alarm(imeSticenika);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
