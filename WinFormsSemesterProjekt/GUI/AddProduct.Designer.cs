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
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Trebuchet MS", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(204, 7);
			label1.Name = "label1";
			label1.Size = new Size(263, 49);
			label1.TabIndex = 0;
			label1.Text = "Opret produkt";
			// 
			// textBoxName
			// 
			textBoxName.Location = new Point(250, 87);
			textBoxName.Margin = new Padding(3, 2, 3, 2);
			textBoxName.Name = "textBoxName";
			textBoxName.Size = new Size(204, 23);
			textBoxName.TabIndex = 1;
			// 
			// textBoxCategory
			// 
			textBoxCategory.Location = new Point(250, 119);
			textBoxCategory.Margin = new Padding(3, 2, 3, 2);
			textBoxCategory.Name = "textBoxCategory";
			textBoxCategory.Size = new Size(204, 23);
			textBoxCategory.TabIndex = 2;
			// 
			// textBoxPrice
			// 
			textBoxPrice.Location = new Point(388, 152);
			textBoxPrice.Margin = new Padding(3, 2, 3, 2);
			textBoxPrice.Name = "textBoxPrice";
			textBoxPrice.Size = new Size(67, 23);
			textBoxPrice.TabIndex = 4;
			textBoxPrice.KeyPress += textBoxPrice_KeyPress;
			// 
			// textBoxQuantity
			// 
			textBoxQuantity.Location = new Point(250, 152);
			textBoxQuantity.Margin = new Padding(3, 2, 3, 2);
			textBoxQuantity.Name = "textBoxQuantity";
			textBoxQuantity.Size = new Size(67, 23);
			textBoxQuantity.TabIndex = 5;
			textBoxQuantity.KeyPress += textBoxQuantity_KeyPress;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(163, 89);
			label2.Name = "label2";
			label2.Size = new Size(78, 15);
			label2.TabIndex = 6;
			label2.Text = "Produktnavn:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(185, 122);
			label3.Name = "label3";
			label3.Size = new Size(54, 15);
			label3.TabIndex = 7;
			label3.Text = "Kategori:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(204, 154);
			label4.Name = "label4";
			label4.Size = new Size(38, 15);
			label4.TabIndex = 8;
			label4.Text = "Antal:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(352, 154);
			label5.Name = "label5";
			label5.Size = new Size(29, 15);
			label5.TabIndex = 9;
			label5.Text = "Pris:";
			// 
			// richTextBoxDescription
			// 
			richTextBoxDescription.Location = new Point(250, 190);
			richTextBoxDescription.Margin = new Padding(3, 2, 3, 2);
			richTextBoxDescription.Name = "richTextBoxDescription";
			richTextBoxDescription.Size = new Size(204, 74);
			richTextBoxDescription.TabIndex = 10;
			richTextBoxDescription.Text = "";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(172, 190);
			label6.Name = "label6";
			label6.Size = new Size(67, 15);
			label6.TabIndex = 11;
			label6.Text = "Beskrivelse:";
			// 
			// buttonAdd
			// 
			buttonAdd.Location = new Point(282, 307);
			buttonAdd.Margin = new Padding(3, 2, 3, 2);
			buttonAdd.Name = "buttonAdd";
			buttonAdd.Size = new Size(135, 22);
			buttonAdd.TabIndex = 12;
			buttonAdd.Text = "Opret produkt";
			buttonAdd.UseVisualStyleBackColor = true;
			buttonAdd.Click += buttonAdd_Click;
			// 
			// buttonReturn
			// 
			buttonReturn.Location = new Point(10, 307);
			buttonReturn.Margin = new Padding(3, 2, 3, 2);
			buttonReturn.Name = "buttonReturn";
			buttonReturn.Size = new Size(138, 22);
			buttonReturn.TabIndex = 13;
			buttonReturn.Text = "Tilbage til oversigt";
			buttonReturn.UseVisualStyleBackColor = true;
			buttonReturn.Click += buttonReturn_Click;
			// 
			// AddProduct
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.LightGoldenrodYellow;
			ClientSize = new Size(700, 338);
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
			Margin = new Padding(3, 2, 3, 2);
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
    }
}