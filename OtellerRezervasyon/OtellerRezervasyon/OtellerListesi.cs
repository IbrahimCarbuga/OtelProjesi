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
    public partial class OtellerListesi : Form
    {
        public OtellerListesi()
        {
            InitializeComponent();
        }

        private void linkGiris_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KullaniciGirisi giris = new KullaniciGirisi();
            giris.Show();
            this.Hide();
        }

        private void linkKaydol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitOl kayit = new KayitOl();
            kayit.Show();
            this.Hide();
        }
    }
}
