namespace WinFormsSemesterProjekt.GUI
{
    partial class ShowProductDetails
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
            buttonReturn.Location = new Point(16, 409);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(158, 29);
            buttonReturn.TabIndex = 39;
            buttonReturn.Text = "Tilbage til oversigt";
            buttonReturn.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(327, 409);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(154, 29);
            buttonEdit.TabIndex = 38;
            buttonEdit.Text = "Ændr oplysninger";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(202, 253);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 37;
            label6.Text = "Beskrivelse:";
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Location = new Point(291, 253);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(233, 97);
            richTextBoxDescription.TabIndex = 36;
            richTextBoxDescription.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(407, 205);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 35;
            label5.Text = "Pris:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(238, 205);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 34;
            label4.Text = "Antal:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(216, 163);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 33;
            label3.Text = "Kategori:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 119);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 32;
            label2.Text = "Produktnavn:";
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Location = new Point(291, 203);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(76, 27);
            textBoxQuantity.TabIndex = 31;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(448, 203);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(76, 27);
            textBoxPrice.TabIndex = 30;
            // 
            // textBoxCategory
            // 
            textBoxCategory.Location = new Point(291, 159);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.Size = new Size(233, 27);
            textBoxCategory.TabIndex = 29;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(291, 116);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(233, 27);
            textBoxName.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(224, 9);
            label1.Name = "label1";
            label1.Size = new Size(358, 59);
            label1.TabIndex = 27;
            label1.Text = "Produktdetaljer";
            // 
            // ShowProductDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(800, 450);
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
            Name = "ShowProductDetails";
            Text = "ShowProductDetails";
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