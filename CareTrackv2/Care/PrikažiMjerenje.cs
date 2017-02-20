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
    public partial class PrikažiMjerenje : Form
    {
        public PrikažiMjerenje()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string imeŠtićenika = textBox1.Text;
                string prezimeŠtićenika = textBox2.Text;
                string OIBŠtićenika = "";
                DateTime datumMjerenja = dateTimePicker1.Value;
                int parsedValue;
                if (!int.TryParse(textBox1.Text, out parsedValue) || !int.TryParse(textBox2.Text, out parsedValue))
                {
                    MessageBox.Show("Unesite ime i prezime, a ne i brojeve!");
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else if (textBox1.Text == " " || textBox2.Text == " " || dateTimePicker1.Value == null) {
                    MessageBox.Show("Molimo unesite sve podatke!");
                }
                List<Sticenik> listaSticenika = Sticenik.DohvatiSticenike();
                foreach (Sticenik s in listaSticenika)
                {
                    if (s.Ime == imeŠtićenika && s.Prezime == prezimeŠtićenika)
                    {
                        OIBŠtićenika = s.OIBSticenika;
                    }
                }
                Mjerenje traženoMjerenje = Mjerenje.DohvatiMjerenjePoDatumuIOIBu_Sticeniku(OIBŠtićenika, datumMjerenja);
                NovoMjerenje novo = new NovoMjerenje();
                novo.PrikaziMjerenje(traženoMjerenje);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
            }
    }
}
