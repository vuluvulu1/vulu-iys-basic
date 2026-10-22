namespace Paketleyici
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.SetColorMode(SystemColorMode.Dark);
            Application.Run(new PaketleyiciFormu());
        }
    }
}
