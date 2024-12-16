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

namespace WinFormsSemesterProjekt.GUI
{
	public partial class WinShowProductDetails : Form
	{
		Product Product { get; set; }

		public WinShowProductDetails(int productId)
		{
			InitializeComponent();

			Product = ProductDatabase.FindProduct(productId);
			textBoxName.Text = Product.ProductName;
			textBoxCategory.Text = Product.Category;
			textBoxQuantity.Text = Product.Stock.ToString();
			textBoxPrice.Text = Product.Price.ToString();
			richTextBoxDescription.Text = Product.Description;
		}

		private void buttonReturn_Click(object sender, EventArgs e)
		{
			Products products = new Products();
			products.Show();
			this.Close();
		}
	}
}
