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
            orderSearchBar = new TextBox();
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
            radioButtonFinished.Location = new Point(18, 196);
            radioButtonFinished.Margin = new Padding(3, 2, 3, 2);
            radioButtonFinished.Name = "radioButtonFinished";
            radioButtonFinished.Size = new Size(89, 19);
            radioButtonFinished.TabIndex = 27;
            radioButtonFinished.TabStop = true;
            radioButtonFinished.Text = "Gennemført";
            radioButtonFinished.UseVisualStyleBackColor = true;
            // 
            // radioButtonUnfinished
            // 
            radioButtonUnfinished.AutoSize = true;
            radioButtonUnfinished.Location = new Point(18, 173);
            radioButtonUnfinished.Margin = new Padding(3, 2, 3, 2);
            radioButtonUnfinished.Name = "radioButtonUnfinished";
            radioButtonUnfinished.Size = new Size(112, 19);
            radioButtonUnfinished.TabIndex = 26;
            radioButtonUnfinished.TabStop = true;
            radioButtonUnfinished.Text = "Ikke gennemført";
            radioButtonUnfinished.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteOrder
            // 
            buttonDeleteOrder.BackColor = SystemColors.ButtonHighlight;
            buttonDeleteOrder.FlatAppearance.BorderSize = 0;
            buttonDeleteOrder.ForeColor = SystemColors.ActiveCaptionText;
            buttonDeleteOrder.Location = new Point(560, 308);
            buttonDeleteOrder.Margin = new Padding(3, 2, 3, 2);
            buttonDeleteOrder.Name = "buttonDeleteOrder";
            buttonDeleteOrder.Size = new Size(130, 22);
            buttonDeleteOrder.TabIndex = 23;
            buttonDeleteOrder.Text = "Slet valgte ordre";
            buttonDeleteOrder.UseVisualStyleBackColor = false;
            buttonDeleteOrder.Click += buttonDeleteOrder_Click;
            // 
            // buttonEditOrder
            // 
            buttonEditOrder.BackColor = SystemColors.ButtonHighlight;
            buttonEditOrder.FlatAppearance.BorderSize = 0;
            buttonEditOrder.ForeColor = SystemColors.ActiveCaptionText;
            buttonEditOrder.Location = new Point(416, 308);
            buttonEditOrder.Margin = new Padding(3, 2, 3, 2);
            buttonEditOrder.Name = "buttonEditOrder";
            buttonEditOrder.Size = new Size(130, 22);
            buttonEditOrder.TabIndex = 22;
            buttonEditOrder.Text = "Rediger valgte ordre";
            buttonEditOrder.UseVisualStyleBackColor = false;
            buttonEditOrder.Click += buttonEditOrder_Click;
            // 
            // buttonNewOrder
            // 
            buttonNewOrder.BackColor = SystemColors.ButtonHighlight;
            buttonNewOrder.FlatAppearance.BorderSize = 0;
            buttonNewOrder.ForeColor = SystemColors.ActiveCaptionText;
            buttonNewOrder.Location = new Point(274, 308);
            buttonNewOrder.Margin = new Padding(3, 2, 3, 2);
            buttonNewOrder.Name = "buttonNewOrder";
            buttonNewOrder.Size = new Size(130, 22);
            buttonNewOrder.TabIndex = 21;
            buttonNewOrder.Text = "Ny ordre";
            buttonNewOrder.UseVisualStyleBackColor = false;
            buttonNewOrder.Click += buttonNewOrder_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(274, 70);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(416, 228);
            dataGridView1.TabIndex = 20;
            // 
            // orderSearchBar
            // 
            orderSearchBar.BorderStyle = BorderStyle.FixedSingle;
            orderSearchBar.Location = new Point(274, 20);
            orderSearchBar.Margin = new Padding(3, 2, 3, 2);
            orderSearchBar.Name = "orderSearchBar";
            orderSearchBar.Size = new Size(328, 23);
            orderSearchBar.TabIndex = 19;
            // 
            // buttonMainMenu
            // 
            buttonMainMenu.BackColor = SystemColors.ButtonHighlight;
            buttonMainMenu.ForeColor = SystemColors.ActiveCaptionText;
            buttonMainMenu.Location = new Point(10, 308);
            buttonMainMenu.Margin = new Padding(3, 2, 3, 2);
            buttonMainMenu.Name = "buttonMainMenu";
            buttonMainMenu.Size = new Size(108, 22);
            buttonMainMenu.TabIndex = 18;
            buttonMainMenu.Text = "Hovedmenu";
            buttonMainMenu.UseVisualStyleBackColor = false;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = SystemColors.ButtonHighlight;
            buttonSearch.ForeColor = SystemColors.ActiveCaptionText;
            buttonSearch.Location = new Point(607, 18);
            buttonSearch.Margin = new Padding(3, 2, 3, 2);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(82, 22);
            buttonSearch.TabIndex = 17;
            buttonSearch.Text = "Søg";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 152);
            label3.Name = "label3";
            label3.Size = new Size(140, 22);
            label3.TabIndex = 16;
            label3.Text = "Filtrer efter status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 70);
            label2.Name = "label2";
            label2.Size = new Size(171, 22);
            label2.TabIndex = 15;
            label2.Text = "Filtrer efter ordretype";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 8);
            label1.Name = "label1";
            label1.Size = new Size(110, 40);
            label1.TabIndex = 14;
            label1.Text = "Ordrer";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(18, 92);
            radioButton1.Margin = new Padding(3, 2, 3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(80, 19);
            radioButton1.TabIndex = 28;
            radioButton1.TabStop = true;
            radioButton1.Text = "Salgsordre";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(18, 114);
            radioButton2.Margin = new Padding(3, 2, 3, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(117, 19);
            radioButton2.TabIndex = 29;
            radioButton2.TabStop = true;
            radioButton2.Text = "Produktionsordre";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // comboBoxSortby
            // 
            comboBoxSortby.BackColor = SystemColors.Window;
            comboBoxSortby.ForeColor = SystemColors.WindowText;
            comboBoxSortby.FormattingEnabled = true;
            comboBoxSortby.Items.AddRange(new object[] { "Ordrenr.: Stigende", "Ordrenr.: Faldende", "Dato: Nyeste", "Dato: Ældste" });
            comboBoxSortby.Location = new Point(586, 44);
            comboBoxSortby.Margin = new Padding(3, 2, 3, 2);
            comboBoxSortby.Name = "comboBoxSortby";
            comboBoxSortby.Size = new Size(104, 23);
            comboBoxSortby.TabIndex = 47;
            comboBoxSortby.Text = "Sorter efter";
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(700, 338);
            Controls.Add(comboBoxSortby);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(radioButtonFinished);
            Controls.Add(radioButtonUnfinished);
            Controls.Add(buttonDeleteOrder);
            Controls.Add(buttonEditOrder);
            Controls.Add(buttonNewOrder);
            Controls.Add(dataGridView1);
            Controls.Add(orderSearchBar);
            Controls.Add(buttonMainMenu);
            Controls.Add(buttonSearch);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
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
        private TextBox orderSearchBar;
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