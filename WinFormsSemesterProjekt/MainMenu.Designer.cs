namespace WinFormsSemesterProjekt
{
    partial class MainMenu
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
            label2 = new Label();
            buttonProducts = new Button();
            buttonOrders = new Button();
            buttonCustomers = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(136, 9);
            label1.Name = "label1";
            label1.Size = new Size(543, 100);
            label1.TabIndex = 0;
            label1.Text = "ProductionPro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(248, 100);
            label2.Name = "label2";
            label2.Size = new Size(315, 49);
            label2.TabIndex = 1;
            label2.Text = "Lagerhåndtering";
            // 
            // buttonProducts
            // 
            buttonProducts.Location = new Point(248, 209);
            buttonProducts.Name = "buttonProducts";
            buttonProducts.Size = new Size(315, 61);
            buttonProducts.TabIndex = 2;
            buttonProducts.Text = "Produkter";
            buttonProducts.UseVisualStyleBackColor = true;
            // 
            // buttonOrders
            // 
            buttonOrders.Location = new Point(248, 276);
            buttonOrders.Name = "buttonOrders";
            buttonOrders.Size = new Size(315, 61);
            buttonOrders.TabIndex = 3;
            buttonOrders.Text = "Ordrer";
            buttonOrders.UseVisualStyleBackColor = true;
            // 
            // buttonCustomers
            // 
            buttonCustomers.Location = new Point(248, 343);
            buttonCustomers.Name = "buttonCustomers";
            buttonCustomers.Size = new Size(315, 61);
            buttonCustomers.TabIndex = 4;
            buttonCustomers.Text = "Kunder";
            buttonCustomers.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCustomers);
            Controls.Add(buttonOrders);
            Controls.Add(buttonProducts);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainMenu";
            Text = "MainMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttonProducts;
        private Button buttonOrders;
        private Button buttonCustomers;
    }
}