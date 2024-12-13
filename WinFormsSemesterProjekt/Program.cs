using WinformsSemesterprojekt;
using WinFormsSemesterProjekt.DataBase;

namespace WinFormsSemesterProjekt
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Initialize()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
        }
        static void Main()
        {
            Initialize();
            Application.Run(new MainMenu());
        }


        //private static void Initialize()
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    Application.SetHighDpiMode(HighDpiMode.SystemAware);
        //}
    }
}