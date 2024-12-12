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
            var method = new CustomerDatabase();
            var anders = new Customer("Anders", "Jensen", 25252525, "aj@pp.dk", "Privatkunde", "Vejle");
            CustomerDatabase.UpdateCustomerInformation(anders);
            //anders.UpdateEmail("123");

            //method.CreateCustomer(anders);

            Initialize();
            Application.Run(new MainMenu());
        }
    }
}