using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformsSemesterprojekt.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace WinFormsSemesterProjekt.Models
{
    internal class Category
    {
        // I parametret; som nu står til "List<Product>" ProductList, men den er egentlig en BindingList.

        public static List<string> FilterProductsByCategory(List<Product> ProductList, string userInput)
        {
            List<string> filteredListOfCategories = new List<string>();
            filteredListOfCategories.Insert(0, "Alle Kategorier");

            foreach (var product in ProductList)
            {
                if (product.Category == userInput)
                {
                    filteredListOfCategories.Add(product.Category);

                    // Console.WriteLine er bare til test!
                    // Console.WriteLine($"{product.Category}");
                }
            }
            return filteredListOfCategories;
        }
    }
}
