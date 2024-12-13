namespace WinFormsSemesterProjekt.GUI
{
    partial class EditProduct
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
            buttonEdit = new Button();
            label1 = new Label();
            label8 = new Label();
            label7 = new Label();
            textBoxMaxStock = new TextBox();
            textBoxMinStock = new TextBox();
            label6 = new Label();
            richTextBoxDescription = new RichTextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxQuantity = new TextBox();
            textBoxPrice = new TextBox();
            textBoxCategory = new TextBox();
            textBoxName = new TextBox();
            SuspendLayout();
            // 
            // buttonReturn
            // 
            buttonReturn.Location = new Point(11, 409);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(158, 29);
            buttonReturn.TabIndex = 26;
            buttonReturn.Text = "Tilbage til oversigt";
            buttonReturn.UseVisualStyleBackColor = true;
            buttonReturn.Click += buttonReturn_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(322, 409);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(154, 29);
            buttonEdit.TabIndex = 25;
            buttonEdit.Text = "Ændr oplysninger";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(219, 9);
            label1.Name = "label1";
            label1.Size = new Size(361, 59);
            label1.TabIndex = 14;
            label1.Text = "Rediger produkt";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(506, 234);
            label8.Name = "label8";
            label8.Size = new Size(189, 20);
            label8.TabIndex = 40;
            label8.Text = "Maksimal lagerbeholdning:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(506, 161);
            label7.Name = "label7";
            label7.Size = new Size(189, 20);
            label7.TabIndex = 39;
            label7.Text = "Minimum lagerbeholdning:";
            // 
            // textBoxMaxStock
            // 
            textBoxMaxStock.Location = new Point(553, 257);
            textBoxMaxStock.Name = "textBoxMaxStock";
            textBoxMaxStock.Size = new Size(76, 27);
            textBoxMaxStock.TabIndex = 38;
            // 
            // textBoxMinStock
            // 
            textBoxMinStock.Location = new Point(553, 184);
            textBoxMinStock.Name = "textBoxMinStock";
            textBoxMinStock.Size = new Size(76, 27);
            textBoxMinStock.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(117, 255);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 36;
            label6.Text = "Beskrivelse:";
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Location = new Point(206, 255);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(233, 78);
            richTextBoxDescription.TabIndex = 35;
            richTextBoxDescription.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(322, 207);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 34;
            label5.Text = "Pris:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(153, 207);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 33;
            label4.Text = "Antal:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(131, 165);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 32;
            label3.Text = "Kategori:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 121);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 31;
            label2.Text = "Produktnavn:";
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Location = new Point(206, 205);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(76, 27);
            textBoxQuantity.TabIndex = 30;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(363, 205);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(76, 27);
            textBoxPrice.TabIndex = 29;
            // 
            // textBoxCategory
            // 
            textBoxCategory.Location = new Point(206, 161);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.Size = new Size(233, 27);
            textBoxCategory.TabIndex = 28;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(206, 118);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(233, 27);
            textBoxName.TabIndex = 27;
            // 
            // EditProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(800, 451);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBoxMaxStock);
            Controls.Add(textBoxMinStock);
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
            Controls.Add(buttonReturn);
            Controls.Add(buttonEdit);
            Controls.Add(label1);
            Name = "EditProduct";
            Text = "EditProduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonReturn;
        private Button buttonEdit;
        private Label label1;
        private Label label8;
        private Label label7;
        private TextBox textBoxMaxStock;
        private TextBox textBoxMinStock;
        private Label label6;
        private RichTextBox richTextBoxDescription;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBoxQuantity;
        private TextBox textBoxPrice;
        private TextBox textBoxCategory;
        private TextBox textBoxName;
    }
}