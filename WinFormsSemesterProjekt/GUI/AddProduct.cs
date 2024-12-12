using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsSemesterProjekt.DataBase;
using WinFormsSemesterProjekt.GUI.PopUps;

namespace WinFormsSemesterProjekt.GUI
{
	public partial class AddProduct : Form
	{
		public AddProduct()
		{
			InitializeComponent();
		}

		private void buttonReturn_Click(object sender, EventArgs e)
		{
			Products products = new Products();
			products.Show();
			this.Hide();
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			try
			{
				string name = textBoxName.Text;

				if (String.IsNullOrEmpty(name))
				{
					MessageBox.Show("Please type a name");
					throw new Exception();
				}

				string category = textBoxCategory.Text;

				if (String.IsNullOrEmpty(category))
				{
					MessageBox.Show("Please type a categoryname");
					throw new Exception();
				}

				string description = richTextBoxDescription.Text;

				if (String.IsNullOrEmpty(description))
				{
					MessageBox.Show("Please type a description");
					throw new Exception();
				}

				double unitPrice = Convert.ToInt32(textBoxPrice.Text);

				if (Double.IsNegative(unitPrice) && Double.IsNaN(unitPrice))
				{
					MessageBox.Show("Please type a correct value");
					throw new Exception();
				}

				int stock = Convert.ToInt32(textBoxQuantity.Text);

				if (int.IsNegative(stock))
				{
					MessageBox.Show("Please type a correct value");
					throw new Exception();
				}

				ProductDatabase.CreateNewProduct(name, category, description, unitPrice, stock);
				CreatedProduct createdProduct = new CreatedProduct();
				createdProduct.Show();
			}
			catch
			{

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
	}
}
