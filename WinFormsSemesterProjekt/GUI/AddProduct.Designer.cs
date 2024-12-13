namespace WinFormsSemesterProjekt.GUI
{
    partial class AddProduct
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
            textBoxName = new TextBox();
            textBoxCategory = new TextBox();
            textBoxPrice = new TextBox();
            textBoxQuantity = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            richTextBoxDescription = new RichTextBox();
            label6 = new Label();
            buttonAdd = new Button();
            buttonReturn = new Button();
            textBoxMinStock = new TextBox();
            textBoxMaxStock = new TextBox();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(233, 9);
            label1.Name = "label1";
            label1.Size = new Size(324, 59);
            label1.TabIndex = 0;
            label1.Text = "Opret produkt";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(194, 116);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(233, 27);
            textBoxName.TabIndex = 1;
            textBoxName.KeyPress += textBoxName_KeyPress;
            // 
            // textBoxCategory
            // 
            textBoxCategory.Location = new Point(194, 159);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.Size = new Size(233, 27);
            textBoxCategory.TabIndex = 2;
            textBoxCategory.KeyPress += textBoxCategory_KeyPress;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(351, 203);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(76, 27);
            textBoxPrice.TabIndex = 4;
            textBoxPrice.KeyPress += textBoxPrice_KeyPress;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Location = new Point(194, 203);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(76, 27);
            textBoxQuantity.TabIndex = 5;
            textBoxQuantity.KeyPress += textBoxQuantity_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 119);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 6;
            label2.Text = "Produktnavn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 163);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 7;
            label3.Text = "Kategori:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(141, 205);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 8;
            label4.Text = "Antal:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(310, 205);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 9;
            label5.Text = "Pris:";
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Location = new Point(194, 253);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(233, 78);
            richTextBoxDescription.TabIndex = 10;
            richTextBoxDescription.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(105, 253);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 11;
            label6.Text = "Beskrivelse:";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(322, 409);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(154, 29);
            buttonAdd.TabIndex = 12;
            buttonAdd.Text = "Opret produkt";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonReturn
            // 
            buttonReturn.Location = new Point(11, 409);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(158, 29);
            buttonReturn.TabIndex = 13;
            buttonReturn.Text = "Tilbage til oversigt";
            buttonReturn.UseVisualStyleBackColor = true;
            buttonReturn.Click += buttonReturn_Click;
            // 
            // textBoxMinStock
            // 
            textBoxMinStock.Location = new Point(541, 182);
            textBoxMinStock.Name = "textBoxMinStock";
            textBoxMinStock.Size = new Size(76, 27);
            textBoxMinStock.TabIndex = 14;
            // 
            // textBoxMaxStock
            // 
            textBoxMaxStock.Location = new Point(541, 255);
            textBoxMaxStock.Name = "textBoxMaxStock";
            textBoxMaxStock.Size = new Size(76, 27);
            textBoxMaxStock.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(494, 159);
            label7.Name = "label7";
            label7.Size = new Size(189, 20);
            label7.TabIndex = 16;
            label7.Text = "Minimum lagerbeholdning:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(494, 232);
            label8.Name = "label8";
            label8.Size = new Size(189, 20);
            label8.TabIndex = 17;
            label8.Text = "Maksimal lagerbeholdning:";
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(800, 451);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBoxMaxStock);
            Controls.Add(textBoxMinStock);
            Controls.Add(buttonReturn);
            Controls.Add(buttonAdd);
            Controls.Add(label6);
            Controls.Add(richTextBoxDescription);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxQuantity);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxCategory);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Name = "AddProduct";
            Text = "AddProduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxName;
        private TextBox textBoxCategory;
        private TextBox textBoxPrice;
        private TextBox textBoxQuantity;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RichTextBox richTextBoxDescription;
        private Label label6;
        private Button buttonAdd;
        private Button buttonReturn;
        private TextBox textBoxMinStock;
        private TextBox textBoxMaxStock;
        private Label label7;
        private Label label8;
    }
}