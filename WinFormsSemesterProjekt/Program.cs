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
        static void Main()
        {
            var method = new CustomerDatabase();
            var anders = new Customer("Anders", "Jensen", 25252525, "aj@pp.dk");
            CustomerDatabase.UpdateCustomerInformation(anders);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
            //anders.UpdateEmail("123");

            //method.CreateCustomer(anders);


        }
    }
}