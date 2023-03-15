namespace ödev
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAdSoyad = new TextBox();
            nudYas = new NumericUpDown();
            mtbTelefon = new MaskedTextBox();
            txtAdres = new TextBox();
            btnKaydet = new Button();
            btnListeyeDon = new Button();
            ((System.ComponentModel.ISupportInitialize)nudYas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 60);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 122);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 28);
            label2.TabIndex = 0;
            label2.Text = "Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 188);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(42, 28);
            label3.TabIndex = 0;
            label3.Text = "Yas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 257);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 28);
            label4.TabIndex = 0;
            label4.Text = "Adres";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(190, 54);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(203, 34);
            txtAdSoyad.TabIndex = 1;
            // 
            // nudYas
            // 
            nudYas.Location = new Point(190, 182);
            nudYas.Name = "nudYas";
            nudYas.Size = new Size(203, 34);
            nudYas.TabIndex = 2;
            // 
            // mtbTelefon
            // 
            mtbTelefon.Location = new Point(188, 119);
            mtbTelefon.Mask = "(999) 000-0000";
            mtbTelefon.Name = "mtbTelefon";
            mtbTelefon.Size = new Size(205, 34);
            mtbTelefon.TabIndex = 3;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(190, 257);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(203, 117);
            txtAdres.TabIndex = 4;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(0, 192, 0);
            btnKaydet.Location = new Point(188, 414);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(205, 49);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnListeyeDon
            // 
            btnListeyeDon.BackColor = SystemColors.ActiveBorder;
            btnListeyeDon.Location = new Point(188, 469);
            btnListeyeDon.Name = "btnListeyeDon";
            btnListeyeDon.Size = new Size(205, 49);
            btnListeyeDon.TabIndex = 5;
            btnListeyeDon.Text = "Listeye Dön";
            btnListeyeDon.UseVisualStyleBackColor = false;
            btnListeyeDon.Click += btnListeyeDon_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 567);
            Controls.Add(btnListeyeDon);
            Controls.Add(btnKaydet);
            Controls.Add(txtAdres);
            Controls.Add(mtbTelefon);
            Controls.Add(nudYas);
            Controls.Add(txtAdSoyad);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)nudYas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAdSoyad;
        private NumericUpDown nudYas;
        private MaskedTextBox mtbTelefon;
        private TextBox txtAdres;
        private Button btnKaydet;
        private Button btnListeyeDon;
    }
}