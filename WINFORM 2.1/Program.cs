using _03_INFRAESTRUCTURA;

namespace _00_PRESENTACION_WINFORM
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ClienteRepositorioSQL clienteRepositorioSQL = new ClienteRepositorioSQL();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}