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
    public partial class TražiIzvješće : Form
    {
        public TražiIzvješće()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime datumIncidenta = dateTimePicker1.Value;
            PopisIzvještajaOIncidentu noviPopis = new PopisIzvještajaOIncidentu(datumIncidenta);
        }
    }
}
