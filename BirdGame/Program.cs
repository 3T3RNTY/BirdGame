namespace BirdGame
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Babam sa�olsun
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}