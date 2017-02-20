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
    public partial class LijekŠtićenik : Form
    {
        string oib;
        public LijekŠtićenik(string o)
        {
            oib = o;
            InitializeComponent();
            UnosLijeka.DataSource = Lijek.DohvatiLijekove();
            UnosLijeka.DisplayMember = "Naziv_lijeka";
        }
        public static Lijekovi_Štićenici lijekŠtićenici = null;
        public void Lijek_Štićenik() {
            InitializeComponent();
            lijekŠtićenici = new Lijekovi_Štićenici();
            Lijek noviLijek = new Lijek();
            noviLijek.Naziv_lijeka = UnosLijeka.Text;
            noviLijek.Opis_i_primjena = UnosPrimjeneLijeka.Text;
            noviLijek.Proizvođač = UnosPrizvođača.Text;
            noviLijek.Spremi();
            lijekŠtićenici.Frekvencija_uzimanja_lijekova = 1;
            string vrijemePočetka = PočetniDatumUzimanjaLijekova.Value.ToString("yyyyMMdd");
            lijekŠtićenici.Vrijeme_početka_terapije = vrijemePočetka;
            string završetakTerapije = ZavrsniDatumUzimanjaLijekova.Value.ToString("yyyyMMdd");
            lijekŠtićenici.Vrijeme_prestanka_terapije = završetakTerapije;
            lijekŠtićenici.LijekoviID_Lijeka = 45; 
            lijekŠtićenici.ŠtićeniciOIB_Štićenika = oib;
            lijekŠtićenici.Spremi();
            MessageBox.Show("Lijek uspješno dodan!");
        }
        private void Izlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static void Alarm(string imeSticenika)
        {
            if (PotvrdaOUzimanjuLijekova.pot == false) {
                PotvrdaOUzimanjuLijekova alarm = new PotvrdaOUzimanjuLijekova(imeSticenika);
            }
        }

        private void DodajLijek_Click(object sender, EventArgs e)
        {
            Lijek_Štićenik();
        }
    }
}
