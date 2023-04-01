using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;

namespace SiparisYonetimi
{
    public partial class SiparisOlustur : Form
    {
        public SiparisOlustur()
        {
            InitializeComponent();
        }

        private void SiparisOlustur_Load(object sender, EventArgs e)
        {
            foreach (var item in MainMenu.urunler)
            {
                if (item is Menu)
                    cbMenuler.Items.Add(item.Ad);
            }
            foreach (var item in MainMenu.urunler)
            {
                if (item is Sos)
                {
                    CheckBox chk = new();
                    chk.Text = item.Ad;
                    flpSoslar.Controls.Add(chk);
                }
            }
        }

        private void btnSiparisiOnayla_Click(object sender, EventArgs e)
        {
            foreach (var siparis in siparislerGecici)
            {
            MainMenu.siparisler.Add(siparis);
            }
            Helper.Temizle(this.Controls);
            lblToplamTutar.Text = "0,00 TL";
            siparislerGecici.Clear();
        }
        List<Siparis> siparislerGecici = new List<Siparis>();
            int siparisToplamTutar = 0;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();

            siparis.Menu.Ad = cbMenuler.Text;
            siparis.MenuAdet = (int)nudAdet.Value;

            foreach (var urun in MainMenu.urunler)
            {
                if (urun is Menu && urun.Ad == siparis.Menu.Ad)
                {
                    if (rbKucuk.Checked)
                        siparis.Menu.Fiyat = urun.Fiyat ;
                    else if (rbOrta.Checked)
                        siparis.Menu.Fiyat = urun.Fiyat + 10;
                    else if (rbBuyuk.Checked)
                        siparis.Menu.Fiyat = urun.Fiyat + 20;
                }
            }
            foreach (var control in flpSoslar.Controls)
            {
                if (((CheckBox)control).Checked)
                {
                    Sos sos = new Sos();
                    sos.Ad = ((CheckBox)control).Text;
                    foreach (var urun in MainMenu.urunler)
                    {
                        if (urun is Sos && ((CheckBox)control).Text == urun.Ad)
                            sos.Fiyat = urun.Fiyat;
                    }
                    siparis.Soslar.Add(sos);
                }
            }
            siparislerGecici.Add(siparis);
            lbSiparisler.Items.Add(siparis);
            siparisToplamTutar += (int)siparis.ToplamFiyat;
            lblToplamTutar.Text = siparisToplamTutar.ToString();

            

        }

    }
}