﻿namespace WinFormsSemesterProjekt.GUI
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
			label1 = new Label();
			SuspendLayout();
			// 
			// buttonReturn
			// 
			buttonReturn.Location = new Point(10, 307);
			buttonReturn.Margin = new Padding(3, 2, 3, 2);
			buttonReturn.Name = "buttonReturn";
			buttonReturn.Size = new Size(138, 22);
			buttonReturn.TabIndex = 26;
			buttonReturn.Text = "Tilbage til oversigt";
			buttonReturn.UseVisualStyleBackColor = true;
			buttonReturn.Click += buttonReturn_Click;
			// 
			// buttonEdit
			// 
			buttonEdit.Location = new Point(282, 307);
			buttonEdit.Margin = new Padding(3, 2, 3, 2);
			buttonEdit.Name = "buttonEdit";
			buttonEdit.Size = new Size(135, 22);
			buttonEdit.TabIndex = 25;
			buttonEdit.Text = "Ændr oplysninger";
			buttonEdit.UseVisualStyleBackColor = true;
			buttonEdit.Click += buttonEdit_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(172, 190);
			label6.Name = "label6";
			label6.Size = new Size(67, 15);
			label6.TabIndex = 24;
			label6.Text = "Beskrivelse:";
			// 
			// richTextBoxDescription
			// 
			richTextBoxDescription.Location = new Point(250, 190);
			richTextBoxDescription.Margin = new Padding(3, 2, 3, 2);
			richTextBoxDescription.Name = "richTextBoxDescription";
			richTextBoxDescription.Size = new Size(204, 74);
			richTextBoxDescription.TabIndex = 23;
			richTextBoxDescription.Text = "";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(352, 154);
			label5.Name = "label5";
			label5.Size = new Size(29, 15);
			label5.TabIndex = 22;
			label5.Text = "Pris:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(204, 154);
			label4.Name = "label4";
			label4.Size = new Size(38, 15);
			label4.TabIndex = 21;
			label4.Text = "Antal:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(185, 122);
			label3.Name = "label3";
			label3.Size = new Size(54, 15);
			label3.TabIndex = 20;
			label3.Text = "Kategori:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(163, 89);
			label2.Name = "label2";
			label2.Size = new Size(78, 15);
			label2.TabIndex = 19;
			label2.Text = "Produktnavn:";
			// 
			// textBoxQuantity
			// 
			textBoxQuantity.Location = new Point(250, 152);
			textBoxQuantity.Margin = new Padding(3, 2, 3, 2);
			textBoxQuantity.Name = "textBoxQuantity";
			textBoxQuantity.Size = new Size(67, 23);
			textBoxQuantity.TabIndex = 18;
			textBoxQuantity.KeyPress += textBoxQuantity_KeyPress;
			// 
			// textBoxPrice
			// 
			textBoxPrice.Location = new Point(388, 152);
			textBoxPrice.Margin = new Padding(3, 2, 3, 2);
			textBoxPrice.Name = "textBoxPrice";
			textBoxPrice.Size = new Size(67, 23);
			textBoxPrice.TabIndex = 17;
			textBoxPrice.KeyPress += textBoxPrice_KeyPress;
			// 
			// textBoxCategory
			// 
			textBoxCategory.Location = new Point(250, 119);
			textBoxCategory.Margin = new Padding(3, 2, 3, 2);
			textBoxCategory.Name = "textBoxCategory";
			textBoxCategory.Size = new Size(204, 23);
			textBoxCategory.TabIndex = 16;
			textBoxCategory.KeyPress += textBoxCategory_KeyPress;
			// 
			// textBoxName
			// 
			textBoxName.Location = new Point(250, 87);
			textBoxName.Margin = new Padding(3, 2, 3, 2);
			textBoxName.Name = "textBoxName";
			textBoxName.Size = new Size(204, 23);
			textBoxName.TabIndex = 15;
			textBoxName.KeyPress += textBoxName_KeyPress;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Trebuchet MS", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(192, 7);
			label1.Name = "label1";
			label1.Size = new Size(293, 49);
			label1.TabIndex = 14;
			label1.Text = "Rediger produkt";
			// 
			// EditProduct
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.LightGoldenrodYellow;
			ClientSize = new Size(700, 338);
			Controls.Add(buttonReturn);
			Controls.Add(buttonEdit);
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
			Name = "EditProduct";
			Text = "EditProduct";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button buttonReturn;
        private Button buttonEdit;
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
        private Label label1;
    }
}