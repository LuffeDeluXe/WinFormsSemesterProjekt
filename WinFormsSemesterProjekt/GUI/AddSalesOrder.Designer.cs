namespace WinFormsSemesterProjekt.GUI
{
    partial class AddSalesOrder
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
            buttonReturn = new Button();
            buttonAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            kundeOrderLabel = new Label();
            totalPriceTextBox = new TextBox();
            buttonAddProducts = new Button();
            kundeOrderTextBox = new TextBox();
            totalPriceLabel = new Label();
            productLineDataView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)productLineDataView).BeginInit();
            SuspendLayout();
            // 
            // buttonReturn
            // 
            buttonReturn.Location = new Point(19, 307);
            buttonReturn.Margin = new Padding(3, 2, 3, 2);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(138, 22);
            buttonReturn.TabIndex = 26;
            buttonReturn.Text = "Tilbage til oversigt";
            buttonReturn.UseVisualStyleBackColor = true;
            buttonReturn.Click += buttonReturn_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(323, 307);
            buttonAdd.Margin = new Padding(3, 2, 3, 2);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(81, 22);
            buttonAdd.TabIndex = 25;
            buttonAdd.Text = "Færdig";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(193, 7);
            label1.Name = "label1";
            label1.Size = new Size(303, 49);
            label1.TabIndex = 14;
            label1.Text = "Opret salgsordre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 59);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 28;
            label2.Text = "Produkter:";
            // 
            // kundeOrderLabel
            // 
            kundeOrderLabel.AutoSize = true;
            kundeOrderLabel.Location = new Point(129, 224);
            kundeOrderLabel.Name = "kundeOrderLabel";
            kundeOrderLabel.Size = new Size(58, 15);
            kundeOrderLabel.TabIndex = 29;
            kundeOrderLabel.Text = "Kunde ID:";
            // 
            // totalPriceTextBox
            // 
            totalPriceTextBox.BorderStyle = BorderStyle.FixedSingle;
            totalPriceTextBox.Location = new Point(193, 248);
            totalPriceTextBox.Margin = new Padding(3, 2, 3, 2);
            totalPriceTextBox.Name = "totalPriceTextBox";
            totalPriceTextBox.Size = new Size(303, 23);
            totalPriceTextBox.TabIndex = 30;
            // 
            // buttonAddProducts
            // 
            buttonAddProducts.Location = new Point(502, 59);
            buttonAddProducts.Margin = new Padding(3, 2, 3, 2);
            buttonAddProducts.Name = "buttonAddProducts";
            buttonAddProducts.Size = new Size(116, 22);
            buttonAddProducts.TabIndex = 31;
            buttonAddProducts.Text = "Tilføj produkt";
            buttonAddProducts.UseVisualStyleBackColor = true;
            buttonAddProducts.Click += buttonAddProducts_Click;
            // 
            // kundeOrderTextBox
            // 
            kundeOrderTextBox.BorderStyle = BorderStyle.FixedSingle;
            kundeOrderTextBox.Location = new Point(193, 222);
            kundeOrderTextBox.Margin = new Padding(3, 2, 3, 2);
            kundeOrderTextBox.Name = "kundeOrderTextBox";
            kundeOrderTextBox.Size = new Size(303, 23);
            kundeOrderTextBox.TabIndex = 32;
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Location = new Point(119, 250);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(68, 15);
            totalPriceLabel.TabIndex = 33;
            totalPriceLabel.Text = "Samlet Pris:";
            // 
            // productLineDataView
            // 
            productLineDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productLineDataView.Location = new Point(193, 59);
            productLineDataView.Name = "productLineDataView";
            productLineDataView.Size = new Size(303, 150);
            productLineDataView.TabIndex = 34;
            // 
            // AddSalesOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(700, 338);
            Controls.Add(productLineDataView);
            Controls.Add(totalPriceLabel);
            Controls.Add(kundeOrderTextBox);
            Controls.Add(buttonAddProducts);
            Controls.Add(totalPriceTextBox);
            Controls.Add(kundeOrderLabel);
            Controls.Add(label2);
            Controls.Add(buttonReturn);
            Controls.Add(buttonAdd);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddSalesOrder";
            Text = "AddSalesOrder";
            ((System.ComponentModel.ISupportInitialize)productLineDataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonReturn;
        private Button buttonAdd;
        private Label label1;
        private Label label2;
        private Label kundeOrderLabel;
        private TextBox totalPriceTextBox;
        private Button buttonAddProducts;
        private TextBox kundeOrderTextBox;
        private Label totalPriceLabel;
        private DataGridView productLineDataView;
    }
}