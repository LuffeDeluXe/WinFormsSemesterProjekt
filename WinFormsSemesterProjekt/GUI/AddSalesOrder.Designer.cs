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
            buttonReturn.Location = new Point(22, 409);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(158, 29);
            buttonReturn.TabIndex = 26;
            buttonReturn.Text = "Tilbage til oversigt";
            buttonReturn.UseVisualStyleBackColor = true;
            buttonReturn.Click += buttonReturn_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(369, 409);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(93, 29);
            buttonAdd.TabIndex = 25;
            buttonAdd.Text = "Sælg";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(221, 9);
            label1.Name = "label1";
            label1.Size = new Size(374, 59);
            label1.TabIndex = 14;
            label1.Text = "Opret salgsordre";
            // 
            // listBoxProducts
            // 
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.Location = new Point(306, 124);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(236, 104);
            listBoxProducts.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 124);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 28;
            label2.Text = "Produkter:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 272);
            label3.Name = "label3";
            label3.Size = new Size(174, 20);
            label3.TabIndex = 29;
            label3.Text = "Kundens telefonnummer:";
            // 
            // textBoxCustomerPhoneNumber
            // 
            textBoxCustomerPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            textBoxCustomerPhoneNumber.Location = new Point(306, 270);
            textBoxCustomerPhoneNumber.Name = "textBoxCustomerPhoneNumber";
            textBoxCustomerPhoneNumber.Size = new Size(236, 27);
            textBoxCustomerPhoneNumber.TabIndex = 30;
            // 
            // buttonAddProducts
            // 
            buttonAddProducts.Location = new Point(548, 199);
            buttonAddProducts.Name = "buttonAddProducts";
            buttonAddProducts.Size = new Size(132, 29);
            buttonAddProducts.TabIndex = 31;
            buttonAddProducts.Text = "Tilføj produkter";
            buttonAddProducts.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(306, 234);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 27);
            textBox1.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(253, 236);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 33;
            label4.Text = "Antal:";
            // 
            // AddSalesOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(800, 450);
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