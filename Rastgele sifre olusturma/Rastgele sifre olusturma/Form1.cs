using System.Diagnostics.Eventing.Reader;
using System.Text;

namespace sdffds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            lstSifreler.Items.Clear();
            Random rnd = new Random();
            bool kucukHarf = cbKucukHarf.Checked;
            bool buyukHarf = cbBuyukHarf.Checked;
            bool rakam = cbRakam.Checked;
            bool ozelKarakter = cbOzelKarakter.Checked;

            string sifreOlusturma = "";
            if (buyukHarf) sifreOlusturma += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (kucukHarf) sifreOlusturma += "abcdefghijklmnopqrstuvwxyz";
            if (rakam) sifreOlusturma += "0123456789";
            if (ozelKarakter) sifreOlusturma += "!@#$%^&*()_-+=[]{}\\|/?<>,.";


            // sifreOlusturma stringinden istenilen sayida rastgele sifre olusturur.
            
            string sifre = "";
            for (int i = 0; i < numericUpDown2.Value; i++)
            {
                for (int j = 0; j < numericUpDown1.Value; j++)
                {
                    sifre += sifreOlusturma[rnd.Next(0, sifreOlusturma.Length)];
                }
                lstSifreler.Items.Add($"{i + 1}-)    {sifre}");
                sifre = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}