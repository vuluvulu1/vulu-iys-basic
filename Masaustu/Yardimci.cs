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
            tablo.BackgroundColor = SystemColors.Window;
        }

        // Para ve adet gibi sayılar sağa yaslı daha kolay okunur.
        public static void SagaYasla(DataGridView tablo, params string[] sutunlar)
        {
            foreach (string sutun in sutunlar)
            {
                tablo.Columns[sutun].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                tablo.Columns[sutun].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
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
