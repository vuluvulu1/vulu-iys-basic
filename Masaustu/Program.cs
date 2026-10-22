namespace Masaustu
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Açılır liste, kaydırma çubuğu gibi Windows'un kendi çizdiği parçalar da koyu renkte olsun.
            // Renklerin geri kalanı Tema.cs içinde.
            Application.SetColorMode(SystemColorMode.Dark);

            // Önce giriş penceresi açılır; giriş başarılı olursa ana pencereye geçilir.
            var giris = new GirisFormu();
            if (giris.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new AnaForm());
            }
        }
    }
}
