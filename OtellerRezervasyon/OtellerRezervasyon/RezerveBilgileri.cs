using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtellerRezervasyon
{
    public partial class RezerveBilgileri : Form
    {
        public RezerveBilgileri()
        {
            InitializeComponent();
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            if (radioSimdi.Checked==true)
            {
                Odeme odeme = new Odeme();
                odeme.Show();
                this.Hide();
            }
            else if (radioOtelde.Checked==true)
            {
                MessageBox.Show("Rezervasyonunuz Yapılmıştır");
            }
        }
    }
}
