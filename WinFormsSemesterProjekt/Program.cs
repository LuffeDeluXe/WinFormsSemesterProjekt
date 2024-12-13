using WinformsSemesterprojekt;
using WinformsSemesterprojekt.Models;
using WinFormsSemesterProjekt.DataBase;

namespace WinFormsSemesterProjekt
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Initialize();
            Application.Run(new MainMenu());
        }


        private static void Initialize()
        {
            ProductLine productLine = new ProductLine(1, 1, 1, 1);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
        }
    }
}