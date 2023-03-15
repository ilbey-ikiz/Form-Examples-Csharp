using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev
{
    public partial class Form2 : Form
    {
        
        ListBox lstbox;
        List<string> list;
        public Form2(ListBox nesne, List <string> list)
        {
            InitializeComponent();
            lstbox = nesne;
            this.list = list;
        }
        public string adSoyad;
        public string telefon;
        public string yas;
        public string adres;
        

        List<string> isimler = new List<string>();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            adSoyad = txtAdSoyad.Text;
            telefon = mtbTelefon.Text;
            yas = nudYas.Value.ToString();
            adres = txtAdres.Text;
            isimler.Add(adSoyad);
            list.Add( $"Ad soyad: {adSoyad}\nTelefon: {telefon}\nYas: {yas}\nAdres: {adres}");
            Temizle();
        }

        public void Temizle()
        {
            txtAdres.Clear();
            txtAdSoyad.Clear();
            nudYas.Value = 0;
            mtbTelefon.Text = null;
        }

        private void btnListeyeDon_Click(object sender, EventArgs e)
        {
            foreach (string isim in isimler)
            {
                lstbox.Items.Add(isim);
            }
            this.Close();
        }
    }
}
