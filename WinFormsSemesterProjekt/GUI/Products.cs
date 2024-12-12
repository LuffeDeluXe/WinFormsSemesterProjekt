﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Drawing.Design;
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

        public BindingList<Product> ProductList { get; set; }

        public BindingList<Product> FilteredList { get; set; }

        public int ProductId { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public int Stock { get; set; }

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
            ConfirmDeletionProduct confirmDeletionProduct = new ConfirmDeletionProduct(ProductId, Name);
            confirmDeletionProduct.Show();
            this.Close();
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
            EditProduct editProduct = new EditProduct(ProductId, Name, Category, Description, Price, Stock);
            editProduct.Show();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            ProductId = Convert.ToInt32(selectedRow.Cells[0].Value);
            Name = selectedRow.Cells[1].Value.ToString();
            Category = selectedRow.Cells[2].Value.ToString();
            Description = selectedRow.Cells[3].Value.ToString();
            Price = Convert.ToDouble(selectedRow.Cells[4].Value);
            Stock = Convert.ToInt32(selectedRow.Cells[5].Value);
        }

        private void listBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Index = listBoxCategories.SelectedIndex;
            label1.Text = Index.ToString();

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

        private void searchBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
