using System.Collections;

namespace ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(lstMusteriler, list);
            form2.ShowDialog();   
        }
        List <string> list = new List<string>();
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lstMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstMusteriler.SelectedIndex!=-1)
            MessageBox.Show(list[lstMusteriler.SelectedIndex] , "Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}