namespace WinFormsSemesterProjekt.GUI
{
    partial class EditSalesOrder
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
            buttonUpdate = new Button();
            label1 = new Label();
            editProductLineButton = new Button();
            updateProductLineButton = new Button();
            newQuantityBox = new TextBox();
            productLineIDBox = new TextBox();
            productLineDataView = new DataGridView();
            totalPriceLabel = new Label();
            buttonAddProducts = new Button();
            totalPriceTextBox = new TextBox();
            label3 = new Label();
            productLineIDBlabel = new Label();
            kundeOrderLabel = new Label();
            label2 = new Label();
            shippingLabel = new Label();
            shippingMethodLabel = new Label();
            customerIDLabel = new Label();
            deleteProductLineButton = new Button();
            ((System.ComponentModel.ISupportInitialize)productLineDataView).BeginInit();
            SuspendLayout();
            // 
            // buttonReturn
            // 
            buttonReturn.Location = new Point(12, 305);
            buttonReturn.Margin = new Padding(3, 2, 3, 2);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(138, 22);
            buttonReturn.TabIndex = 36;
            buttonReturn.Text = "Tilbage til oversigt";
            buttonReturn.UseVisualStyleBackColor = true;
            buttonReturn.Click += buttonReturn_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(156, 305);
            buttonUpdate.Margin = new Padding(3, 2, 3, 2);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(81, 22);
            buttonUpdate.TabIndex = 35;
            buttonUpdate.Text = "Opdater";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(177, 7);
            label1.Name = "label1";
            label1.Size = new Size(333, 49);
            label1.TabIndex = 34;
            label1.Text = "Rediger salgsordre";
            // 
            // editProductLineButton
            // 
            editProductLineButton.Location = new Point(494, 97);
            editProductLineButton.Name = "editProductLineButton";
            editProductLineButton.Size = new Size(97, 23);
            editProductLineButton.TabIndex = 55;
            editProductLineButton.Text = "Rediger Linje";
            editProductLineButton.UseVisualStyleBackColor = true;
            editProductLineButton.Click += editProductLineButton_Click;
            // 
            // updateProductLineButton
            // 
            updateProductLineButton.Location = new Point(484, 303);
            updateProductLineButton.Name = "updateProductLineButton";
            updateProductLineButton.Size = new Size(97, 23);
            updateProductLineButton.TabIndex = 54;
            updateProductLineButton.Text = "Opdater Linje";
            updateProductLineButton.UseVisualStyleBackColor = true;
            updateProductLineButton.Click += updateProductLineButton_Click;
            // 
            // newQuantityBox
            // 
            newQuantityBox.Location = new Point(368, 303);
            newQuantityBox.Name = "newQuantityBox";
            newQuantityBox.Size = new Size(110, 23);
            newQuantityBox.TabIndex = 52;
            // 
            // productLineIDBox
            // 
            productLineIDBox.Location = new Point(297, 303);
            productLineIDBox.Name = "productLineIDBox";
            productLineIDBox.Size = new Size(65, 23);
            productLineIDBox.TabIndex = 53;
            // 
            // productLineDataView
            // 
            productLineDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productLineDataView.Location = new Point(297, 126);
            productLineDataView.Name = "productLineDataView";
            productLineDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productLineDataView.Size = new Size(397, 150);
            productLineDataView.TabIndex = 51;
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalPriceLabel.Location = new Point(12, 180);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(91, 21);
            totalPriceLabel.TabIndex = 50;
            totalPriceLabel.Text = "Samlet Pris:";
            // 
            // buttonAddProducts
            // 
            buttonAddProducts.Location = new Point(597, 98);
            buttonAddProducts.Margin = new Padding(3, 2, 3, 2);
            buttonAddProducts.Name = "buttonAddProducts";
            buttonAddProducts.Size = new Size(97, 23);
            buttonAddProducts.TabIndex = 48;
            buttonAddProducts.Text = "Tilføj produkt";
            buttonAddProducts.UseVisualStyleBackColor = true;
            buttonAddProducts.Click += buttonAddProducts_Click;
            // 
            // totalPriceTextBox
            // 
            totalPriceTextBox.BorderStyle = BorderStyle.FixedSingle;
            totalPriceTextBox.Location = new Point(12, 203);
            totalPriceTextBox.Margin = new Padding(3, 2, 3, 2);
            totalPriceTextBox.Name = "totalPriceTextBox";
            totalPriceTextBox.Size = new Size(167, 23);
            totalPriceTextBox.TabIndex = 47;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(368, 279);
            label3.Name = "label3";
            label3.Size = new Size(99, 21);
            label3.TabIndex = 44;
            label3.Text = "Ny mængde:";
            // 
            // productLineIDBlabel
            // 
            productLineIDBlabel.AutoSize = true;
            productLineIDBlabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productLineIDBlabel.Location = new Point(297, 279);
            productLineIDBlabel.Name = "productLineIDBlabel";
            productLineIDBlabel.Size = new Size(65, 21);
            productLineIDBlabel.TabIndex = 45;
            productLineIDBlabel.Text = "Linje ID:";
            // 
            // kundeOrderLabel
            // 
            kundeOrderLabel.AutoSize = true;
            kundeOrderLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kundeOrderLabel.Location = new Point(12, 126);
            kundeOrderLabel.Name = "kundeOrderLabel";
            kundeOrderLabel.Size = new Size(76, 21);
            kundeOrderLabel.TabIndex = 46;
            kundeOrderLabel.Text = "Kunde ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(297, 102);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 43;
            label2.Text = "Produkter:";
            // 
            // shippingLabel
            // 
            shippingLabel.AutoSize = true;
            shippingLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            shippingLabel.Location = new Point(12, 147);
            shippingLabel.Name = "shippingLabel";
            shippingLabel.Size = new Size(49, 21);
            shippingLabel.TabIndex = 56;
            shippingLabel.Text = "Fragt:";
            // 
            // shippingMethodLabel
            // 
            shippingMethodLabel.AutoSize = true;
            shippingMethodLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            shippingMethodLabel.Location = new Point(67, 147);
            shippingMethodLabel.Name = "shippingMethodLabel";
            shippingMethodLabel.Size = new Size(31, 21);
            shippingMethodLabel.TabIndex = 56;
            shippingMethodLabel.Text = "???";
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerIDLabel.Location = new Point(94, 126);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new Size(31, 21);
            customerIDLabel.TabIndex = 56;
            customerIDLabel.Text = "???";
            // 
            // deleteProductLineButton
            // 
            deleteProductLineButton.Location = new Point(587, 302);
            deleteProductLineButton.Name = "deleteProductLineButton";
            deleteProductLineButton.Size = new Size(107, 25);
            deleteProductLineButton.TabIndex = 57;
            deleteProductLineButton.Text = "Slet Produktlinje";
            deleteProductLineButton.UseVisualStyleBackColor = true;
            deleteProductLineButton.Click += deleteProductLineButton_Click;
            // 
            // EditSalesOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(708, 338);
            Controls.Add(deleteProductLineButton);
            Controls.Add(customerIDLabel);
            Controls.Add(shippingMethodLabel);
            Controls.Add(shippingLabel);
            Controls.Add(editProductLineButton);
            Controls.Add(updateProductLineButton);
            Controls.Add(newQuantityBox);
            Controls.Add(productLineIDBox);
            Controls.Add(productLineDataView);
            Controls.Add(totalPriceLabel);
            Controls.Add(buttonAddProducts);
            Controls.Add(totalPriceTextBox);
            Controls.Add(label3);
            Controls.Add(productLineIDBlabel);
            Controls.Add(kundeOrderLabel);
            Controls.Add(label2);
            Controls.Add(buttonReturn);
            Controls.Add(buttonUpdate);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EditSalesOrder";
            Text = "EditSalesOrder";
            ((System.ComponentModel.ISupportInitialize)productLineDataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonReturn;
        private Button buttonUpdate;
        private Label label1;
        private Button editProductLineButton;
        private Button updateProductLineButton;
        private TextBox newQuantityBox;
        private TextBox productLineIDBox;
        internal DataGridView productLineDataView;
        private Label totalPriceLabel;
        private Button buttonAddProducts;
        private TextBox totalPriceTextBox;
        private Label label3;
        private Label productLineIDBlabel;
        private Label kundeOrderLabel;
        private Label label2;
        private Label shippingLabel;
        private Label shippingMethodLabel;
        private Label customerIDLabel;
        private Button deleteProductLineButton;
    }
}