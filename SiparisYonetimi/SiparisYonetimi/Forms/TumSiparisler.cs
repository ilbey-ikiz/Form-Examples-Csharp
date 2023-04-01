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
    public partial class TumSiparisler : Form
    {
        public TumSiparisler()
        {
            InitializeComponent();
        }

        private void TumSiparisler_Load(object sender, EventArgs e)
        {

            foreach (var siparis in MainMenu.siparisler)
            {
                lbSiparisler.Items.Add(siparis);
            }
            lblCiro.Text = Restoran.ToplamCiroBul(MainMenu.siparisler).ToString() + "TL";
            lblEkstaMalzemeGeliri.Text = Restoran.ToplamSosKazanciBul(MainMenu.siparisler).ToString() + "TL";
            lblSatilanUrunAdedi.Text = Restoran.SatilanUrunAdediBul(MainMenu.siparisler).ToString();
            lblToplamSiparis.Text = Restoran.ToplamSiparisBul(MainMenu.siparisler).ToString();
        }

       
    }
}
