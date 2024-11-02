namespace BirdGame
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Babam saðolsun
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}