using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformsSemesterprojekt;
using WinformsSemesterprojekt.Models;

namespace WinFormsSemesterProjekt.GUI
{
    internal class GUICustomersMethods
    {
        public static void DeleteCustomer(BindingList<Customer> list, int customerId)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].CustomerID == customerId)
                {
                    list.RemoveAt(i);
                }
            }
        }

        public static List<Customer> FilterByType(List<Customer> list, Customers customers)
        {
            List<Customer> filterResult = new List<Customer>();

            foreach (Customer customer in list)
            {
                if (customers.radioButtonPrivateCustomer.Checked && customer.CustomerType == "Privatkunde")
                {
                    filterResult.Add(customer);
                }
                if (customers.radioButtonCompany.Checked && customer.CustomerType == "Erhvervskunde")
                {
                    filterResult.Add(customer);
                }
                if (!customers.radioButtonCompany.Checked && !customers.radioButtonPrivateCustomer.Checked)
                {
                    filterResult.Add(customer);
                }
            }
            return filterResult;
        }
    }
}
