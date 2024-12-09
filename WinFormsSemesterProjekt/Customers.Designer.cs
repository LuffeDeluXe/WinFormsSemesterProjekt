namespace WinFormsSemesterProjekt
{
    partial class Customers
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
            radioButtonCompany = new RadioButton();
            radioButtonPrivateCustomer = new RadioButton();
            buttonSortBy = new Button();
            buttonDeleteCustomer = new Button();
            buttonEditCustomer = new Button();
            buttonNewCustomer = new Button();
            dataGridView1 = new DataGridView();
            searchBar = new TextBox();
            buttonMainMenu = new Button();
            buttonSearch = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // radioButtonCompany
            // 
            radioButtonCompany.AutoSize = true;
            radioButtonCompany.Location = new Point(20, 152);
            radioButtonCompany.Name = "radioButtonCompany";
            radioButtonCompany.Size = new Size(124, 24);
            radioButtonCompany.TabIndex = 44;
            radioButtonCompany.TabStop = true;
            radioButtonCompany.Text = "Erhvervskunde";
            radioButtonCompany.UseVisualStyleBackColor = true;
            // 
            // radioButtonPrivateCustomer
            // 
            radioButtonPrivateCustomer.AutoSize = true;
            radioButtonPrivateCustomer.Location = new Point(20, 122);
            radioButtonPrivateCustomer.Name = "radioButtonPrivateCustomer";
            radioButtonPrivateCustomer.Size = new Size(107, 24);
            radioButtonPrivateCustomer.TabIndex = 43;
            radioButtonPrivateCustomer.TabStop = true;
            radioButtonPrivateCustomer.Text = "Privatkunde";
            radioButtonPrivateCustomer.UseVisualStyleBackColor = true;
            // 
            // buttonSortBy
            // 
            buttonSortBy.BackColor = Color.Black;
            buttonSortBy.FlatStyle = FlatStyle.Flat;
            buttonSortBy.ForeColor = SystemColors.ControlLightLight;
            buttonSortBy.Location = new Point(694, 59);
            buttonSortBy.Name = "buttonSortBy";
            buttonSortBy.Size = new Size(94, 29);
            buttonSortBy.TabIndex = 40;
            buttonSortBy.Text = "Sorter efter";
            buttonSortBy.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteCustomer
            // 
            buttonDeleteCustomer.BackColor = Color.Black;
            buttonDeleteCustomer.ForeColor = SystemColors.ControlLightLight;
            buttonDeleteCustomer.Location = new Point(640, 411);
            buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            buttonDeleteCustomer.Size = new Size(148, 29);
            buttonDeleteCustomer.TabIndex = 39;
            buttonDeleteCustomer.Text = "Slet valgt kunde";
            buttonDeleteCustomer.UseVisualStyleBackColor = false;
            // 
            // buttonEditCustomer
            // 
            buttonEditCustomer.BackColor = Color.Black;
            buttonEditCustomer.FlatStyle = FlatStyle.Flat;
            buttonEditCustomer.ForeColor = SystemColors.ControlLightLight;
            buttonEditCustomer.Location = new Point(476, 411);
            buttonEditCustomer.Name = "buttonEditCustomer";
            buttonEditCustomer.Size = new Size(148, 29);
            buttonEditCustomer.TabIndex = 38;
            buttonEditCustomer.Text = "Ændr valgt kunde";
            buttonEditCustomer.UseVisualStyleBackColor = false;
            // 
            // buttonNewCustomer
            // 
            buttonNewCustomer.BackColor = Color.Black;
            buttonNewCustomer.FlatStyle = FlatStyle.Flat;
            buttonNewCustomer.ForeColor = SystemColors.ControlLightLight;
            buttonNewCustomer.Location = new Point(313, 411);
            buttonNewCustomer.Name = "buttonNewCustomer";
            buttonNewCustomer.Size = new Size(148, 29);
            buttonNewCustomer.TabIndex = 37;
            buttonNewCustomer.Text = "Ny kunde";
            buttonNewCustomer.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(313, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(475, 304);
            dataGridView1.TabIndex = 36;
            // 
            // searchBar
            // 
            searchBar.BorderStyle = BorderStyle.FixedSingle;
            searchBar.Location = new Point(313, 26);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(375, 27);
            searchBar.TabIndex = 35;
            // 
            // buttonMainMenu
            // 
            buttonMainMenu.BackColor = Color.Black;
            buttonMainMenu.FlatStyle = FlatStyle.Flat;
            buttonMainMenu.ForeColor = SystemColors.ControlLightLight;
            buttonMainMenu.Location = new Point(12, 411);
            buttonMainMenu.Name = "buttonMainMenu";
            buttonMainMenu.Size = new Size(123, 29);
            buttonMainMenu.TabIndex = 34;
            buttonMainMenu.Text = "Hovedmenu";
            buttonMainMenu.UseVisualStyleBackColor = false;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.Black;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.ForeColor = SystemColors.ControlLightLight;
            buttonSearch.Location = new Point(694, 24);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 29);
            buttonSearch.TabIndex = 33;
            buttonSearch.Text = "Søg";
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 202);
            label3.Name = "label3";
            label3.Size = new Size(196, 26);
            label3.TabIndex = 32;
            label3.Text = "Filtrer efter område";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 93);
            label2.Name = "label2";
            label2.Size = new Size(221, 26);
            label2.TabIndex = 31;
            label2.Text = "Filtrer efter kundetype";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(148, 49);
            label1.TabIndex = 30;
            label1.Text = "Kunder";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(20, 231);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(213, 164);
            listBox1.TabIndex = 45;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(radioButtonCompany);
            Controls.Add(radioButtonPrivateCustomer);
            Controls.Add(buttonSortBy);
            Controls.Add(buttonDeleteCustomer);
            Controls.Add(buttonEditCustomer);
            Controls.Add(buttonNewCustomer);
            Controls.Add(dataGridView1);
            Controls.Add(searchBar);
            Controls.Add(buttonMainMenu);
            Controls.Add(buttonSearch);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Customers";
            Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButtonCompany;
        private RadioButton radioButtonPrivateCustomer;
        private Button buttonSortBy;
        private Button buttonDeleteCustomer;
        private Button buttonEditCustomer;
        private Button buttonNewCustomer;
        private DataGridView dataGridView1;
        private TextBox searchBar;
        private Button buttonMainMenu;
        private Button buttonSearch;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox listBox1;
    }
}