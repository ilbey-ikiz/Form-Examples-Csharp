namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        Random rnd = new Random();
        int bilgisayarSayi = 0;
        int counter = 60;
        string[] moralBoz = { "Kazanamazsin haha", "Bosuna ugrasmaaa ", "Beceriksizsin", "Suren bitti bile " };
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            btnTahminEt.Text = "Tahmin Et (" + counter + ")";


            if (counter % 10 == 0)
            {
                lblMoralBoz.Text = moralBoz[rnd.Next(moralBoz.Length)];
            }
            counter--;


            if (progressBar1.Value > 0)
                progressBar1.Value--;
            else
            {
                lblIpucu.Text = "Zaman Doldu !! Kaybettiniz . ";
                lblMoralBoz.Text = "HAHAHA Kaybettinnn !!";
                btnTahminEt.Enabled = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bilgisayarSayi = rnd.Next(0, 101);
            timer1.Enabled = true;
            btnTahminEt.Enabled = true;
            button1.Enabled = false;
        }

        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            if (nudTahmin.Value > bilgisayarSayi)
            {
                lblIpucu.Text = "Sayi " + nudTahmin.Value.ToString() + "' den kucuktur.";
            }
            else if (nudTahmin.Value < bilgisayarSayi)
                lblIpucu.Text = "Sayi " + nudTahmin.Value.ToString() + "' den buyuktur.";
            else
            {
                progressBar1.Value = 60;
                lblIpucu.Text = "Kazandiniz !!";
                lblMoralBoz.Text = string.Empty;
                timer1.Enabled = false;
                button1.Enabled = true;
                btnTahminEt.Enabled = false;
            }

        }
    }
}