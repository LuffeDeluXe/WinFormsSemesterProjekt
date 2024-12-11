namespace WinFormsSemesterProjekt
{
    partial class Orders
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
            radioButtonFinished = new RadioButton();
            radioButtonUnfinished = new RadioButton();
            buttonDeleteOrder = new Button();
            buttonEditOrder = new Button();
            buttonNewOrder = new Button();
            dataGridView1 = new DataGridView();
            searchBar = new TextBox();
            buttonMainMenu = new Button();
            buttonSearch = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            comboBoxSortby = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // radioButtonFinished
            // 
            radioButtonFinished.AutoSize = true;
            radioButtonFinished.Location = new Point(20, 261);
            radioButtonFinished.Name = "radioButtonFinished";
            radioButtonFinished.Size = new Size(109, 24);
            radioButtonFinished.TabIndex = 27;
            radioButtonFinished.TabStop = true;
            radioButtonFinished.Text = "Gennemført";
            radioButtonFinished.UseVisualStyleBackColor = true;
            // 
            // radioButtonUnfinished
            // 
            radioButtonUnfinished.AutoSize = true;
            radioButtonUnfinished.Location = new Point(20, 231);
            radioButtonUnfinished.Name = "radioButtonUnfinished";
            radioButtonUnfinished.Size = new Size(138, 24);
            radioButtonUnfinished.TabIndex = 26;
            radioButtonUnfinished.TabStop = true;
            radioButtonUnfinished.Text = "Ikke gennemført";
            radioButtonUnfinished.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteOrder
            // 
            buttonDeleteOrder.BackColor = Color.Black;
            buttonDeleteOrder.ForeColor = SystemColors.ControlLightLight;
            buttonDeleteOrder.Location = new Point(640, 411);
            buttonDeleteOrder.Name = "buttonDeleteOrder";
            buttonDeleteOrder.Size = new Size(148, 29);
            buttonDeleteOrder.TabIndex = 23;
            buttonDeleteOrder.Text = "Slet valgt ordre";
            buttonDeleteOrder.UseVisualStyleBackColor = false;
            buttonDeleteOrder.Click += buttonDeleteOrder_Click;
            // 
            // buttonEditOrder
            // 
            buttonEditOrder.BackColor = Color.Black;
            buttonEditOrder.FlatStyle = FlatStyle.Flat;
            buttonEditOrder.ForeColor = SystemColors.ControlLightLight;
            buttonEditOrder.Location = new Point(476, 411);
            buttonEditOrder.Name = "buttonEditOrder";
            buttonEditOrder.Size = new Size(148, 29);
            buttonEditOrder.TabIndex = 22;
            buttonEditOrder.Text = "Ændr valgt ordre";
            buttonEditOrder.UseVisualStyleBackColor = false;
            // 
            // buttonNewOrder
            // 
            buttonNewOrder.BackColor = Color.Black;
            buttonNewOrder.FlatStyle = FlatStyle.Flat;
            buttonNewOrder.ForeColor = SystemColors.ControlLightLight;
            buttonNewOrder.Location = new Point(313, 411);
            buttonNewOrder.Name = "buttonNewOrder";
            buttonNewOrder.Size = new Size(148, 29);
            buttonNewOrder.TabIndex = 21;
            buttonNewOrder.Text = "Ny ordre";
            buttonNewOrder.UseVisualStyleBackColor = false;
            buttonNewOrder.Click += buttonNewOrder_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(313, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(475, 304);
            dataGridView1.TabIndex = 20;
            // 
            // searchBar
            // 
            searchBar.BorderStyle = BorderStyle.FixedSingle;
            searchBar.Location = new Point(313, 26);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(375, 27);
            searchBar.TabIndex = 19;
            searchBar.Leave += searchBar_Leave;
            // 
            // buttonMainMenu
            // 
            buttonMainMenu.BackColor = Color.Black;
            buttonMainMenu.FlatStyle = FlatStyle.Flat;
            buttonMainMenu.ForeColor = SystemColors.ControlLightLight;
            buttonMainMenu.Location = new Point(12, 411);
            buttonMainMenu.Name = "buttonMainMenu";
            buttonMainMenu.Size = new Size(123, 29);
            buttonMainMenu.TabIndex = 18;
            buttonMainMenu.Text = "Hovedmenu";
            buttonMainMenu.UseVisualStyleBackColor = false;
            buttonMainMenu.Click += buttonMainMenu_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.Black;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.ForeColor = SystemColors.ControlLightLight;
            buttonSearch.Location = new Point(694, 24);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 29);
            buttonSearch.TabIndex = 17;
            buttonSearch.Text = "Søg";
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 202);
            label3.Name = "label3";
            label3.Size = new Size(181, 26);
            label3.TabIndex = 16;
            label3.Text = "Filtrer efter status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 93);
            label2.Name = "label2";
            label2.Size = new Size(216, 26);
            label2.TabIndex = 15;
            label2.Text = "Filtrer efter ordretype";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(141, 49);
            label1.TabIndex = 14;
            label1.Text = "Ordrer";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(20, 122);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(101, 24);
            radioButton1.TabIndex = 28;
            radioButton1.TabStop = true;
            radioButton1.Text = "Salgsordre";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(20, 152);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(144, 24);
            radioButton2.TabIndex = 29;
            radioButton2.TabStop = true;
            radioButton2.Text = "Produktionsordre";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // comboBoxSortby
            // 
            comboBoxSortby.BackColor = Color.Black;
            comboBoxSortby.FlatStyle = FlatStyle.Flat;
            comboBoxSortby.ForeColor = SystemColors.ControlLightLight;
            comboBoxSortby.FormattingEnabled = true;
            comboBoxSortby.Items.AddRange(new object[] { "Ordrenr.: Stigende", "Ordrenr.: Faldende", "Dato: Nyeste", "Dato: Ældste" });
            comboBoxSortby.Location = new Point(670, 59);
            comboBoxSortby.Name = "comboBoxSortby";
            comboBoxSortby.Size = new Size(118, 28);
            comboBoxSortby.TabIndex = 47;
            comboBoxSortby.Text = "Sorter efter";
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxSortby);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(radioButtonFinished);
            Controls.Add(radioButtonUnfinished);
            Controls.Add(buttonDeleteOrder);
            Controls.Add(buttonEditOrder);
            Controls.Add(buttonNewOrder);
            Controls.Add(dataGridView1);
            Controls.Add(searchBar);
            Controls.Add(buttonMainMenu);
            Controls.Add(buttonSearch);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Orders";
            Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButtonFinished;
        private RadioButton radioButtonUnfinished;
        private Button buttonDeleteOrder;
        private Button buttonEditOrder;
        private Button buttonNewOrder;
        private DataGridView dataGridView1;
        private TextBox searchBar;
        private Button buttonMainMenu;
        private Button buttonSearch;
        private Label label3;
        private Label label2;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ComboBox comboBoxSortby;
    }
}