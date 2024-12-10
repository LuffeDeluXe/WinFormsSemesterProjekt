namespace WinFormsSemesterProjekt.GUI
{
    partial class EditProductionOrder
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
            textBoxAmount = new TextBox();
            label3 = new Label();
            label2 = new Label();
            listBoxProducts = new ListBox();
            buttonReturn = new Button();
            buttonUpdate = new Button();
            label1 = new Label();
            label5 = new Label();
            textBoxOrderNumber = new TextBox();
            SuspendLayout();
            // 
            // textBoxAmount
            // 
            textBoxAmount.BorderStyle = BorderStyle.FixedSingle;
            textBoxAmount.Location = new Point(304, 342);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(236, 27);
            textBoxAmount.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(251, 342);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 44;
            label3.Text = "Antal:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 124);
            label2.Name = "label2";
            label2.Size = new Size(196, 20);
            label2.TabIndex = 43;
            label2.Text = "Produkt der skal produceres:";
            // 
            // listBoxProducts
            // 
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.Location = new Point(304, 124);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(236, 184);
            listBoxProducts.TabIndex = 42;
            // 
            // buttonReturn
            // 
            buttonReturn.Location = new Point(20, 409);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(158, 29);
            buttonReturn.TabIndex = 41;
            buttonReturn.Text = "Tilbage til oversigt";
            buttonReturn.UseVisualStyleBackColor = true;
            buttonReturn.Click += buttonReturn_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(344, 409);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(162, 29);
            buttonUpdate.TabIndex = 40;
            buttonUpdate.Text = "Opdater ordre";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(140, 9);
            label1.Name = "label1";
            label1.Size = new Size(557, 59);
            label1.TabIndex = 39;
            label1.Text = "Rediger produktionsordre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(232, 93);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 47;
            label5.Text = "Ordrenr.:";
            // 
            // textBoxOrderNumber
            // 
            textBoxOrderNumber.BorderStyle = BorderStyle.FixedSingle;
            textBoxOrderNumber.Location = new Point(304, 91);
            textBoxOrderNumber.Name = "textBoxOrderNumber";
            textBoxOrderNumber.ReadOnly = true;
            textBoxOrderNumber.Size = new Size(125, 27);
            textBoxOrderNumber.TabIndex = 46;
            // 
            // EditProductionOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(textBoxOrderNumber);
            Controls.Add(textBoxAmount);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBoxProducts);
            Controls.Add(buttonReturn);
            Controls.Add(buttonUpdate);
            Controls.Add(label1);
            Name = "EditProductionOrder";
            Text = "EditProductionOrder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAmount;
        private Label label3;
        private Label label2;
        private ListBox listBoxProducts;
        private Button buttonReturn;
        private Button buttonUpdate;
        private Label label1;
        private Label label5;
        private TextBox textBoxOrderNumber;
    }
}