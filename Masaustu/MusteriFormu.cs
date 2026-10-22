using Modeller;

namespace Masaustu
{
    // Hem yeni müşteri eklemek hem de var olanı düzenlemek için kullanılır.
    public partial class MusteriFormu : Form
    {
        // null ise yeni müşteri ekleniyor demektir.
        private readonly Musteri? musteri;

        public MusteriFormu(Musteri? musteri)
        {
            InitializeComponent();
            Tema.Uygula(this);
            this.musteri = musteri;

            if (musteri == null)
            {
                Text = "Yeni müşteri";
            }
            else
            {
                Text = "Müşteriyi düzenle";
                txtAdSoyad.Text = musteri.AdSoyad;
                txtTelefon.Text = musteri.Telefon;
                txtEmail.Text = musteri.Email;
                txtAdres.Text = musteri.Adres;
            }
        }

        private async void btnKaydet_Click(object sender, EventArgs e)
        {
            var yeniBilgiler = new Musteri
            {
                AdSoyad = txtAdSoyad.Text,
                Telefon = txtTelefon.Text,
                Email = txtEmail.Text,
                Adres = txtAdres.Text
            };

            btnKaydet.Enabled = false;
            try
            {
                if (musteri == null)
                {
                    await Api.Gonder<Musteri>("api/musteriler", yeniBilgiler);
                }
                else
                {
                    await Api.Guncelle("api/musteriler/" + musteri.Id, yeniBilgiler);
                }
                DialogResult = DialogResult.OK;
            }
            catch (Exception hata)
            {
                Yardimci.Hata(hata);
            }
            btnKaydet.Enabled = true;
        }
    }
}
