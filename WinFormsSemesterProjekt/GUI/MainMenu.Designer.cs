namespace WinFormsSemesterProjekt
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
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
            label1.Font = new Font("Trebuchet MS", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(166, 24);
            label1.Name = "label1";
            label1.Size = new Size(329, 61);
            label1.TabIndex = 0;
            label1.Text = "ProductionPro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(225, 81);
            label2.Name = "label2";
            label2.Size = new Size(216, 35);
            label2.TabIndex = 1;
            label2.Text = "Lagerhåndtering";
            // 
            // buttonProducts
            // 
            buttonProducts.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonProducts.Location = new Point(166, 140);
            buttonProducts.Margin = new Padding(3, 2, 3, 2);
            buttonProducts.Name = "buttonProducts";
            buttonProducts.Size = new Size(354, 50);
            buttonProducts.TabIndex = 2;
            buttonProducts.Text = "Produkter";
            buttonProducts.UseVisualStyleBackColor = true;
            buttonProducts.Click += buttonProducts_Click;
            // 
            // buttonOrders
            // 
            buttonOrders.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonOrders.Location = new Point(166, 194);
            buttonOrders.Margin = new Padding(3, 2, 3, 2);
            buttonOrders.Name = "buttonOrders";
            buttonOrders.Size = new Size(354, 50);
            buttonOrders.TabIndex = 3;
            buttonOrders.Text = "Ordrer";
            buttonOrders.UseVisualStyleBackColor = true;
            buttonOrders.Click += buttonOrders_Click;
            // 
            // buttonCustomers
            // 
            buttonCustomers.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCustomers.Location = new Point(166, 248);
            buttonCustomers.Margin = new Padding(3, 2, 3, 2);
            buttonCustomers.Name = "buttonCustomers";
            buttonCustomers.Size = new Size(354, 50);
            buttonCustomers.TabIndex = 4;
            buttonCustomers.Text = "Kunder";
            buttonCustomers.UseVisualStyleBackColor = true;
            buttonCustomers.Click += buttonCustomers_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(700, 338);
            Controls.Add(buttonCustomers);
            Controls.Add(buttonOrders);
            Controls.Add(buttonProducts);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainMenu";
            Text = "Hovedmenu";
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
