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
    public partial class PretraživanjeDekubitusa : Form
    {
        public PretraživanjeDekubitusa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<Sticenik> listaSticenika = Sticenik.DohvatiSticenike();
                string imeSticenika = textBox1.Text;
                string prezimeSticenika = textBox2.Text;
                string OIB_TraženogŠtićenika = "";
                foreach (Sticenik s in listaSticenika)
                {
                    if (s.Ime == imeSticenika && s.Prezime == s.Prezime)
                    {
                        OIB_TraženogŠtićenika = s.OIBSticenika;
                    }
                }
                PopisDekubitusaŠtićenika noviPopis = new PopisDekubitusaŠtićenika(OIB_TraženogŠtićenika);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
