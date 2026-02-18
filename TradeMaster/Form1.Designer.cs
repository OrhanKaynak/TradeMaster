namespace TradeMaster
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
            lbKategoriler = new ListBox();
            lbUrunler = new ListBox();
            gbDetails = new GroupBox();
            lblFiyat = new Label();
            pbResim = new PictureBox();
            lblPuan = new Label();
            txtAciklama = new RichTextBox();
            gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbResim).BeginInit();
            SuspendLayout();
            // 
            // lbKategoriler
            // 
            lbKategoriler.FormattingEnabled = true;
            lbKategoriler.Location = new Point(12, 12);
            lbKategoriler.Name = "lbKategoriler";
            lbKategoriler.Size = new Size(277, 664);
            lbKategoriler.TabIndex = 0;
            lbKategoriler.SelectedIndexChanged += lbKategoriler_SelectedIndexChanged;
            // 
            // lbUrunler
            // 
            lbUrunler.FormattingEnabled = true;
            lbUrunler.Location = new Point(349, 12);
            lbUrunler.Name = "lbUrunler";
            lbUrunler.Size = new Size(296, 664);
            lbUrunler.TabIndex = 1;
            lbUrunler.SelectedIndexChanged += lbUrunler_SelectedIndexChanged;
            // 
            // gbDetails
            // 
            gbDetails.Controls.Add(txtAciklama);
            gbDetails.Controls.Add(lblPuan);
            gbDetails.Controls.Add(lblFiyat);
            gbDetails.Controls.Add(pbResim);
            gbDetails.Location = new Point(704, 12);
            gbDetails.Name = "gbDetails";
            gbDetails.Size = new Size(280, 664);
            gbDetails.TabIndex = 2;
            gbDetails.TabStop = false;
            gbDetails.Text = "Ürün Detayları";
            // 
            // lblFiyat
            // 
            lblFiyat.Location = new Point(6, 247);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.Size = new Size(97, 31);
            lblFiyat.TabIndex = 1;
            lblFiyat.Text = "Fiyat";
            // 
            // pbResim
            // 
            pbResim.Location = new Point(6, 26);
            pbResim.Name = "pbResim";
            pbResim.Size = new Size(268, 206);
            pbResim.SizeMode = PictureBoxSizeMode.Zoom;
            pbResim.TabIndex = 0;
            pbResim.TabStop = false;
            // 
            // lblPuan
            // 
            lblPuan.Location = new Point(6, 299);
            lblPuan.Name = "lblPuan";
            lblPuan.Size = new Size(97, 33);
            lblPuan.TabIndex = 2;
            lblPuan.Text = "Puan";
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(6, 354);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(268, 304);
            txtAciklama.TabIndex = 3;
            txtAciklama.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 691);
            Controls.Add(gbDetails);
            Controls.Add(lbUrunler);
            Controls.Add(lbKategoriler);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbResim).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbKategoriler;
        private ListBox lbUrunler;
        private GroupBox gbDetails;
        private Label lblFiyat;
        private PictureBox pbResim;
        private RichTextBox txtAciklama;
        private Label lblPuan;
    }
}
