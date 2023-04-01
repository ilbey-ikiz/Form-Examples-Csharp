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
    public partial class MenuEkle : Form
    {
        public MenuEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Ad = txtAd.Text;
            menu.Fiyat = (int)nudFiyat.Value;
            MainMenu.urunler.Add(menu);
            Helper.Temizle(Controls);
        }
    }
}
