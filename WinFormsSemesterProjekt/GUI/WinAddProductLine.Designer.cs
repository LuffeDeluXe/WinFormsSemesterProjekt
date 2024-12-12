namespace WinFormsSemesterProjekt.GUI
{
    partial class WinAddProductLine
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
            pLProductAmountNumeric = new NumericUpDown();
            pLProductView = new DataGridView();
            pLProductIDTextBox = new TextBox();
            pLPricePrUnitTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pLProductDescriptionBox = new TextBox();
            plProductSearchBar = new TextBox();
            pLSearchProductButton = new Button();
            productLineAddButton = new Button();
            pLProductNameBox = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pLProductAmountNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pLProductView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 0;
            label1.Text = "Produkter";
            // 
            // pLProductAmountNumeric
            // 
            pLProductAmountNumeric.Location = new Point(545, 105);
            pLProductAmountNumeric.Name = "pLProductAmountNumeric";
            pLProductAmountNumeric.Size = new Size(62, 23);
            pLProductAmountNumeric.TabIndex = 1;
            // 
            // pLProductView
            // 
            pLProductView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pLProductView.Location = new Point(12, 81);
            pLProductView.Name = "pLProductView";
            pLProductView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            pLProductView.Size = new Size(240, 245);
            pLProductView.TabIndex = 2;
            pLProductView.RowEnter += pLProductView_RowEnter;
            // 
            // pLProductIDTextBox
            // 
            pLProductIDTextBox.Location = new Point(258, 105);
            pLProductIDTextBox.Name = "pLProductIDTextBox";
            pLProductIDTextBox.Size = new Size(100, 23);
            pLProductIDTextBox.TabIndex = 3;
            // 
            // pLPricePrUnitTextBox
            // 
            pLPricePrUnitTextBox.Location = new Point(470, 105);
            pLPricePrUnitTextBox.Name = "pLPricePrUnitTextBox";
            pLPricePrUnitTextBox.Size = new Size(69, 23);
            pLPricePrUnitTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(258, 81);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 0;
            label2.Text = "Produkt ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(470, 80);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 0;
            label3.Text = "Pris Pr.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(545, 80);
            label4.Name = "label4";
            label4.Size = new Size(46, 21);
            label4.TabIndex = 0;
            label4.Text = "Antal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(258, 135);
            label5.Name = "label5";
            label5.Size = new Size(87, 21);
            label5.TabIndex = 0;
            label5.Text = "Beskrivelse";
            // 
            // pLProductDescriptionBox
            // 
            pLProductDescriptionBox.Location = new Point(258, 159);
            pLProductDescriptionBox.Multiline = true;
            pLProductDescriptionBox.Name = "pLProductDescriptionBox";
            pLProductDescriptionBox.Size = new Size(349, 167);
            pLProductDescriptionBox.TabIndex = 5;
            // 
            // plProductSearchBar
            // 
            plProductSearchBar.Location = new Point(12, 52);
            plProductSearchBar.Name = "plProductSearchBar";
            plProductSearchBar.Size = new Size(159, 23);
            plProductSearchBar.TabIndex = 3;
            plProductSearchBar.Enter += PLSearchBar_Enter;
            plProductSearchBar.Leave += PLSearchBar_Leave;
            // 
            // pLSearchProductButton
            // 
            pLSearchProductButton.Location = new Point(177, 52);
            pLSearchProductButton.Name = "pLSearchProductButton";
            pLSearchProductButton.Size = new Size(75, 23);
            pLSearchProductButton.TabIndex = 6;
            pLSearchProductButton.Text = "Søg";
            pLSearchProductButton.UseVisualStyleBackColor = true;
            pLSearchProductButton.Click += pLSearchProductButton_Click;
            // 
            // productLineAddButton
            // 
            productLineAddButton.Location = new Point(613, 106);
            productLineAddButton.Name = "productLineAddButton";
            productLineAddButton.Size = new Size(75, 23);
            productLineAddButton.TabIndex = 7;
            productLineAddButton.Text = "Tilføj";
            productLineAddButton.UseVisualStyleBackColor = true;
            // 
            // pLProductNameBox
            // 
            pLProductNameBox.Location = new Point(364, 105);
            pLProductNameBox.Name = "pLProductNameBox";
            pLProductNameBox.Size = new Size(100, 23);
            pLProductNameBox.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(364, 81);
            label6.Name = "label6";
            label6.Size = new Size(47, 21);
            label6.TabIndex = 8;
            label6.Text = "Navn";
            // 
            // WinAddProductLine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(700, 338);
            Controls.Add(pLProductNameBox);
            Controls.Add(label6);
            Controls.Add(productLineAddButton);
            Controls.Add(pLSearchProductButton);
            Controls.Add(pLProductDescriptionBox);
            Controls.Add(pLPricePrUnitTextBox);
            Controls.Add(plProductSearchBar);
            Controls.Add(pLProductIDTextBox);
            Controls.Add(pLProductView);
            Controls.Add(pLProductAmountNumeric);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "WinAddProductLine";
            Text = "WinAddProductLine";
            ((System.ComponentModel.ISupportInitialize)pLProductAmountNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)pLProductView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown pLProductAmountNumeric;
        private DataGridView pLProductView;
        private TextBox pLProductIDTextBox;
        private TextBox pLPricePrUnitTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox pLProductDescriptionBox;
        private TextBox plProductSearchBar;
        private Button pLSearchProductButton;
        private Button productLineAddButton;
        private TextBox pLProductNameBox;
        private Label label6;
    }
}