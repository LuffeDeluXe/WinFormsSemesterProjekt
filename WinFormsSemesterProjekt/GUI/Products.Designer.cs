namespace WinFormsSemesterProjekt
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
            buttonSortBy = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(197, 49);
            label1.TabIndex = 0;
            label1.Text = "Produkter";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(202, 26);
            label2.TabIndex = 1;
            label2.Text = "Filtrer efter kategori";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 284);
            label3.Name = "label3";
            label3.Size = new Size(227, 26);
            label3.TabIndex = 2;
            label3.Text = "Filtrer efter lagerstatus";
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.Black;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.ForeColor = SystemColors.ControlLightLight;
            buttonSearch.Location = new Point(694, 22);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 29);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "Søg";
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // buttonMainMenu
            // 
            buttonMainMenu.BackColor = Color.Black;
            buttonMainMenu.FlatStyle = FlatStyle.Flat;
            buttonMainMenu.ForeColor = SystemColors.ControlLightLight;
            buttonMainMenu.Location = new Point(12, 409);
            buttonMainMenu.Name = "buttonMainMenu";
            buttonMainMenu.Size = new Size(123, 29);
            buttonMainMenu.TabIndex = 4;
            buttonMainMenu.Text = "Hovedmenu";
            buttonMainMenu.UseVisualStyleBackColor = false;
            // 
            // searchBar
            // 
            searchBar.BorderStyle = BorderStyle.FixedSingle;
            searchBar.Location = new Point(313, 24);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(375, 27);
            searchBar.TabIndex = 5;
            searchBar.Enter += searchBar_Enter;
            searchBar.Leave += searchBar_Leave;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(313, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(475, 304);
            dataGridView1.TabIndex = 6;
            // 
            // buttonNewProduct
            // 
            buttonNewProduct.BackColor = Color.Black;
            buttonNewProduct.FlatStyle = FlatStyle.Flat;
            buttonNewProduct.ForeColor = SystemColors.ControlLightLight;
            buttonNewProduct.Location = new Point(313, 409);
            buttonNewProduct.Name = "buttonNewProduct";
            buttonNewProduct.Size = new Size(148, 29);
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
            buttonEditProduct.Location = new Point(476, 409);
            buttonEditProduct.Name = "buttonEditProduct";
            buttonEditProduct.Size = new Size(148, 29);
            buttonEditProduct.TabIndex = 8;
            buttonEditProduct.Text = "Ændr valgt produkt";
            buttonEditProduct.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteProduct
            // 
            buttonDeleteProduct.BackColor = Color.Black;
            buttonDeleteProduct.ForeColor = SystemColors.ControlLightLight;
            buttonDeleteProduct.Location = new Point(640, 409);
            buttonDeleteProduct.Name = "buttonDeleteProduct";
            buttonDeleteProduct.Size = new Size(148, 29);
            buttonDeleteProduct.TabIndex = 9;
            buttonDeleteProduct.Text = "Slet valgt produkt";
            buttonDeleteProduct.UseVisualStyleBackColor = false;
            // 
            // listBoxCategories
            // 
            listBoxCategories.FormattingEnabled = true;
            listBoxCategories.Location = new Point(20, 117);
            listBoxCategories.Name = "listBoxCategories";
            listBoxCategories.Size = new Size(222, 164);
            listBoxCategories.TabIndex = 11;
            // 
            // radioButtonAvailable
            // 
            radioButtonAvailable.AutoSize = true;
            radioButtonAvailable.Location = new Point(20, 313);
            radioButtonAvailable.Name = "radioButtonAvailable";
            radioButtonAvailable.Size = new Size(83, 24);
            radioButtonAvailable.TabIndex = 12;
            radioButtonAvailable.TabStop = true;
            radioButtonAvailable.Text = "På lager";
            radioButtonAvailable.UseVisualStyleBackColor = true;
            // 
            // radioButtonUnavailable
            // 
            radioButtonUnavailable.AutoSize = true;
            radioButtonUnavailable.Location = new Point(20, 343);
            radioButtonUnavailable.Name = "radioButtonUnavailable";
            radioButtonUnavailable.Size = new Size(115, 24);
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
            buttonExport.Location = new Point(313, 57);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(204, 29);
            buttonExport.TabIndex = 14;
            buttonExport.Text = "Eksporter lagerstatus til .txt";
            buttonExport.UseVisualStyleBackColor = false;
            // 
            // buttonSortBy
            // 
            buttonSortBy.BackColor = Color.Black;
            buttonSortBy.FlatStyle = FlatStyle.Flat;
            buttonSortBy.ForeColor = SystemColors.ControlLightLight;
            buttonSortBy.Location = new Point(694, 57);
            buttonSortBy.Name = "buttonSortBy";
            buttonSortBy.Size = new Size(94, 29);
            buttonSortBy.TabIndex = 10;
            buttonSortBy.Text = "Sorter efter";
            buttonSortBy.UseVisualStyleBackColor = false;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonExport);
            Controls.Add(radioButtonUnavailable);
            Controls.Add(radioButtonAvailable);
            Controls.Add(listBoxCategories);
            Controls.Add(buttonSortBy);
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
        private Button buttonSortBy;
    }
}