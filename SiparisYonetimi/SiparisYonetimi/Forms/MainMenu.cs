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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        public static List<Urun> urunler = new();

        public static List<Siparis> siparisler = new();
        private void MainMenu_Load_1(object sender, EventArgs e)
        {
            urunler.Add(new Menu() { Ad = "Bigmac", Fiyat = 85 });
            urunler.Add(new Menu() { Ad = "Whopper", Fiyat = 75 });
            urunler.Add(new Sos() { Ad = "Mayonez", Fiyat = 5 });
            urunler.Add(new Sos() { Ad = "Ketcap", Fiyat = 5 });

            SiparisOlustur siparisOlustur = new();
            FormAc(siparisOlustur);
        }

        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlariKapat();
            SiparisOlustur siparisOlustur = new();
            FormAc(siparisOlustur);
        }

        private void tümSiparişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlariKapat();
            TumSiparisler tumSiparisler = new();
            FormAc(tumSiparisler);
        }

        private void menuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlariKapat();
            MenuEkle menuEkle = new();
            FormAc(menuEkle);
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlariKapat();
            EkstraMalzemeSecimi ekstraMalzemeSecimi = new();
            FormAc(ekstraMalzemeSecimi);
        }

        private void FormlariKapat()
        {
            Form[] forms = this.MdiChildren;
            foreach (var form in forms)
            {
                form.Close();
            }
        }

        public void FormAc(Form form)
        {
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            this.Width = form.Width + 50;
            this.Height = form.Height + 90;
            form.Show();
        }



    }
}
