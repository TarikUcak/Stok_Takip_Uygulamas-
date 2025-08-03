namespace StokTakip
{
    partial class LoginForm
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
            panel = new Panel();
            label1 = new Label();
            girisYapButton = new Button();
            kullaniciAdiLabel = new Label();
            kullaniciAdiTextBox = new TextBox();
            sifreTextBox = new TextBox();
            sifreLabel = new Label();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.None;
            panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel.Controls.Add(label1);
            panel.Controls.Add(girisYapButton);
            panel.Controls.Add(kullaniciAdiLabel);
            panel.Controls.Add(kullaniciAdiTextBox);
            panel.Controls.Add(sifreTextBox);
            panel.Controls.Add(sifreLabel);
            panel.Location = new Point(219, 108);
            panel.Name = "panel";
            panel.Size = new Size(607, 414);
            panel.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(103, 52);
            label1.Name = "label1";
            label1.Size = new Size(392, 32);
            label1.TabIndex = 10;
            label1.Text = "STOK TAKİP UYGULAMSI";
            // 
            // girisYapButton
            // 
            girisYapButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            girisYapButton.BackColor = Color.DodgerBlue;
            girisYapButton.FlatAppearance.BorderSize = 0;
            girisYapButton.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            girisYapButton.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            girisYapButton.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            girisYapButton.ForeColor = Color.White;
            girisYapButton.Location = new Point(284, 263);
            girisYapButton.Name = "girisYapButton";
            girisYapButton.Size = new Size(192, 42);
            girisYapButton.TabIndex = 14;
            girisYapButton.Text = "Giriş Yap";
            girisYapButton.UseVisualStyleBackColor = false;
            girisYapButton.Click += girisYapButton_Click_1;
            // 
            // kullaniciAdiLabel
            // 
            kullaniciAdiLabel.AutoSize = true;
            kullaniciAdiLabel.Location = new Point(103, 163);
            kullaniciAdiLabel.Name = "kullaniciAdiLabel";
            kullaniciAdiLabel.Size = new Size(139, 23);
            kullaniciAdiLabel.TabIndex = 9;
            kullaniciAdiLabel.Text = "Kullanıcı Adı:";
            // 
            // kullaniciAdiTextBox
            // 
            kullaniciAdiTextBox.BorderStyle = BorderStyle.FixedSingle;
            kullaniciAdiTextBox.Location = new Point(284, 155);
            kullaniciAdiTextBox.Name = "kullaniciAdiTextBox";
            kullaniciAdiTextBox.Size = new Size(192, 31);
            kullaniciAdiTextBox.TabIndex = 11;
            kullaniciAdiTextBox.KeyDown += kullaniciAdiTextBox_KeyDown;
            // 
            // sifreTextBox
            // 
            sifreTextBox.BorderStyle = BorderStyle.FixedSingle;
            sifreTextBox.Location = new Point(284, 211);
            sifreTextBox.Name = "sifreTextBox";
            sifreTextBox.PasswordChar = '*';
            sifreTextBox.Size = new Size(192, 31);
            sifreTextBox.TabIndex = 13;
            sifreTextBox.KeyDown += sifreTextBox_KeyDown;
            // 
            // sifreLabel
            // 
            sifreLabel.AutoSize = true;
            sifreLabel.Location = new Point(178, 219);
            sifreLabel.Name = "sifreLabel";
            sifreLabel.Size = new Size(64, 23);
            sifreLabel.TabIndex = 12;
            sifreLabel.Text = "Şifre:";
            // 
            // LoginForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1023, 682);
            Controls.Add(panel);
            Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stok Takip ";
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel;
        private Label label1;
        private Button girisYapButton;
        private Label kullaniciAdiLabel;
        private TextBox kullaniciAdiTextBox;
        private TextBox sifreTextBox;
        private Label sifreLabel;
    }
}