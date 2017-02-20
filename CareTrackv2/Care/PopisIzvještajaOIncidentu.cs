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
    public partial class PopisIzvještajaOIncidentu : Form
    {
        public PopisIzvještajaOIncidentu()
        {
            InitializeComponent();
        }
        public PopisIzvještajaOIncidentu(DateTime datumIzvještaja) {
            InitializeComponent();
            try
            {
                this.Text = "Popis Izvještaja o incidentu na dan: " + datumIzvještaja.ToString();
                PopisSvihIzvještaja.DataSource = Izvješće_o_incidentu.DohvatiIzvješćeOIncidentuPoDatumNastanka(datumIzvještaja);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (PopisSvihIzvještaja.RowCount > 0) {
                if (PopisSvihIzvještaja.SelectedColumns.Count == 1) {
                    Izvješće_o_incidentu novoIzvješće = PopisSvihIzvještaja.SelectedRows[0].DataBoundItem as Izvješće_o_incidentu;
                    NovoIzvješće_o_incidentu novo = new NovoIzvješće_o_incidentu(novoIzvješće);
                }
            }
        }
    }
}
