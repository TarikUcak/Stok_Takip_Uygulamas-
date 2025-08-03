using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace StokTakip
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void girisYapButton_Click_1(object sender, EventArgs e)
        {
            string kullaniciAdi = kullaniciAdiTextBox.Text.Trim();
            string sifre = sifreTextBox.Text;

            if (kullaniciAdi.Equals("admin", StringComparison.OrdinalIgnoreCase) && sifre == "123")
            {
                MessageBox.Show("Hoşgeldiniz Admin!", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                stokTakipForm anaForm = new stokTakipForm();
                anaForm.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kullaniciAdiTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sifreTextBox.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void sifreTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                girisYapButton.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
