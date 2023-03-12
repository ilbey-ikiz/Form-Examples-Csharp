namespace sdffds
{
    partial class Form1
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
            cbKucukHarf = new CheckBox();
            cbBuyukHarf = new CheckBox();
            cbRakam = new CheckBox();
            cbOzelKarakter = new CheckBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            lblSifreSayisi = new Label();
            label2 = new Label();
            lstSifreler = new ListBox();
            btnUret = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // cbKucukHarf
            // 
            cbKucukHarf.AutoSize = true;
            cbKucukHarf.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cbKucukHarf.Location = new Point(106, 45);
            cbKucukHarf.Margin = new Padding(4);
            cbKucukHarf.Name = "cbKucukHarf";
            cbKucukHarf.Size = new Size(140, 32);
            cbKucukHarf.TabIndex = 0;
            cbKucukHarf.Text = "Kucuk Harf";
            cbKucukHarf.UseVisualStyleBackColor = true;
            // 
            // cbBuyukHarf
            // 
            cbBuyukHarf.AutoSize = true;
            cbBuyukHarf.Location = new Point(106, 111);
            cbBuyukHarf.Margin = new Padding(4);
            cbBuyukHarf.Name = "cbBuyukHarf";
            cbBuyukHarf.Size = new Size(141, 32);
            cbBuyukHarf.TabIndex = 0;
            cbBuyukHarf.Text = "Buyuk Harf";
            cbBuyukHarf.UseVisualStyleBackColor = true;
            // 
            // cbRakam
            // 
            cbRakam.AutoSize = true;
            cbRakam.Location = new Point(106, 179);
            cbRakam.Margin = new Padding(4);
            cbRakam.Name = "cbRakam";
            cbRakam.Size = new Size(98, 32);
            cbRakam.TabIndex = 0;
            cbRakam.Text = "Rakam";
            cbRakam.UseVisualStyleBackColor = true;
            // 
            // cbOzelKarakter
            // 
            cbOzelKarakter.AutoSize = true;
            cbOzelKarakter.Location = new Point(106, 248);
            cbOzelKarakter.Margin = new Padding(4);
            cbOzelKarakter.Name = "cbOzelKarakter";
            cbOzelKarakter.Size = new Size(163, 32);
            cbOzelKarakter.TabIndex = 0;
            cbOzelKarakter.Text = "Ozel Karakter";
            cbOzelKarakter.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(196, 406);
            numericUpDown1.Margin = new Padding(4);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(225, 34);
            numericUpDown1.TabIndex = 1;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(196, 352);
            numericUpDown2.Margin = new Padding(6);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(225, 34);
            numericUpDown2.TabIndex = 1;
            // 
            // lblSifreSayisi
            // 
            lblSifreSayisi.AutoSize = true;
            lblSifreSayisi.Location = new Point(51, 354);
            lblSifreSayisi.Name = "lblSifreSayisi";
            lblSifreSayisi.Size = new Size(116, 28);
            lblSifreSayisi.TabIndex = 2;
            lblSifreSayisi.Text = "Sifre Sayisi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 412);
            label2.Name = "label2";
            label2.Size = new Size(152, 28);
            label2.TabIndex = 2;
            label2.Text = "Sifre Uzunlugu";
            // 
            // lstSifreler
            // 
            lstSifreler.FormattingEnabled = true;
            lstSifreler.ItemHeight = 28;
            lstSifreler.Location = new Point(479, 32);
            lstSifreler.Name = "lstSifreler";
            lstSifreler.Size = new Size(458, 508);
            lstSifreler.TabIndex = 3;
            // 
            // btnUret
            // 
            btnUret.BackColor = SystemColors.ActiveBorder;
            btnUret.Location = new Point(196, 470);
            btnUret.Name = "btnUret";
            btnUret.Size = new Size(225, 70);
            btnUret.TabIndex = 4;
            btnUret.Text = "Üret";
            btnUret.UseVisualStyleBackColor = false;
            btnUret.Click += btnUret_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 579);
            Controls.Add(btnUret);
            Controls.Add(lstSifreler);
            Controls.Add(label2);
            Controls.Add(lblSifreSayisi);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(cbOzelKarakter);
            Controls.Add(cbRakam);
            Controls.Add(cbBuyukHarf);
            Controls.Add(cbKucukHarf);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbKucukHarf;
        private CheckBox cbBuyukHarf;
        private CheckBox cbRakam;
        private CheckBox cbOzelKarakter;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label lblSifreSayisi;
        private Label label2;
        private ListBox lstSifreler;
        private Button btnUret;
    }
}