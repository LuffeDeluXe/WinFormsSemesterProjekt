using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsSemesterprojekt;
using WinformsSemesterprojekt.Models;
using WinFormsSemesterProjekt.DataBase;
using WinFormsSemesterProjekt.GUI;
using WinFormsSemesterProjekt.GUI.PopUps;
using WinFormsSemesterProjekt.Models;

namespace WinFormsSemesterProjekt
{
	public partial class Products : Form
	{
		private List<string> _Categories { get; set; }

		public static Panel ProductsPanel;

		private BindingList<Product> ProductList { get; set; }

		private BindingList<Product> FilteredList { get; set; }

		private int ProductID { get; set; }

		public Products()
		{
			InitializeComponent();

			ProductList = new BindingList<Product>(ProductDatabase.FindAllProducts());
			FilteredList = new BindingList<Product>();
			dataGridView1.DataSource = ProductList;
			searchBar.Text = "Søg efter et produkt...";
			searchBar.ForeColor = Color.LightGray;

			_Categories = CategoryHelpingMethod.FilterProductsByCategory(ProductList);
			listBoxCategories.DataSource = _Categories;
		}

		private void searchBar_Leave(object sender, EventArgs e)
		{
			if (searchBar.Text == "" || String.IsNullOrEmpty(searchBar.Text))
			{
				searchBar.Text = "Søg efter et produkt...";
				searchBar.ForeColor = Color.LightGray;

				dataGridView1.DataSource = ProductList;

				dataGridView1.Refresh();
			}
		}

		private void searchBar_Enter(object sender, EventArgs e)
		{
			if (searchBar.Text == "Søg efter et produkt..." || String.IsNullOrEmpty(searchBar.Text))
			{
				searchBar.Text = "";
				searchBar.ForeColor = Color.Black;

				dataGridView1.DataSource = ProductList;

				dataGridView1.Refresh();
			}
		}

		private void buttonNewProduct_Click(object sender, EventArgs e)
		{
			AddProduct addProduct = new AddProduct();
			addProduct.Show();
			this.Hide();
		}

		private void buttonDeleteProduct_Click(object sender, EventArgs e)
		{
			if (ProductID != 0)
			{
				ConfirmDeletionProduct confirmDeletionProduct = new ConfirmDeletionProduct(ProductID);
				confirmDeletionProduct.Show();
				this.Close();
			}
			else
			{
				MessageBox.Show("Please pick a product");
			}
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			string searchInput = searchBar.Text;

			if (int.TryParse(searchInput, out int convertedInput))
			{
				Product foundProduct = ProductDatabase.FindProduct(convertedInput);

				FilteredList.Clear();

				FilteredList.Add(foundProduct);

				dataGridView1.DataSource = FilteredList;

				dataGridView1.Refresh();
			}
		}

		private void buttonEditProduct_Click(object sender, EventArgs e)
		{
			if (Name != null)
			{
				EditProduct editProduct = new EditProduct(ProductID);
				editProduct.Show();
				this.Close();
			}
			else
			{
				MessageBox.Show("Please pick a product");
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
			ProductID = Convert.ToInt32(selectedRow.Cells[0].Value);
		}

		private void listBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBoxCategories.SelectedIndex != 0)
			{
				BindingList<Product> catogoryResultsDisplayed = CategoryHelpingMethod.SelectedCategoryInstances(ProductList, _Categories[listBoxCategories.SelectedIndex]);
				dataGridView1.DataSource = catogoryResultsDisplayed;
				dataGridView1.Refresh();
			}
			else
			{
				dataGridView1.DataSource = ProductList;
				dataGridView1.Refresh();
			}
		}

		private void buttonExport_Click(object sender, EventArgs e)
		{
			int index = listBoxCategories.SelectedIndex;
			WriteToTxt(listBoxCategoriesSelectedList(index));
		}

		private BindingList<Product> listBoxCategoriesSelectedList(int index)
		{
			if (listBoxCategories.SelectedIndex != 0)
			{
				BindingList<Product> catogoryResultsDisplayed = CategoryHelpingMethod.SelectedCategoryInstances(ProductList, _Categories[listBoxCategories.SelectedIndex]);
				dataGridView1.DataSource = catogoryResultsDisplayed;
				return catogoryResultsDisplayed;
			}
			else
			{
				dataGridView1.DataSource = ProductList;
				return ProductList;
			}

		}

		private void WriteToTxt(BindingList<Product> listOfProducts)
		{
			string txtContent = "";

			foreach (var product in listOfProducts)
			{
				txtContent += $"Produktnavn: {product.ProductName}, " +
							  $"Produktkategori: {product.Category}, " +
							  $"Produktpris: {product.Price}, " +
							  $"Lagerbeholdning: {product.Stock}\n";
			}

			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Tekstfil|*.txt";
			saveFileDialog.FileName = $"Lager over {_Categories[listBoxCategories.SelectedIndex]}.txt";

			saveFileDialog.Title = "Gem din tekstfil";

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				File.WriteAllText(saveFileDialog.FileName, txtContent);
				MessageBox.Show($"Oprettelse af tekstfil succesfuld\n\n" +
							$"Fil sti: {saveFileDialog.FileName}");
			}

		}
	}
}
