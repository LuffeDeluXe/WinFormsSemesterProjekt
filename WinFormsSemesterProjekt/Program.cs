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
            //Customer aj = new Customer("anders", "jensen", 25262728, "aj@pp.dk", "private", "the moon");

            Initialize();
            Application.Run(new MainMenu());


            //"anders", "jensen", 25262728, aj@pp.dk, "private", "the moon");
        }


        private static void Initialize()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
        }


        //private static void Initialize()
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    Application.SetHighDpiMode(HighDpiMode.SystemAware);
        //}
    }
}