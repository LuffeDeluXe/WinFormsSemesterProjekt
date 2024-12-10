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
            label4 = new Label();
            textBox1 = new TextBox();
            buttonAddProducts = new Button();
            textBoxCustomerPhoneNumber = new TextBox();
            label3 = new Label();
            label2 = new Label();
            listBoxProducts = new ListBox();
            buttonReturn = new Button();
            buttonUpdate = new Button();
            label1 = new Label();
            textBoxOrderNumber = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(248, 236);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 43;
            label4.Text = "Antal:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(301, 234);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 27);
            textBox1.TabIndex = 42;
            // 
            // buttonAddProducts
            // 
            buttonAddProducts.Location = new Point(543, 199);
            buttonAddProducts.Name = "buttonAddProducts";
            buttonAddProducts.Size = new Size(132, 29);
            buttonAddProducts.TabIndex = 41;
            buttonAddProducts.Text = "Tilføj produkter";
            buttonAddProducts.UseVisualStyleBackColor = true;
            // 
            // textBoxCustomerPhoneNumber
            // 
            textBoxCustomerPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            textBoxCustomerPhoneNumber.Location = new Point(301, 270);
            textBoxCustomerPhoneNumber.Name = "textBoxCustomerPhoneNumber";
            textBoxCustomerPhoneNumber.Size = new Size(236, 27);
            textBoxCustomerPhoneNumber.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 272);
            label3.Name = "label3";
            label3.Size = new Size(174, 20);
            label3.TabIndex = 39;
            label3.Text = "Kundens telefonnummer:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 124);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 38;
            label2.Text = "Produkter:";
            // 
            // listBoxProducts
            // 
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.Location = new Point(301, 124);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(236, 104);
            listBoxProducts.TabIndex = 37;
            // 
            // buttonReturn
            // 
            buttonReturn.Location = new Point(17, 409);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(158, 29);
            buttonReturn.TabIndex = 36;
            buttonReturn.Text = "Tilbage til oversigt";
            buttonReturn.UseVisualStyleBackColor = true;
            buttonReturn.Click += buttonReturn_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(364, 409);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(93, 29);
            buttonUpdate.TabIndex = 35;
            buttonUpdate.Text = "Opdater";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(202, 9);
            label1.Name = "label1";
            label1.Size = new Size(411, 59);
            label1.TabIndex = 34;
            label1.Text = "Rediger salgsordre";
            // 
            // textBoxOrderNumber
            // 
            textBoxOrderNumber.BorderStyle = BorderStyle.FixedSingle;
            textBoxOrderNumber.Location = new Point(301, 92);
            textBoxOrderNumber.Name = "textBoxOrderNumber";
            textBoxOrderNumber.ReadOnly = true;
            textBoxOrderNumber.Size = new Size(125, 27);
            textBoxOrderNumber.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(229, 94);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 45;
            label5.Text = "Ordrenr.:";
            // 
            // EditSalesOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(textBoxOrderNumber);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(buttonAddProducts);
            Controls.Add(textBoxCustomerPhoneNumber);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBoxProducts);
            Controls.Add(buttonReturn);
            Controls.Add(buttonUpdate);
            Controls.Add(label1);
            Name = "EditSalesOrder";
            Text = "EditSalesOrder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox textBox1;
        private Button buttonAddProducts;
        private TextBox textBoxCustomerPhoneNumber;
        private Label label3;
        private Label label2;
        private ListBox listBoxProducts;
        private Button buttonReturn;
        private Button buttonUpdate;
        private Label label1;
        private TextBox textBoxOrderNumber;
        private Label label5;
    }
}