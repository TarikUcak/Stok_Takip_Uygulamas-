using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace StokTakip
{
    public partial class stokTakipForm : Form
    {
        public stokTakipForm()
        {
            InitializeComponent();

        }

        private void stokTakipForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ekleButton_Click_1(object sender, EventArgs e)
        {
            string urunAdi = urunAdiTextBox.Text;
            int adet = (int)adetNunUpDown.Value;
            decimal fiyat;

            if (string.IsNullOrWhiteSpace(urunAdi) ||
       !decimal.TryParse(fiyatTextBox.Text, out fiyat))
            {
                MessageBox.Show("Lütfen geçerli ürün adý, adet ve fiyat giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dataGridViewUrunler.Rows.Add(urunAdi, adet, fiyat);

            urunAdiTextBox.Text = "";
            adetNunUpDown.Value = 1;
            fiyatTextBox.Text = "";

        }

        private void urunuSilButton_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewUrunler.SelectedRows.Count > 0)
            {
                dataGridViewUrunler.Rows.RemoveAt(dataGridViewUrunler.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediðiniz ürünü seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void stokGirisButton_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewUrunler.SelectedRows.Count > 0)
            {
                DataGridViewRow seciliSatir = dataGridViewUrunler.SelectedRows[0];

                int mevcutAdet = Convert.ToInt32(seciliSatir.Cells[1].Value);

                int eklenecekAdet;
                if (!int.TryParse(miktarTextBox.Text, out eklenecekAdet) || eklenecekAdet <= 0)
                {
                    MessageBox.Show("Lütfen geçerli bir miktar giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int yeniAdet = mevcutAdet + eklenecekAdet;
                seciliSatir.Cells[1].Value = yeniAdet;

                MessageBox.Show($"{eklenecekAdet} adet stok baþarýyla eklendi.", "Stok Giriþ");

                miktarTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen stok giriþi yapmak istediðiniz ürünü seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void stokCikisButton_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewUrunler.SelectedRows.Count > 0)
            {
                DataGridViewRow seciliSatir = dataGridViewUrunler.SelectedRows[0];

                int mevcutAdet = Convert.ToInt32(seciliSatir.Cells[1].Value);

                int cikacakAdet;
                if (!int.TryParse(miktarTextBox.Text, out cikacakAdet) || cikacakAdet <= 0)
                {
                    MessageBox.Show("Lütfen geçerli bir çýkýþ miktarý giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cikacakAdet > mevcutAdet)
                {
                    MessageBox.Show("Stoktaki adetten fazla çýkýþ yapamazsýnýz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int yeniAdet = mevcutAdet - cikacakAdet;

                if (yeniAdet == 0)
                {
                    dataGridViewUrunler.Rows.Remove(seciliSatir);
                    MessageBox.Show("Stok çýkýþý sonucu ürün silindi.", "Bilgilendirme!");
                }
                else
                {
                    seciliSatir.Cells[1].Value = yeniAdet;
                    MessageBox.Show($"{cikacakAdet} adet stok baþarýyla çýkýþ yapýldý.", "Stok Çýkýþ");
                }

                miktarTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen stok çýkýþý yapýlacak ürünü seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            int urunSayisi = 0;
            foreach (DataGridViewRow row in dataGridViewUrunler.Rows)
            {
                if (!row.IsNewRow) urunSayisi++;
            }

            if (urunSayisi == 0)
            {
                MessageBox.Show("Kaydedilecek ürün bulunamadý!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Ürün Adý,Adet,Fiyat");

            foreach (DataGridViewRow row in dataGridViewUrunler.Rows)
            {
                if (row.IsNewRow) continue;

                string urunAdi = row.Cells[0].Value?.ToString() ?? "";
                string adet = row.Cells[1].Value?.ToString() ?? "";
                string fiyat = row.Cells[2].Value?.ToString() ?? "";

                sb.AppendLine($"{urunAdi},{adet},{fiyat}");
            }

            File.WriteAllText("stoklar.csv", sb.ToString(), Encoding.UTF8);

            MessageBox.Show("Ürünler baþarýyla kaydedildi.", "Bilgi");
        }

        private void kayitlariYukleButton_Click(object sender, EventArgs e)
        {
            string dosyaYolu = "stoklar.csv";
            if (!File.Exists(dosyaYolu))
            {
                MessageBox.Show("Kayýt dosyasý bulunamadý!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dataGridViewUrunler.Rows.Clear();

            var satirlar = File.ReadAllLines(dosyaYolu);

            for (int i = 1; i < satirlar.Length; i++)
            {
                var alanlar = satirlar[i].Split(',');

                if (alanlar.Length >= 3)
                {
                    dataGridViewUrunler.Rows.Add(alanlar[0], alanlar[1], alanlar[2]);
                }
            }

            MessageBox.Show("Kayýtlar baþarýyla yüklendi.", "Bilgi");

        }

        private void toplamStokButton_Click(object sender, EventArgs e)
        {
            ozetBilgilerGrpBox.Controls.Clear();

            int toplamStok = 0;
            foreach (DataGridViewRow row in dataGridViewUrunler.Rows)
            {
                if (row.IsNewRow) continue;
                int adet = 0;
                int.TryParse(row.Cells[1].Value?.ToString(), out adet);
                toplamStok += adet;
            }

            Label labelStok = new Label();
            labelStok.Text = $"Toplam Adet: {toplamStok}";
            labelStok.Font = new Font("Verdana", 12, FontStyle.Bold);
            labelStok.Location = new Point(20, 30);
            labelStok.AutoSize = true;

            ozetBilgilerGrpBox.Controls.Add(labelStok);
            ozetBilgilerGrpBox.Text = "Stok Bilgisi";
        }

        private void toplamTutarButton_Click(object sender, EventArgs e)
        {
            ozetBilgilerGrpBox.Controls.Clear();

            decimal toplamTutar = 0;
            foreach (DataGridViewRow row in dataGridViewUrunler.Rows)
            {
                if (row.IsNewRow) continue;
                int adet = 0;
                decimal fiyat = 0;
                int.TryParse(row.Cells[1].Value?.ToString(), out adet);
                decimal.TryParse(row.Cells[2].Value?.ToString(), out fiyat);
                toplamTutar += adet * fiyat;
            }

            Label labelTutar = new Label();
            labelTutar.Text = $"Toplam Tutar: {toplamTutar:C2}";
            labelTutar.Font = new Font("Verdana", 12, FontStyle.Bold);
            labelTutar.Location = new Point(20, 30);
            labelTutar.AutoSize = true;

            ozetBilgilerGrpBox.Controls.Add(labelTutar);
            ozetBilgilerGrpBox.Text = "Tutar Bilgisi";
        }

        private void araButton_Click(object sender, EventArgs e)
        {
            string aranan = araTextBox.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(aranan))
            {
                foreach (DataGridViewRow row in dataGridViewUrunler.Rows)
                {
                    if (!row.IsNewRow)
                        row.Visible = true;
                }
                ozetBilgilerGrpBox.Text = $"{dataGridViewUrunler.Rows.Count - 1} ürün listelendi";
                return;
            }

            int bulunanSayisi = 0;

            foreach (DataGridViewRow row in dataGridViewUrunler.Rows)
            {
                if (row.IsNewRow) continue;

                bool bulundu = false;

                if (row.Cells[0].Value != null)
                {
                    string urunAdi = row.Cells[0].Value.ToString().ToLower();
                    if (urunAdi.Contains(aranan))
                    {
                        bulundu = true;
                        bulunanSayisi++;
                    }
                }

                row.Visible = bulundu;
            }

            if (bulunanSayisi == 0)
            {
                MessageBox.Show("Aradýðýnýz ürün bulunamadý!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ozetBilgilerGrpBox.Text = $"{bulunanSayisi} ürün bulundu";
        }

        private void araTextBox_TextChanged(object sender, EventArgs e)
        {
            string aranan = araTextBox.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(aranan))
            {
                foreach (DataGridViewRow row in dataGridViewUrunler.Rows)
                {
                    if (!row.IsNewRow)
                        row.Visible = true;
                }
                ozetBilgilerGrpBox.Text = $"{dataGridViewUrunler.Rows.Count - 1} ürün listelendi";
                return;
            }

            int bulunanSayisi = 0;

            foreach (DataGridViewRow row in dataGridViewUrunler.Rows)
            {
                if (row.IsNewRow) continue;

                bool bulundu = false;

                if (row.Cells[0].Value != null)
                {
                    string urunAdi = row.Cells[0].Value.ToString().ToLower();
                    if (urunAdi.Contains(aranan))
                    {
                        bulundu = true;
                        bulunanSayisi++;
                    }
                }

                row.Visible = bulundu;
            }

            if (bulunanSayisi == 0)
            {
                ozetBilgilerGrpBox.Text = "Aradýðýnýz ürün bulunamadý!";
            }
            else
            {
                ozetBilgilerGrpBox.Text = $"{bulunanSayisi} ürün bulundu";
            }
        }
    }
}
