namespace Masaustu
{
    // Birçok formda tekrar eden küçük işler.
    public static class Yardimci
    {
        // Listeleme tablolarını aynı görünüme getirir: salt okunur, satır seçimli, sütunlar pencereyi doldurur.
        public static void TabloyuHazirla(DataGridView tablo)
        {
            tablo.ReadOnly = true;
            tablo.AllowUserToAddRows = false;
            tablo.AllowUserToDeleteRows = false;
            tablo.AllowUserToResizeRows = false;
            tablo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablo.MultiSelect = false;
            tablo.RowHeadersVisible = false;
            tablo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Para ve adet gibi sayılar sağa yaslı daha kolay okunur.
        public static void SagaYasla(DataGridView tablo, params string[] sutunlar)
        {
            foreach (string ad in sutunlar)
            {
                DataGridViewColumn? sutun = tablo.Columns[ad];
                if (sutun != null)
                {
                    sutun.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    sutun.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
        }

        // Sütunlar tabloyu doldurur; pay ne kadar büyükse sütun o kadar geniş olur (varsayılan pay 100).
        public static void SutunPayi(DataGridView tablo, string ad, int pay)
        {
            DataGridViewColumn? sutun = tablo.Columns[ad];
            if (sutun != null)
            {
                sutun.FillWeight = pay;
            }
        }

        // Her satırın Tag'ine o satırın kaydı konur; seçili satırın kaydını buradan geri alırız.
        public static T? SeciliKayit<T>(DataGridView tablo) where T : class
        {
            if (tablo.CurrentRow == null)
            {
                return null;
            }
            return tablo.CurrentRow.Tag as T;
        }

        public static string Para(decimal tutar)
        {
            return tutar.ToString("N2") + " ₺";
        }

        // Veritabanında tarihler UTC saklanır, ekranda bilgisayarın saatine çevrilir.
        public static string Tarih(DateTime tarih)
        {
            return tarih.ToLocalTime().ToString("dd.MM.yyyy HH:mm");
        }

        // Dosyayı geçici klasöre yazar ve Windows'ta onu açan programla açar (PDF için tarayıcı ya da PDF okuyucu).
        public static void DosyayiAc(byte[] icerik, string dosyaAdi)
        {
            string yol = Path.Combine(Path.GetTempPath(), dosyaAdi);
            File.WriteAllBytes(yol, icerik);
            AdresiAc(yol);
        }

        // Bir dosyayı ya da internet adresini varsayılan programla açar.
        public static void AdresiAc(string adres)
        {
            var bilgi = new System.Diagnostics.ProcessStartInfo(adres) { UseShellExecute = true };
            System.Diagnostics.Process.Start(bilgi);
        }

        public static void Hata(Exception hata)
        {
            MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool Onayla(string soru)
        {
            return MessageBox.Show(soru, "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
    }
}
