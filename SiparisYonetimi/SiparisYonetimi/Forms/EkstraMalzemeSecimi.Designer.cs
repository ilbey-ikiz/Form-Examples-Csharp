namespace SiparisYonetimi
{
    partial class EkstraMalzemeSecimi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbEkstraMalzemeEkle = new GroupBox();
            btnEkle = new Button();
            nudFiyat = new NumericUpDown();
            txtAd = new TextBox();
            label2 = new Label();
            label1 = new Label();
            gbEkstraMalzemeEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudFiyat).BeginInit();
            SuspendLayout();
            // 
            // gbEkstraMalzemeEkle
            // 
            gbEkstraMalzemeEkle.Controls.Add(btnEkle);
            gbEkstraMalzemeEkle.Controls.Add(nudFiyat);
            gbEkstraMalzemeEkle.Controls.Add(txtAd);
            gbEkstraMalzemeEkle.Controls.Add(label2);
            gbEkstraMalzemeEkle.Controls.Add(label1);
            gbEkstraMalzemeEkle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbEkstraMalzemeEkle.Location = new Point(30, 25);
            gbEkstraMalzemeEkle.Name = "gbEkstraMalzemeEkle";
            gbEkstraMalzemeEkle.Size = new Size(294, 251);
            gbEkstraMalzemeEkle.TabIndex = 0;
            gbEkstraMalzemeEkle.TabStop = false;
            gbEkstraMalzemeEkle.Text = "Ekstra Malzeme Ekle";
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.ActiveCaption;
            btnEkle.ForeColor = SystemColors.ControlText;
            btnEkle.Location = new Point(120, 168);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(120, 44);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // nudFiyat
            // 
            nudFiyat.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            nudFiyat.Location = new Point(120, 120);
            nudFiyat.Name = "nudFiyat";
            nudFiyat.Size = new Size(120, 25);
            nudFiyat.TabIndex = 4;
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtAd.Location = new Point(120, 73);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(120, 25);
            txtAd.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 124);
            label2.Name = "label2";
            label2.Size = new Size(43, 21);
            label2.TabIndex = 2;
            label2.Text = "Fiyat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 77);
            label1.Name = "label1";
            label1.Size = new Size(29, 21);
            label1.TabIndex = 3;
            label1.Text = "Ad";
            // 
            // EkstraMalzemeSecimi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(376, 298);
            Controls.Add(gbEkstraMalzemeEkle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EkstraMalzemeSecimi";
            Text = "EkstraMalzemeSecimi";
            gbEkstraMalzemeEkle.ResumeLayout(false);
            gbEkstraMalzemeEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudFiyat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbEkstraMalzemeEkle;
        private NumericUpDown nudFiyat;
        private TextBox txtAd;
        private Label label2;
        private Label label1;
        private Button btnEkle;
    }
}