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
            buttonFinish = new Button();
            label1 = new Label();
            label2 = new Label();
            kundeOrderLabel = new Label();
            totalPriceTextBox = new TextBox();
            buttonAddProducts = new Button();
            customerIDTextBox = new TextBox();
            totalPriceLabel = new Label();
            productLineDataView = new DataGridView();
            CreateOrderButton = new Button();
            orderLabel = new Label();
            orderIDLabel = new Label();
            shippingLabel = new Label();
            shippingComboBox = new ComboBox();
            productLineIDBox = new TextBox();
            productLineIDBlabel = new Label();
            label3 = new Label();
            newQuantityBox = new TextBox();
            updateProductLineButton = new Button();
            editProductLineButton = new Button();
            ((System.ComponentModel.ISupportInitialize)productLineDataView).BeginInit();
            SuspendLayout();
            // 
            // buttonReturn
            // 
            buttonReturn.Location = new Point(12, 305);
            buttonReturn.Margin = new Padding(3, 2, 3, 2);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(138, 22);
            buttonReturn.TabIndex = 26;
            buttonReturn.Text = "Tilbage til oversigt";
            buttonReturn.UseVisualStyleBackColor = true;
            buttonReturn.Click += buttonReturn_Click;
            // 
            // buttonFinish
            // 
            buttonFinish.Location = new Point(156, 305);
            buttonFinish.Margin = new Padding(3, 2, 3, 2);
            buttonFinish.Name = "buttonFinish";
            buttonFinish.Size = new Size(108, 22);
            buttonFinish.TabIndex = 25;
            buttonFinish.Text = "Færdig";
            buttonFinish.UseVisualStyleBackColor = true;
            buttonFinish.Click += buttonFinish_Click;
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
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(385, 82);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 28;
            label2.Text = "Produkter:";
            // 
            // kundeOrderLabel
            // 
            kundeOrderLabel.AutoSize = true;
            kundeOrderLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kundeOrderLabel.Location = new Point(12, 83);
            kundeOrderLabel.Name = "kundeOrderLabel";
            kundeOrderLabel.Size = new Size(76, 21);
            kundeOrderLabel.TabIndex = 29;
            kundeOrderLabel.Text = "Kunde ID:";
            // 
            // totalPriceTextBox
            // 
            totalPriceTextBox.BorderStyle = BorderStyle.FixedSingle;
            totalPriceTextBox.Location = new Point(12, 154);
            totalPriceTextBox.Margin = new Padding(3, 2, 3, 2);
            totalPriceTextBox.Name = "totalPriceTextBox";
            totalPriceTextBox.Size = new Size(167, 23);
            totalPriceTextBox.TabIndex = 30;
            // 
            // buttonAddProducts
            // 
            buttonAddProducts.Location = new Point(666, 78);
            buttonAddProducts.Margin = new Padding(3, 2, 3, 2);
            buttonAddProducts.Name = "buttonAddProducts";
            buttonAddProducts.Size = new Size(116, 23);
            buttonAddProducts.TabIndex = 31;
            buttonAddProducts.Text = "Tilføj produkt";
            buttonAddProducts.UseVisualStyleBackColor = true;
            buttonAddProducts.Click += buttonAddProducts_Click;
            // 
            // customerIDTextBox
            // 
            customerIDTextBox.BorderStyle = BorderStyle.FixedSingle;
            customerIDTextBox.Location = new Point(12, 106);
            customerIDTextBox.Margin = new Padding(3, 2, 3, 2);
            customerIDTextBox.Name = "customerIDTextBox";
            customerIDTextBox.Size = new Size(167, 23);
            customerIDTextBox.TabIndex = 32;
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalPriceLabel.Location = new Point(12, 131);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(91, 21);
            totalPriceLabel.TabIndex = 33;
            totalPriceLabel.Text = "Samlet Pris:";
            // 
            // productLineDataView
            // 
            productLineDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productLineDataView.Location = new Point(385, 106);
            productLineDataView.Name = "productLineDataView";
            productLineDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productLineDataView.Size = new Size(397, 150);
            productLineDataView.TabIndex = 34;
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.Location = new Point(185, 106);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(120, 23);
            CreateOrderButton.TabIndex = 35;
            CreateOrderButton.Text = "Opret Ordre";
            CreateOrderButton.UseVisualStyleBackColor = true;
            CreateOrderButton.Click += CreateOrderButton_Click;
            // 
            // orderLabel
            // 
            orderLabel.AutoSize = true;
            orderLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderLabel.Location = new Point(189, 132);
            orderLabel.Name = "orderLabel";
            orderLabel.Size = new Size(96, 17);
            orderLabel.TabIndex = 36;
            orderLabel.Text = "Created Order:";
            orderLabel.Visible = false;
            // 
            // orderIDLabel
            // 
            orderIDLabel.AutoSize = true;
            orderIDLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderIDLabel.Location = new Point(291, 132);
            orderIDLabel.Name = "orderIDLabel";
            orderIDLabel.Size = new Size(26, 17);
            orderIDLabel.TabIndex = 37;
            orderIDLabel.Text = "???";
            orderIDLabel.Visible = false;
            // 
            // shippingLabel
            // 
            shippingLabel.AutoSize = true;
            shippingLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            shippingLabel.Location = new Point(12, 179);
            shippingLabel.Name = "shippingLabel";
            shippingLabel.Size = new Size(49, 21);
            shippingLabel.TabIndex = 38;
            shippingLabel.Text = "Fragt:";
            // 
            // shippingComboBox
            // 
            shippingComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            shippingComboBox.FormattingEnabled = true;
            shippingComboBox.Items.AddRange(new object[] { "Pickup Point", "PNDK", "DAO", "BRING", "GLS", "DHL" });
            shippingComboBox.Location = new Point(12, 203);
            shippingComboBox.Name = "shippingComboBox";
            shippingComboBox.Size = new Size(167, 23);
            shippingComboBox.TabIndex = 39;
            // 
            // productLineIDBox
            // 
            productLineIDBox.Location = new Point(385, 283);
            productLineIDBox.Name = "productLineIDBox";
            productLineIDBox.Size = new Size(65, 23);
            productLineIDBox.TabIndex = 40;
            // 
            // productLineIDBlabel
            // 
            productLineIDBlabel.AutoSize = true;
            productLineIDBlabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productLineIDBlabel.Location = new Point(385, 259);
            productLineIDBlabel.Name = "productLineIDBlabel";
            productLineIDBlabel.Size = new Size(65, 21);
            productLineIDBlabel.TabIndex = 29;
            productLineIDBlabel.Text = "Linje ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(456, 259);
            label3.Name = "label3";
            label3.Size = new Size(99, 21);
            label3.TabIndex = 29;
            label3.Text = "Ny mængde:";
            // 
            // newQuantityBox
            // 
            newQuantityBox.Location = new Point(456, 283);
            newQuantityBox.Name = "newQuantityBox";
            newQuantityBox.Size = new Size(110, 23);
            newQuantityBox.TabIndex = 40;
            // 
            // updateProductLineButton
            // 
            updateProductLineButton.Location = new Point(572, 282);
            updateProductLineButton.Name = "updateProductLineButton";
            updateProductLineButton.Size = new Size(116, 23);
            updateProductLineButton.TabIndex = 41;
            updateProductLineButton.Text = "Opdater Linje";
            updateProductLineButton.UseVisualStyleBackColor = true;
            updateProductLineButton.Click += updateProductLineButton_Click;
            // 
            // editProductLineButton
            // 
            editProductLineButton.Location = new Point(544, 77);
            editProductLineButton.Name = "editProductLineButton";
            editProductLineButton.Size = new Size(116, 23);
            editProductLineButton.TabIndex = 42;
            editProductLineButton.Text = "Rediger Linje";
            editProductLineButton.UseVisualStyleBackColor = true;
            editProductLineButton.Click += editProductLineButton_Click;
            // 
            // AddSalesOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(794, 338);
            Controls.Add(editProductLineButton);
            Controls.Add(updateProductLineButton);
            Controls.Add(newQuantityBox);
            Controls.Add(productLineIDBox);
            Controls.Add(shippingComboBox);
            Controls.Add(shippingLabel);
            Controls.Add(orderIDLabel);
            Controls.Add(orderLabel);
            Controls.Add(CreateOrderButton);
            Controls.Add(productLineDataView);
            Controls.Add(totalPriceLabel);
            Controls.Add(customerIDTextBox);
            Controls.Add(buttonAddProducts);
            Controls.Add(totalPriceTextBox);
            Controls.Add(label3);
            Controls.Add(productLineIDBlabel);
            Controls.Add(kundeOrderLabel);
            Controls.Add(label2);
            Controls.Add(buttonReturn);
            Controls.Add(buttonFinish);
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
        private Button buttonFinish;
        private Label label1;
        private Label label2;
        private Label kundeOrderLabel;
        private TextBox totalPriceTextBox;
        private Button buttonAddProducts;
        private TextBox customerIDTextBox;
        private Label totalPriceLabel;
        internal DataGridView productLineDataView;
        private Button CreateOrderButton;
        private Label orderLabel;
        private Label shippingLabel;
        private ComboBox shippingComboBox;
        internal Label orderIDLabel;
        private TextBox productLineIDBox;
        private Label productLineIDBlabel;
        private Label label3;
        private TextBox newQuantityBox;
        private Button updateProductLineButton;
        private Button editProductLineButton;
    }
}