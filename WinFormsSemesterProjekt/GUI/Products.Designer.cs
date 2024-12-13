﻿namespace WinFormsSemesterProjekt
{
    partial class Products
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			buttonSearch = new Button();
			buttonMainMenu = new Button();
			searchBar = new TextBox();
			dataGridView1 = new DataGridView();
			buttonNewProduct = new Button();
			buttonEditProduct = new Button();
			buttonDeleteProduct = new Button();
			listBoxCategories = new ListBox();
			radioButtonAvailable = new RadioButton();
			radioButtonUnavailable = new RadioButton();
			buttonExport = new Button();
			comboBoxSortby = new ComboBox();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Trebuchet MS", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(10, 7);
			label1.Name = "label1";
			label1.Size = new Size(156, 40);
			label1.TabIndex = 0;
			label1.Text = "Produkter";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(10, 68);
			label2.Name = "label2";
			label2.Size = new Size(159, 22);
			label2.TabIndex = 1;
			label2.Text = "Filtrer efter kategori";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.Location = new Point(10, 213);
			label3.Name = "label3";
			label3.Size = new Size(175, 22);
			label3.TabIndex = 2;
			label3.Text = "Filtrer efter lagerstatus";
			// 
			// buttonSearch
			// 
			buttonSearch.BackColor = Color.Black;
			buttonSearch.FlatStyle = FlatStyle.Flat;
			buttonSearch.ForeColor = SystemColors.ControlLightLight;
			buttonSearch.Location = new Point(607, 16);
			buttonSearch.Margin = new Padding(3, 2, 3, 2);
			buttonSearch.Name = "buttonSearch";
			buttonSearch.Size = new Size(82, 22);
			buttonSearch.TabIndex = 3;
			buttonSearch.Text = "Søg";
			buttonSearch.UseVisualStyleBackColor = false;
			buttonSearch.Click += buttonSearch_Click;
			// 
			// buttonMainMenu
			// 
			buttonMainMenu.BackColor = Color.Black;
			buttonMainMenu.FlatStyle = FlatStyle.Flat;
			buttonMainMenu.ForeColor = SystemColors.ControlLightLight;
			buttonMainMenu.Location = new Point(10, 307);
			buttonMainMenu.Margin = new Padding(3, 2, 3, 2);
			buttonMainMenu.Name = "buttonMainMenu";
			buttonMainMenu.Size = new Size(108, 22);
			buttonMainMenu.TabIndex = 4;
			buttonMainMenu.Text = "Hovedmenu";
			buttonMainMenu.UseVisualStyleBackColor = false;
			// 
			// searchBar
			// 
			searchBar.BorderStyle = BorderStyle.FixedSingle;
			searchBar.Location = new Point(274, 18);
			searchBar.Margin = new Padding(3, 2, 3, 2);
			searchBar.Name = "searchBar";
			searchBar.Size = new Size(328, 23);
			searchBar.TabIndex = 5;
			searchBar.Enter += searchBar_Enter;
			searchBar.Leave += searchBar_Leave;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(274, 68);
			dataGridView1.Margin = new Padding(3, 2, 3, 2);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(416, 228);
			dataGridView1.TabIndex = 6;
			dataGridView1.CellClick += dataGridView1_CellClick;
			// 
			// buttonNewProduct
			// 
			buttonNewProduct.BackColor = Color.Black;
			buttonNewProduct.FlatStyle = FlatStyle.Flat;
			buttonNewProduct.ForeColor = SystemColors.ControlLightLight;
			buttonNewProduct.Location = new Point(274, 307);
			buttonNewProduct.Margin = new Padding(3, 2, 3, 2);
			buttonNewProduct.Name = "buttonNewProduct";
			buttonNewProduct.Size = new Size(130, 22);
			buttonNewProduct.TabIndex = 7;
			buttonNewProduct.Text = "Nyt produkt";
			buttonNewProduct.UseVisualStyleBackColor = false;
			buttonNewProduct.Click += buttonNewProduct_Click;
			// 
			// buttonEditProduct
			// 
			buttonEditProduct.BackColor = Color.Black;
			buttonEditProduct.FlatStyle = FlatStyle.Flat;
			buttonEditProduct.ForeColor = SystemColors.ControlLightLight;
			buttonEditProduct.Location = new Point(416, 307);
			buttonEditProduct.Margin = new Padding(3, 2, 3, 2);
			buttonEditProduct.Name = "buttonEditProduct";
			buttonEditProduct.Size = new Size(130, 22);
			buttonEditProduct.TabIndex = 8;
			buttonEditProduct.Text = "Ændr valgt produkt";
			buttonEditProduct.UseVisualStyleBackColor = false;
			buttonEditProduct.Click += buttonEditProduct_Click;
			// 
			// buttonDeleteProduct
			// 
			buttonDeleteProduct.BackColor = Color.Black;
			buttonDeleteProduct.ForeColor = SystemColors.ControlLightLight;
			buttonDeleteProduct.Location = new Point(560, 307);
			buttonDeleteProduct.Margin = new Padding(3, 2, 3, 2);
			buttonDeleteProduct.Name = "buttonDeleteProduct";
			buttonDeleteProduct.Size = new Size(130, 22);
			buttonDeleteProduct.TabIndex = 9;
			buttonDeleteProduct.Text = "Slet valgt produkt";
			buttonDeleteProduct.UseVisualStyleBackColor = false;
			buttonDeleteProduct.Click += buttonDeleteProduct_Click;
			// 
			// listBoxCategories
			// 
			listBoxCategories.FormattingEnabled = true;
			listBoxCategories.ItemHeight = 15;
			listBoxCategories.Location = new Point(18, 88);
			listBoxCategories.Margin = new Padding(3, 2, 3, 2);
			listBoxCategories.Name = "listBoxCategories";
			listBoxCategories.Size = new Size(195, 124);
			listBoxCategories.TabIndex = 11;
			listBoxCategories.SelectedIndexChanged += listBoxCategories_SelectedIndexChanged;
			// 
			// radioButtonAvailable
			// 
			radioButtonAvailable.AutoSize = true;
			radioButtonAvailable.Location = new Point(18, 235);
			radioButtonAvailable.Margin = new Padding(3, 2, 3, 2);
			radioButtonAvailable.Name = "radioButtonAvailable";
			radioButtonAvailable.Size = new Size(67, 19);
			radioButtonAvailable.TabIndex = 12;
			radioButtonAvailable.TabStop = true;
			radioButtonAvailable.Text = "På lager";
			radioButtonAvailable.UseVisualStyleBackColor = true;
			// 
			// radioButtonUnavailable
			// 
			radioButtonUnavailable.AutoSize = true;
			radioButtonUnavailable.Location = new Point(18, 257);
			radioButtonUnavailable.Margin = new Padding(3, 2, 3, 2);
			radioButtonUnavailable.Name = "radioButtonUnavailable";
			radioButtonUnavailable.Size = new Size(91, 19);
			radioButtonUnavailable.TabIndex = 13;
			radioButtonUnavailable.TabStop = true;
			radioButtonUnavailable.Text = "Ikke på lager";
			radioButtonUnavailable.UseVisualStyleBackColor = true;
			// 
			// buttonExport
			// 
			buttonExport.BackColor = Color.Black;
			buttonExport.FlatStyle = FlatStyle.Flat;
			buttonExport.ForeColor = SystemColors.ControlLightLight;
			buttonExport.Location = new Point(274, 43);
			buttonExport.Margin = new Padding(3, 2, 3, 2);
			buttonExport.Name = "buttonExport";
			buttonExport.Size = new Size(178, 22);
			buttonExport.TabIndex = 14;
			buttonExport.Text = "Eksporter lagerstatus til .txt";
			buttonExport.UseVisualStyleBackColor = false;
			buttonExport.Click += buttonExport_Click;
			// 
			// comboBoxSortby
			// 
			comboBoxSortby.BackColor = Color.Black;
			comboBoxSortby.FlatStyle = FlatStyle.Flat;
			comboBoxSortby.ForeColor = SystemColors.ControlLightLight;
			comboBoxSortby.FormattingEnabled = true;
			comboBoxSortby.Items.AddRange(new object[] { "Navn: A-Å", "Navn: Å-A", "Kategori: A-Å", "Kategori: Å-A", "Pris: Stigende", "Pris: Faldende" });
			comboBoxSortby.Location = new Point(586, 44);
			comboBoxSortby.Margin = new Padding(3, 2, 3, 2);
			comboBoxSortby.Name = "comboBoxSortby";
			comboBoxSortby.Size = new Size(104, 23);
			comboBoxSortby.TabIndex = 47;
			comboBoxSortby.Text = "Sorter efter";
			// 
			// Products
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.LightGoldenrodYellow;
			ClientSize = new Size(700, 338);
			Controls.Add(comboBoxSortby);
			Controls.Add(buttonExport);
			Controls.Add(radioButtonUnavailable);
			Controls.Add(radioButtonAvailable);
			Controls.Add(listBoxCategories);
			Controls.Add(buttonDeleteProduct);
			Controls.Add(buttonEditProduct);
			Controls.Add(buttonNewProduct);
			Controls.Add(dataGridView1);
			Controls.Add(searchBar);
			Controls.Add(buttonMainMenu);
			Controls.Add(buttonSearch);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Margin = new Padding(3, 2, 3, 2);
			Name = "Products";
			Text = "Products";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonSearch;
        private Button buttonMainMenu;
        private TextBox searchBar;
        private DataGridView dataGridView1;
        private Button buttonNewProduct;
        private Button buttonEditProduct;
        private Button buttonDeleteProduct;
        private ListBox listBoxCategories;
        private RadioButton radioButtonAvailable;
        private RadioButton radioButtonUnavailable;
        private Button buttonExport;
        private ComboBox comboBoxSortby;
    }
}