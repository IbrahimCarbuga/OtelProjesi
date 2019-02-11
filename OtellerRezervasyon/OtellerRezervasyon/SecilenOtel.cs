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
    public partial class SecilenOtel : Form
    {
        public SecilenOtel()
        {
            InitializeComponent();
        }

        private void btnYorumlar_Click(object sender, EventArgs e)
        {
            Yorumlar yorumlar = new Yorumlar();
            yorumlar.Show();
            this.Hide();
        }

        private void btnRezerve_Click(object sender, EventArgs e)
        {
            RezerveBilgileri rezerve = new RezerveBilgileri();
            rezerve.Show();
            this.Hide();
        }
    }
}