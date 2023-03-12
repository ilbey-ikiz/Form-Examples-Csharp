namespace WinFormsApp2
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            btnTahminEt = new Button();
            label1 = new Label();
            nudTahmin = new NumericUpDown();
            progressBar1 = new ProgressBar();
            lblIpucu = new Label();
            lblMoralBoz = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)nudTahmin).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Location = new Point(181, 23);
            button1.Name = "button1";
            button1.Size = new Size(263, 54);
            button1.TabIndex = 0;
            button1.Text = "Oyunu Baslat";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // btnTahminEt
            // 
            btnTahminEt.BackColor = SystemColors.ActiveBorder;
            btnTahminEt.Enabled = false;
            btnTahminEt.Location = new Point(181, 149);
            btnTahminEt.Name = "btnTahminEt";
            btnTahminEt.Size = new Size(263, 53);
            btnTahminEt.TabIndex = 1;
            btnTahminEt.Text = "Tahmin Et";
            btnTahminEt.UseVisualStyleBackColor = false;
            btnTahminEt.Click += btnTahminEt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(181, 106);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 2;
            label1.Text = "Bir ssayi giriniz :";
            // 
            // nudTahmin
            // 
            nudTahmin.Location = new Point(301, 104);
            nudTahmin.Name = "nudTahmin";
            nudTahmin.Size = new Size(143, 27);
            nudTahmin.TabIndex = 3;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(181, 278);
            progressBar1.Maximum = 60;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(257, 37);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 4;
            progressBar1.Value = 60;
            // 
            // lblIpucu
            // 
            lblIpucu.BackColor = SystemColors.ActiveCaption;
            lblIpucu.Location = new Point(181, 221);
            lblIpucu.Name = "lblIpucu";
            lblIpucu.Size = new Size(260, 45);
            lblIpucu.TabIndex = 5;
            // 
            // lblMoralBoz
            // 
            lblMoralBoz.BackColor = SystemColors.ActiveCaption;
            lblMoralBoz.Location = new Point(181, 339);
            lblMoralBoz.Name = "lblMoralBoz";
            lblMoralBoz.Size = new Size(260, 45);
            lblMoralBoz.TabIndex = 5;
            lblMoralBoz.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 445);
            Controls.Add(lblMoralBoz);
            Controls.Add(lblIpucu);
            Controls.Add(progressBar1);
            Controls.Add(nudTahmin);
            Controls.Add(label1);
            Controls.Add(btnTahminEt);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudTahmin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private Button btnTahminEt;
        private Label label1;
        private NumericUpDown nudTahmin;
        private ProgressBar progressBar1;
        private Label lblIpucu;
        private Label lblMoralBoz;
        private System.Windows.Forms.Timer timer2;
    }
}