﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsSemesterprojekt.Models;
using WinFormsSemesterProjekt.DataBase;
using WinFormsSemesterProjekt.GUI;
using WinFormsSemesterProjekt.GUI.PopUps;

namespace WinFormsSemesterProjekt
{
	public partial class Products : Form
	{
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

		private void buttonExport_Click(object sender, EventArgs e)
		{
			WriteToTxt(ProductList);
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
			saveFileDialog.FileName = "Lagerstatus over alle produkter.txt";
			saveFileDialog.Title = "Gem din tekstfil";

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				File.WriteAllText(saveFileDialog.FileName, txtContent);
			}

			MessageBox.Show($"Oprettelse af tekstfil succesfuld\n\n" +
							$"Fil sti: {saveFileDialog.FileName}");
		}
	}
}
