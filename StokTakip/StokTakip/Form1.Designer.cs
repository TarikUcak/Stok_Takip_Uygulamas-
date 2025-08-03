namespace StokTakip
{
    partial class stokTakipForm
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            form2Panel = new Panel();
            aramaLabel = new Label();
            araTextBox = new TextBox();
            araButton = new Button();
            ozetBilgilerGrpBox = new GroupBox();
            toplamTutarButton = new Button();
            toplamStokButton = new Button();
            kayitlariYukleButton = new Button();
            kaydetButton = new Button();
            urunuSilButton = new Button();
            dataGridViewUrunler = new DataGridView();
            colUrunAdi = new DataGridViewTextBoxColumn();
            colAdet = new DataGridViewTextBoxColumn();
            colFiyat = new DataGridViewTextBoxColumn();
            grpStokİslemleriBox = new GroupBox();
            stokCikisButton = new Button();
            stokGirisButton = new Button();
            miktarTextBox = new TextBox();
            miktarLabel = new Label();
            grpUrunEkleBox = new GroupBox();
            ekleButton = new Button();
            adetNunUpDown = new NumericUpDown();
            fiyatTextBox = new TextBox();
            urunAdiTextBox = new TextBox();
            fiyatLabel = new Label();
            adetLabel = new Label();
            urunAdiLabel = new Label();
            form2Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUrunler).BeginInit();
            grpStokİslemleriBox.SuspendLayout();
            grpUrunEkleBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)adetNunUpDown).BeginInit();
            SuspendLayout();
            // 
            // form2Panel
            // 
            form2Panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            form2Panel.Controls.Add(aramaLabel);
            form2Panel.Controls.Add(araTextBox);
            form2Panel.Controls.Add(araButton);
            form2Panel.Controls.Add(ozetBilgilerGrpBox);
            form2Panel.Controls.Add(toplamTutarButton);
            form2Panel.Controls.Add(toplamStokButton);
            form2Panel.Controls.Add(kayitlariYukleButton);
            form2Panel.Controls.Add(kaydetButton);
            form2Panel.Controls.Add(urunuSilButton);
            form2Panel.Controls.Add(dataGridViewUrunler);
            form2Panel.Controls.Add(grpStokİslemleriBox);
            form2Panel.Controls.Add(grpUrunEkleBox);
            form2Panel.Dock = DockStyle.Fill;
            form2Panel.Location = new Point(0, 0);
            form2Panel.MinimumSize = new Size(1024, 768);
            form2Panel.Name = "form2Panel";
            form2Panel.Size = new Size(1024, 768);
            form2Panel.TabIndex = 0;
            // 
            // aramaLabel
            // 
            aramaLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            aramaLabel.AutoSize = true;
            aramaLabel.Location = new Point(12, 302);
            aramaLabel.Name = "aramaLabel";
            aramaLabel.Size = new Size(67, 18);
            aramaLabel.TabIndex = 20;
            aramaLabel.Text = "Arama:";
            // 
            // araTextBox
            // 
            araTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            araTextBox.BackColor = SystemColors.ScrollBar;
            araTextBox.Location = new Point(85, 299);
            araTextBox.Name = "araTextBox";
            araTextBox.Size = new Size(731, 27);
            araTextBox.TabIndex = 21;
            araTextBox.TextChanged += araTextBox_TextChanged;
            // 
            // araButton
            // 
            araButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            araButton.BackColor = Color.DarkGray;
            araButton.Location = new Point(819, 298);
            araButton.Name = "araButton";
            araButton.Size = new Size(202, 28);
            araButton.TabIndex = 22;
            araButton.Text = "Ara";
            araButton.UseVisualStyleBackColor = false;
            araButton.Click += araButton_Click;
            // 
            // ozetBilgilerGrpBox
            // 
            ozetBilgilerGrpBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ozetBilgilerGrpBox.Location = new Point(704, 12);
            ozetBilgilerGrpBox.Name = "ozetBilgilerGrpBox";
            ozetBilgilerGrpBox.Size = new Size(298, 120);
            ozetBilgilerGrpBox.TabIndex = 28;
            ozetBilgilerGrpBox.TabStop = false;
            ozetBilgilerGrpBox.Text = "Özet Bilgiler";
            // 
            // toplamTutarButton
            // 
            toplamTutarButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toplamTutarButton.BackColor = Color.DarkGray;
            toplamTutarButton.Location = new Point(704, 185);
            toplamTutarButton.Name = "toplamTutarButton";
            toplamTutarButton.Size = new Size(308, 36);
            toplamTutarButton.TabIndex = 27;
            toplamTutarButton.Text = "Toplam Tutar";
            toplamTutarButton.UseVisualStyleBackColor = false;
            toplamTutarButton.Click += toplamTutarButton_Click;
            // 
            // toplamStokButton
            // 
            toplamStokButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toplamStokButton.BackColor = Color.DarkGray;
            toplamStokButton.Location = new Point(704, 143);
            toplamStokButton.Name = "toplamStokButton";
            toplamStokButton.Size = new Size(308, 36);
            toplamStokButton.TabIndex = 26;
            toplamStokButton.Text = "Toplam Stok";
            toplamStokButton.UseVisualStyleBackColor = false;
            toplamStokButton.Click += toplamStokButton_Click;
            // 
            // kayitlariYukleButton
            // 
            kayitlariYukleButton.Anchor = AnchorStyles.Top;
            kayitlariYukleButton.BackColor = Color.DarkGray;
            kayitlariYukleButton.Location = new Point(542, 236);
            kayitlariYukleButton.Name = "kayitlariYukleButton";
            kayitlariYukleButton.Size = new Size(156, 36);
            kayitlariYukleButton.TabIndex = 25;
            kayitlariYukleButton.Text = "Kayıtları Yükle";
            kayitlariYukleButton.UseVisualStyleBackColor = false;
            kayitlariYukleButton.Click += kayitlariYukleButton_Click;
            // 
            // kaydetButton
            // 
            kaydetButton.Anchor = AnchorStyles.Top;
            kaydetButton.BackColor = Color.DarkGray;
            kaydetButton.Location = new Point(371, 236);
            kaydetButton.Name = "kaydetButton";
            kaydetButton.Size = new Size(165, 36);
            kaydetButton.TabIndex = 24;
            kaydetButton.Text = "Kaydet";
            kaydetButton.UseVisualStyleBackColor = false;
            kaydetButton.Click += kaydetButton_Click;
            // 
            // urunuSilButton
            // 
            urunuSilButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            urunuSilButton.BackColor = Color.DarkGray;
            urunuSilButton.Location = new Point(251, 608);
            urunuSilButton.Name = "urunuSilButton";
            urunuSilButton.Size = new Size(503, 44);
            urunuSilButton.TabIndex = 23;
            urunuSilButton.Text = "Ürünü Sil";
            urunuSilButton.UseVisualStyleBackColor = false;
            urunuSilButton.Click += urunuSilButton_Click_1;
            // 
            // dataGridViewUrunler
            // 
            dataGridViewUrunler.AllowUserToAddRows = false;
            dataGridViewUrunler.AllowUserToDeleteRows = false;
            dataGridViewUrunler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUrunler.Columns.AddRange(new DataGridViewColumn[] { colUrunAdi, colAdet, colFiyat });
            dataGridViewUrunler.Location = new Point(12, 341);
            dataGridViewUrunler.Name = "dataGridViewUrunler";
            dataGridViewUrunler.Size = new Size(1009, 250);
            dataGridViewUrunler.TabIndex = 19;
            // 
            // colUrunAdi
            // 
            colUrunAdi.HeaderText = "Ürün Adı";
            colUrunAdi.Name = "colUrunAdi";
            colUrunAdi.Width = 320;
            // 
            // colAdet
            // 
            colAdet.HeaderText = "Adet";
            colAdet.Name = "colAdet";
            colAdet.Width = 323;
            // 
            // colFiyat
            // 
            colFiyat.HeaderText = "Fiyat";
            colFiyat.Name = "colFiyat";
            colFiyat.Width = 323;
            // 
            // grpStokİslemleriBox
            // 
            grpStokİslemleriBox.Anchor = AnchorStyles.Top;
            grpStokİslemleriBox.Controls.Add(stokCikisButton);
            grpStokİslemleriBox.Controls.Add(stokGirisButton);
            grpStokİslemleriBox.Controls.Add(miktarTextBox);
            grpStokİslemleriBox.Controls.Add(miktarLabel);
            grpStokİslemleriBox.Font = new Font("Verdana", 12F);
            grpStokİslemleriBox.Location = new Point(371, 12);
            grpStokİslemleriBox.Name = "grpStokİslemleriBox";
            grpStokİslemleriBox.Size = new Size(327, 209);
            grpStokİslemleriBox.TabIndex = 18;
            grpStokİslemleriBox.TabStop = false;
            grpStokİslemleriBox.Text = "Stok İşlemleri";
            // 
            // stokCikisButton
            // 
            stokCikisButton.BackColor = Color.DarkGray;
            stokCikisButton.Location = new Point(153, 149);
            stokCikisButton.Name = "stokCikisButton";
            stokCikisButton.Size = new Size(137, 36);
            stokCikisButton.TabIndex = 9;
            stokCikisButton.Text = "Stok Çıkış";
            stokCikisButton.UseVisualStyleBackColor = false;
            stokCikisButton.Click += stokCikisButton_Click_1;
            // 
            // stokGirisButton
            // 
            stokGirisButton.BackColor = Color.DarkGray;
            stokGirisButton.Location = new Point(153, 102);
            stokGirisButton.Name = "stokGirisButton";
            stokGirisButton.Size = new Size(137, 36);
            stokGirisButton.TabIndex = 8;
            stokGirisButton.Text = "Stok Giriş";
            stokGirisButton.UseVisualStyleBackColor = false;
            stokGirisButton.Click += stokGirisButton_Click_1;
            // 
            // miktarTextBox
            // 
            miktarTextBox.Location = new Point(153, 51);
            miktarTextBox.Name = "miktarTextBox";
            miktarTextBox.Size = new Size(142, 27);
            miktarTextBox.TabIndex = 6;
            // 
            // miktarLabel
            // 
            miktarLabel.AutoSize = true;
            miktarLabel.Location = new Point(35, 57);
            miktarLabel.Name = "miktarLabel";
            miktarLabel.Size = new Size(65, 18);
            miktarLabel.TabIndex = 3;
            miktarLabel.Text = "Miktar:";
            // 
            // grpUrunEkleBox
            // 
            grpUrunEkleBox.Controls.Add(ekleButton);
            grpUrunEkleBox.Controls.Add(adetNunUpDown);
            grpUrunEkleBox.Controls.Add(fiyatTextBox);
            grpUrunEkleBox.Controls.Add(urunAdiTextBox);
            grpUrunEkleBox.Controls.Add(fiyatLabel);
            grpUrunEkleBox.Controls.Add(adetLabel);
            grpUrunEkleBox.Controls.Add(urunAdiLabel);
            grpUrunEkleBox.Font = new Font("Verdana", 12F);
            grpUrunEkleBox.Location = new Point(12, 12);
            grpUrunEkleBox.Name = "grpUrunEkleBox";
            grpUrunEkleBox.Size = new Size(343, 269);
            grpUrunEkleBox.TabIndex = 17;
            grpUrunEkleBox.TabStop = false;
            grpUrunEkleBox.Text = "Ürün Ekle";
            // 
            // ekleButton
            // 
            ekleButton.BackColor = Color.DarkGray;
            ekleButton.Location = new Point(139, 203);
            ekleButton.Name = "ekleButton";
            ekleButton.Size = new Size(159, 36);
            ekleButton.TabIndex = 7;
            ekleButton.Text = "Ekle";
            ekleButton.UseVisualStyleBackColor = false;
            ekleButton.Click += ekleButton_Click_1;
            // 
            // adetNunUpDown
            // 
            adetNunUpDown.Location = new Point(141, 100);
            adetNunUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            adetNunUpDown.Name = "adetNunUpDown";
            adetNunUpDown.Size = new Size(120, 27);
            adetNunUpDown.TabIndex = 6;
            // 
            // fiyatTextBox
            // 
            fiyatTextBox.Location = new Point(139, 149);
            fiyatTextBox.Name = "fiyatTextBox";
            fiyatTextBox.Size = new Size(122, 27);
            fiyatTextBox.TabIndex = 5;
            // 
            // urunAdiTextBox
            // 
            urunAdiTextBox.Location = new Point(139, 48);
            urunAdiTextBox.Name = "urunAdiTextBox";
            urunAdiTextBox.Size = new Size(159, 27);
            urunAdiTextBox.TabIndex = 3;
            // 
            // fiyatLabel
            // 
            fiyatLabel.AutoSize = true;
            fiyatLabel.Location = new Point(18, 149);
            fiyatLabel.Name = "fiyatLabel";
            fiyatLabel.Size = new Size(55, 18);
            fiyatLabel.TabIndex = 2;
            fiyatLabel.Text = "Fiyat:";
            // 
            // adetLabel
            // 
            adetLabel.AutoSize = true;
            adetLabel.Location = new Point(18, 102);
            adetLabel.Name = "adetLabel";
            adetLabel.Size = new Size(53, 18);
            adetLabel.TabIndex = 1;
            adetLabel.Text = "Adet:";
            // 
            // urunAdiLabel
            // 
            urunAdiLabel.AutoSize = true;
            urunAdiLabel.Location = new Point(18, 51);
            urunAdiLabel.Name = "urunAdiLabel";
            urunAdiLabel.Size = new Size(85, 18);
            urunAdiLabel.TabIndex = 0;
            urunAdiLabel.Text = "Ürün Adı:";
            // 
            // stokTakipForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1023, 687);
            Controls.Add(form2Panel);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "stokTakipForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stok Takip ";
            FormClosing += stokTakipForm_FormClosing;
            form2Panel.ResumeLayout(false);
            form2Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUrunler).EndInit();
            grpStokİslemleriBox.ResumeLayout(false);
            grpStokİslemleriBox.PerformLayout();
            grpUrunEkleBox.ResumeLayout(false);
            grpUrunEkleBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)adetNunUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel form2Panel;
        private Label aramaLabel;
        private TextBox araTextBox;
        private Button araButton;
        private GroupBox ozetBilgilerGrpBox;
        private Button toplamTutarButton;
        private Button toplamStokButton;
        private Button kayitlariYukleButton;
        private Button kaydetButton;
        private Button urunuSilButton;
        private DataGridView dataGridViewUrunler;
        private GroupBox grpStokİslemleriBox;
        private Button stokCikisButton;
        private Button stokGirisButton;
        private TextBox miktarTextBox;
        private Label miktarLabel;
        private GroupBox grpUrunEkleBox;
        private Button ekleButton;
        private NumericUpDown adetNunUpDown;
        private TextBox fiyatTextBox;
        private TextBox urunAdiTextBox;
        private Label fiyatLabel;
        private Label adetLabel;
        private Label urunAdiLabel;
        private DataGridViewTextBoxColumn colUrunAdi;
        private DataGridViewTextBoxColumn colAdet;
        private DataGridViewTextBoxColumn colFiyat;
    }
}
