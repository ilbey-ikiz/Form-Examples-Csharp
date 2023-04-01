using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisYonetimi
{
    public partial class EkstraMalzemeSecimi : Form
    {
        public EkstraMalzemeSecimi()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Sos sos = new Sos();
            sos.Ad = txtAd.Text;
            sos.Fiyat = (int)nudFiyat.Value;
            MainMenu.urunler.Add(sos);
            Helper.Temizle(Controls);
        }
    }
}
