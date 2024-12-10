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
            var customer = new Customer(1, "Anders", "Jensen", 25252525, "aj@pp.dk", "Helvedesvej 666");
            
            method.CreateCustomer(customer);
    

        }
    }
}