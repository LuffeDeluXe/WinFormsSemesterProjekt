namespace WinFormsSemesterProjekt.GUI
{
    partial class AddProductionOrder
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
            buttonAdd = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxAmount
            // 
            textBoxAmount.BorderStyle = BorderStyle.FixedSingle;
            textBoxAmount.Location = new Point(306, 342);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(236, 27);
            textBoxAmount.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(253, 342);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 37;
            label3.Text = "Antal:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 124);
            label2.Name = "label2";
            label2.Size = new Size(196, 20);
            label2.TabIndex = 36;
            label2.Text = "Produkt der skal produceres:";
            // 
            // listBoxProducts
            // 
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.Location = new Point(306, 124);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(236, 184);
            listBoxProducts.TabIndex = 35;
            // 
            // buttonReturn
            // 
            buttonReturn.Location = new Point(22, 409);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(158, 29);
            buttonReturn.TabIndex = 34;
            buttonReturn.Text = "Tilbage til oversigt";
            buttonReturn.UseVisualStyleBackColor = true;
            buttonReturn.Click += buttonReturn_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(346, 409);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(162, 29);
            buttonAdd.TabIndex = 33;
            buttonAdd.Text = "Send til produktion";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(150, 9);
            label1.Name = "label1";
            label1.Size = new Size(520, 59);
            label1.TabIndex = 32;
            label1.Text = "Opret produktionsordre";
            // 
            // AddProductionOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxAmount);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBoxProducts);
            Controls.Add(buttonReturn);
            Controls.Add(buttonAdd);
            Controls.Add(label1);
            Name = "AddProductionOrder";
            Text = "AddProductionOrder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddProducts;
        private TextBox textBoxAmount;
        private Label label3;
        private Label label2;
        private ListBox listBoxProducts;
        private Button buttonReturn;
        private Button buttonAdd;
        private Label label1;
    }
}