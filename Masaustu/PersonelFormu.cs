using Modeller;

namespace Masaustu
{
    public partial class PersonelFormu : Form
    {
        public PersonelFormu()
        {
            InitializeComponent();
        }

        private async void Form_Load(object sender, EventArgs e)
        {
            Yardimci.TabloyuHazirla(dgvPersonel);
            dgvPersonel.Columns.Add("KullaniciAdi", "Kullanıcı adı");
            dgvPersonel.Columns.Add("AdSoyad", "Ad soyad");
            dgvPersonel.Columns.Add("Telefon", "Telefon");
            dgvPersonel.Columns.Add("Rol", "Rol");
            dgvPersonel.Columns.Add("Stok", "Stok yetkisi");
            dgvPersonel.Columns.Add("Durum", "Durum");

            await Listele();
        }

        private async Task Listele()
        {
            try
            {
                List<Kullanici> personel = await Api.Getir<List<Kullanici>>("api/personel");

                dgvPersonel.Rows.Clear();
                foreach (Kullanici kisi in personel)
                {
                    string stok = kisi.StokDuzenleyebilirMi() ? "Var" : "Yok";
                    string durum = kisi.AktifMi ? "Aktif" : "Pasif";
                    int satir = dgvPersonel.Rows.Add(kisi.KullaniciAdi, kisi.AdSoyad, kisi.Telefon, kisi.Rol, stok, durum);
                    dgvPersonel.Rows[satir].Tag = kisi;

                    if (!kisi.AktifMi)
                    {
                        dgvPersonel.Rows[satir].DefaultCellStyle.ForeColor = SystemColors.GrayText;
                    }
                }
            }
            catch (Exception hata)
            {
                Yardimci.Hata(hata);
            }
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {
            if (new PersonelDuzenleFormu(null).ShowDialog() == DialogResult.OK)
            {
                await Listele();
            }
        }

        private async void btnDuzenle_Click(object sender, EventArgs e)
        {
            await SeciliyiDuzenle();
        }

        private async void dgvPersonel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            await SeciliyiDuzenle();
        }

        private async Task SeciliyiDuzenle()
        {
            Kullanici? kisi = Yardimci.SeciliKayit<Kullanici>(dgvPersonel);
            if (kisi == null)
            {
                MessageBox.Show("Önce bir personel seçin.");
                return;
            }

            if (new PersonelDuzenleFormu(kisi).ShowDialog() == DialogResult.OK)
            {
                await Listele();
            }
        }
    }
}
