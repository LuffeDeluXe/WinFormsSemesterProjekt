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
		public int ProductId { get; set; }

		public string Name { get; set; }

		public string Category { get; set; }

		public string Description { get; set; }

		public double Price { get; set; }

		public int Stock { get; set; }

		public EditProduct()
		{
			InitializeComponent();
		}

		public EditProduct(int id, string name, string category, string description, double price, int stock)
		{
			InitializeComponent();

			ProductId = id;

			Name = name;
			textBoxName.Text = name;

			Category = category;
			textBoxCategory.Text = category;

			Description = description;
			richTextBoxDescription.Text = description;

			Price = price;
			textBoxPrice.Text = price.ToString();

			Stock = stock;
			textBoxQuantity.Text = stock.ToString();
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

			Name = textBoxName.Text;
			Category = textBoxCategory.Text;
			Description = richTextBoxDescription.Text;
			Price = Convert.ToInt32(textBoxPrice.Text);
			Stock = Convert.ToInt32(textBoxQuantity.Text);

			ProductDatabase.UpdateProduct(ProductId, Name, Category, Description, Price, Stock);
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
