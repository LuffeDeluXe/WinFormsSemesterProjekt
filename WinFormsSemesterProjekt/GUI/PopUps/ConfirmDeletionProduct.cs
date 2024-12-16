using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsSemesterprojekt.Models;
using WinFormsSemesterProjekt.DataBase;

namespace WinFormsSemesterProjekt.GUI.PopUps
{
    public partial class ConfirmDeletionProduct : Form
    {
        private Product Product { get; set; }
        
        public ConfirmDeletionProduct(int productId)
        {
			InitializeComponent();

            Product = ProductDatabase.FindProduct(productId);

            label1.Text = $"Er du sikker på, at du\r\nvil slette {Product.ProductName}?";
		}

        private void buttonYes_Click(object sender, EventArgs e)
        {
            this.Close();
            ProductDatabase.DeleteProduct(Product.ProductID);
            DeletedProduct deletedProduct = new DeletedProduct(Product.ProductName);
            deletedProduct.Show();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.Close();
            Products products = new Products();
            products.Show();
        }
    }
}
