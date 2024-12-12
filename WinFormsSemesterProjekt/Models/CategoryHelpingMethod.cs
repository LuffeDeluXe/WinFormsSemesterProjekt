using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformsSemesterprojekt.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace WinFormsSemesterProjekt.Models
{
    internal class CategoryHelpingMethod
    {
        // I parametret; som nu står til "List<Product>" ProductList, men den er egentlig en BindingList.

        public static List<string> FilterProductsByCategory(BindingList<Product> ProductList)
        {
            List<string> filteredListOfCategories = new List<string>();
            filteredListOfCategories.Insert(0, "Alle Kategorier");

            foreach (var product in ProductList)
            {
                if (!filteredListOfCategories.Contains(product.Category))
                {
                    filteredListOfCategories.Add(product.Category);

                    // Console.WriteLine er bare til test!
                    // Console.WriteLine($"{product.Category}");
                }
            }
            return filteredListOfCategories;
        }

        public static BindingList<Product> SelectedCategoryInstances(BindingList<Product> ProductList, string userInput)
        {
            BindingList<Product> filteredList = new BindingList<Product>();

            foreach (var product in ProductList)
            {
                if (product.Category == userInput)
                {
                    filteredList.Add(product);
                }
            }
            return filteredList;

        }
    }
}
