namespace ödev
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
            btnYeniMusteri = new Button();
            lstMusteriler = new ListBox();
            SuspendLayout();
            // 
            // btnYeniMusteri
            // 
            btnYeniMusteri.BackColor = SystemColors.ActiveBorder;
            btnYeniMusteri.Location = new Point(207, 518);
            btnYeniMusteri.Margin = new Padding(4);
            btnYeniMusteri.Name = "btnYeniMusteri";
            btnYeniMusteri.Size = new Size(340, 104);
            btnYeniMusteri.TabIndex = 0;
            btnYeniMusteri.Text = "Yeni Müşteri Ekle";
            btnYeniMusteri.UseVisualStyleBackColor = false;
            btnYeniMusteri.Click += btnYeniMusteri_Click;
            // 
            // lstMusteriler
            // 
            lstMusteriler.FormattingEnabled = true;
            lstMusteriler.ItemHeight = 28;
            lstMusteriler.Location = new Point(105, 39);
            lstMusteriler.Margin = new Padding(4);
            lstMusteriler.Name = "lstMusteriler";
            lstMusteriler.Size = new Size(536, 424);
            lstMusteriler.TabIndex = 1;
            lstMusteriler.SelectedIndexChanged += lstMusteriler_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 721);
            Controls.Add(lstMusteriler);
            Controls.Add(btnYeniMusteri);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnYeniMusteri;
        private ListBox lstMusteriler;
    }
}