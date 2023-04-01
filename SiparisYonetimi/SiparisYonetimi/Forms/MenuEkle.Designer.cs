namespace SiparisYonetimi
{
    partial class MenuEkle
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
            gbUrunEkle = new GroupBox();
            btnEkle = new Button();
            txtAd = new TextBox();
            label2 = new Label();
            label1 = new Label();
            nudFiyat = new NumericUpDown();
            gbUrunEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudFiyat).BeginInit();
            SuspendLayout();
            // 
            // gbUrunEkle
            // 
            gbUrunEkle.Controls.Add(btnEkle);
            gbUrunEkle.Controls.Add(nudFiyat);
            gbUrunEkle.Controls.Add(txtAd);
            gbUrunEkle.Controls.Add(label2);
            gbUrunEkle.Controls.Add(label1);
            gbUrunEkle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbUrunEkle.Location = new Point(34, 36);
            gbUrunEkle.Name = "gbUrunEkle";
            gbUrunEkle.Size = new Size(280, 193);
            gbUrunEkle.TabIndex = 0;
            gbUrunEkle.TabStop = false;
            gbUrunEkle.Text = "Menu Ekle";
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.ActiveCaption;
            btnEkle.Location = new Point(103, 138);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(120, 36);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtAd.Location = new Point(103, 42);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(120, 25);
            txtAd.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 93);
            label2.Name = "label2";
            label2.Size = new Size(43, 21);
            label2.TabIndex = 0;
            label2.Text = "Fiyat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 46);
            label1.Name = "label1";
            label1.Size = new Size(29, 21);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // nudFiyat
            // 
            nudFiyat.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            nudFiyat.Location = new Point(103, 89);
            nudFiyat.Name = "nudFiyat";
            nudFiyat.Size = new Size(120, 25);
            nudFiyat.TabIndex = 1;
            // 
            // MenuEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(352, 253);
            Controls.Add(gbUrunEkle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuEkle";
            Text = "MenuEkle";
            gbUrunEkle.ResumeLayout(false);
            gbUrunEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudFiyat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbUrunEkle;
        private TextBox txtAd;
        private Label label2;
        private Label label1;
        private Button btnEkle;
        private NumericUpDown nudFiyat;
    }
}