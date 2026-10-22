namespace Masaustu
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Önce giriş penceresi açılır; giriş başarılı olursa ana pencereye geçilir.
            var giris = new GirisFormu();
            if (giris.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new AnaForm());
            }
        }
    }
}
