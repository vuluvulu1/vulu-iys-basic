using Modeller;

namespace Masaustu
{
    public partial class PersonelDuzenleFormu : Form
    {
        // null ise yeni personel ekleniyor demektir.
        private readonly Kullanici? kisi;

        public PersonelDuzenleFormu(Kullanici? kisi)
        {
            InitializeComponent();
            Tema.Uygula(this);
            this.kisi = kisi;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            cmbRol.Items.AddRange(Roller.Hepsi);

            if (kisi == null)
            {
                Text = "Yeni personel";
                cmbRol.Text = Roller.Teknisyen;
                chkAktif.Checked = true;
            }
            else
            {
                Text = "Personeli düzenle";
                txtKullaniciAdi.Text = kisi.KullaniciAdi;
                txtAdSoyad.Text = kisi.AdSoyad;
                txtTelefon.Text = kisi.Telefon;
                cmbRol.Text = kisi.Rol;
                chkStokYetkisi.Checked = kisi.StokYetkisi;
                chkAktif.Checked = kisi.AktifMi;

                // Kullanıcı adı açıldıktan sonra değişmez.
                txtKullaniciAdi.ReadOnly = true;
                lblSifreNotu.Text = "Boş bırakırsanız şifre değişmez.";
            }
        }

        private async void btnKaydet_Click(object sender, EventArgs e)
        {
            var istek = new PersonelIstegi
            {
                KullaniciAdi = txtKullaniciAdi.Text,
                AdSoyad = txtAdSoyad.Text,
                Telefon = txtTelefon.Text,
                Rol = cmbRol.Text,
                StokYetkisi = chkStokYetkisi.Checked,
                AktifMi = chkAktif.Checked,
                Sifre = txtSifre.Text
            };

            btnKaydet.Enabled = false;
            try
            {
                if (kisi == null)
                {
                    await Api.Gonder<Kullanici>("api/personel", istek);
                }
                else
                {
                    await Api.Guncelle("api/personel/" + kisi.Id, istek);
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
