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
using WinFormsSemesterProjekt.GUI.PopUps;

namespace WinFormsSemesterProjekt.GUI
{
	public partial class EditProduct : Form
	{
		private Product Product { get; set; }

		public EditProduct()
		{
			InitializeComponent();
		}

		public EditProduct(int id)
		{
			InitializeComponent();

			Product = ProductDatabase.FindProduct(id);
			textBoxName.Text = Product.ProductName;
			textBoxCategory.Text = Product.Category;
			richTextBoxDescription.Text = Product.Description;
			textBoxPrice.Text = Product.Price.ToString();
			textBoxQuantity.Text = Product.Stock.ToString();
		}

		private void buttonReturn_Click(object sender, EventArgs e)
		{
			this.Hide();
			Products products = new Products();
			products.Show();
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			UpdatedProduct updatedProduct = new UpdatedProduct();

			string newName = textBoxName.Text;
			string newCategory = textBoxCategory.Text;
			string newDescription = richTextBoxDescription.Text;
			double newPrice = Convert.ToDouble(textBoxPrice.Text);
			int newStock = Convert.ToInt32(textBoxQuantity.Text);

			ProductDatabase.UpdateProduct(Product.ProductID, newName, newCategory, newDescription, newPrice, newStock);
			updatedProduct.Show();
			this.Hide();
		}

		private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void textBoxCategory_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void textBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsPunctuation(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}
	}
}
