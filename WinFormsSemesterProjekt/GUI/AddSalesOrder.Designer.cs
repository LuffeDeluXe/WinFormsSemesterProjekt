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
            listBoxProducts = new ListBox();
            label2 = new Label();
            label3 = new Label();
            textBoxCustomerPhoneNumber = new TextBox();
            buttonAddProducts = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
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
            buttonAdd.Text = "Sælg";
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
            // listBoxProducts
            // 
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.ItemHeight = 15;
            listBoxProducts.Location = new Point(268, 93);
            listBoxProducts.Margin = new Padding(3, 2, 3, 2);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(207, 79);
            listBoxProducts.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 93);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 28;
            label2.Text = "Produkter:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 204);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 29;
            label3.Text = "Kunde ID:";
            // 
            // textBoxCustomerPhoneNumber
            // 
            textBoxCustomerPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            textBoxCustomerPhoneNumber.Location = new Point(268, 202);
            textBoxCustomerPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            textBoxCustomerPhoneNumber.Name = "textBoxCustomerPhoneNumber";
            textBoxCustomerPhoneNumber.Size = new Size(207, 23);
            textBoxCustomerPhoneNumber.TabIndex = 30;
            // 
            // buttonAddProducts
            // 
            buttonAddProducts.Location = new Point(480, 149);
            buttonAddProducts.Margin = new Padding(3, 2, 3, 2);
            buttonAddProducts.Name = "buttonAddProducts";
            buttonAddProducts.Size = new Size(116, 22);
            buttonAddProducts.TabIndex = 31;
            buttonAddProducts.Text = "Tilføj produkter";
            buttonAddProducts.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(268, 176);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 23);
            textBox1.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(220, 178);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 33;
            label4.Text = "Antal:";
            // 
            // AddSalesOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(700, 338);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(buttonAddProducts);
            Controls.Add(textBoxCustomerPhoneNumber);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBoxProducts);
            Controls.Add(buttonReturn);
            Controls.Add(buttonAdd);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddSalesOrder";
            Text = "AddSalesOrder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonReturn;
        private Button buttonAdd;
        private Label label1;
        private ListBox listBoxProducts;
        private Label label2;
        private Label label3;
        private TextBox textBoxCustomerPhoneNumber;
        private Button buttonAddProducts;
        private TextBox textBox1;
        private Label label4;
    }
}