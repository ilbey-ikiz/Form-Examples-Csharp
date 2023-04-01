namespace SiparisYonetimi
{
    partial class SiparisOlustur
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisOlustur));
            pbResim = new PictureBox();
            flpSoslar = new FlowLayoutPanel();
            rbKucuk = new RadioButton();
            rbOrta = new RadioButton();
            rbBuyuk = new RadioButton();
            label1 = new Label();
            nudAdet = new NumericUpDown();
            lbSiparisler = new ListBox();
            label2 = new Label();
            lblToplamTutar = new Label();
            btnSiparisiOnayla = new Button();
            cbMenuler = new ComboBox();
            btnEkle = new Button();
            ((System.ComponentModel.ISupportInitialize)pbResim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAdet).BeginInit();
            SuspendLayout();
            // 
            // pbResim
            // 
            pbResim.Image = (Image)resources.GetObject("pbResim.Image");
            pbResim.Location = new Point(29, 25);
            pbResim.Name = "pbResim";
            pbResim.Size = new Size(168, 110);
            pbResim.SizeMode = PictureBoxSizeMode.StretchImage;
            pbResim.TabIndex = 0;
            pbResim.TabStop = false;
            // 
            // flpSoslar
            // 
            flpSoslar.BackColor = Color.Transparent;
            flpSoslar.Location = new Point(30, 178);
            flpSoslar.Name = "flpSoslar";
            flpSoslar.Size = new Size(162, 103);
            flpSoslar.TabIndex = 1;
            // 
            // rbKucuk
            // 
            rbKucuk.AutoSize = true;
            rbKucuk.BackColor = Color.Transparent;
            rbKucuk.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbKucuk.Location = new Point(29, 299);
            rbKucuk.Name = "rbKucuk";
            rbKucuk.Size = new Size(70, 25);
            rbKucuk.TabIndex = 2;
            rbKucuk.TabStop = true;
            rbKucuk.Text = "Küçük";
            rbKucuk.UseVisualStyleBackColor = false;
            // 
            // rbOrta
            // 
            rbOrta.AutoSize = true;
            rbOrta.BackColor = Color.Transparent;
            rbOrta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbOrta.Location = new Point(105, 299);
            rbOrta.Name = "rbOrta";
            rbOrta.Size = new Size(59, 25);
            rbOrta.TabIndex = 2;
            rbOrta.TabStop = true;
            rbOrta.Text = "Orta";
            rbOrta.UseVisualStyleBackColor = false;
            // 
            // rbBuyuk
            // 
            rbBuyuk.AutoSize = true;
            rbBuyuk.BackColor = Color.Transparent;
            rbBuyuk.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbBuyuk.Location = new Point(171, 299);
            rbBuyuk.Name = "rbBuyuk";
            rbBuyuk.Size = new Size(71, 25);
            rbBuyuk.TabIndex = 2;
            rbBuyuk.TabStop = true;
            rbBuyuk.Text = "Buyuk";
            rbBuyuk.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(50, 352);
            label1.Name = "label1";
            label1.Size = new Size(49, 21);
            label1.TabIndex = 3;
            label1.Text = "Adet :";
            // 
            // nudAdet
            // 
            nudAdet.Location = new Point(115, 350);
            nudAdet.Name = "nudAdet";
            nudAdet.Size = new Size(77, 23);
            nudAdet.TabIndex = 4;
            // 
            // lbSiparisler
            // 
            lbSiparisler.FormattingEnabled = true;
            lbSiparisler.ItemHeight = 15;
            lbSiparisler.Location = new Point(253, 25);
            lbSiparisler.Name = "lbSiparisler";
            lbSiparisler.Size = new Size(461, 289);
            lbSiparisler.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(304, 362);
            label2.Name = "label2";
            label2.Size = new Size(127, 37);
            label2.TabIndex = 3;
            label2.Text = "Toplam :";
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.BackColor = Color.Transparent;
            lblToplamTutar.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplamTutar.ForeColor = Color.Red;
            lblToplamTutar.Location = new Point(438, 362);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(79, 37);
            lblToplamTutar.TabIndex = 3;
            lblToplamTutar.Text = "0,00 ";
            // 
            // btnSiparisiOnayla
            // 
            btnSiparisiOnayla.BackColor = SystemColors.ActiveCaption;
            btnSiparisiOnayla.Location = new Point(554, 334);
            btnSiparisiOnayla.Name = "btnSiparisiOnayla";
            btnSiparisiOnayla.Size = new Size(170, 86);
            btnSiparisiOnayla.TabIndex = 6;
            btnSiparisiOnayla.Text = "Siparişi Onayla";
            btnSiparisiOnayla.UseVisualStyleBackColor = false;
            btnSiparisiOnayla.Click += btnSiparisiOnayla_Click;
            // 
            // cbMenuler
            // 
            cbMenuler.FormattingEnabled = true;
            cbMenuler.Location = new Point(29, 152);
            cbMenuler.Name = "cbMenuler";
            cbMenuler.Size = new Size(168, 23);
            cbMenuler.TabIndex = 7;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.ActiveCaption;
            btnEkle.Location = new Point(29, 403);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(199, 48);
            btnEkle.TabIndex = 8;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // SiparisOlustur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(747, 474);
            Controls.Add(btnEkle);
            Controls.Add(cbMenuler);
            Controls.Add(btnSiparisiOnayla);
            Controls.Add(lbSiparisler);
            Controls.Add(nudAdet);
            Controls.Add(lblToplamTutar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rbBuyuk);
            Controls.Add(rbOrta);
            Controls.Add(rbKucuk);
            Controls.Add(flpSoslar);
            Controls.Add(pbResim);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "SiparisOlustur";
            Text = "Main Menu";
            Load += SiparisOlustur_Load;
            ((System.ComponentModel.ISupportInitialize)pbResim).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAdet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbResim;
        private FlowLayoutPanel flpSoslar;
        private RadioButton rbKucuk;
        private RadioButton rbOrta;
        private RadioButton rbBuyuk;
        private Label label1;
        private NumericUpDown nudAdet;
        private ListBox lbSiparisler;
        private Label label2;
        private Label lblToplamTutar;
        private Button btnSiparisiOnayla;
        private ComboBox cbMenuler;
        private Button btnEkle;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem siparişYönetimiToolStripMenuItem;
        private ToolStripMenuItem siparişYönetimiToolStripMenuItem1;
        private ToolStripMenuItem tümSiparişlerToolStripMenuItem;
        private ToolStripMenuItem ürünYönetimiToolStripMenuItem;
        private ToolStripMenuItem menuEkleToolStripMenuItem;
        private ToolStripMenuItem ekstraMalzemeEkleToolStripMenuItem;
    }
}