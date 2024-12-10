namespace WinFormsSemesterProjekt.GUI.PopUps
{
    partial class OrderTypeSelection
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
            buttonSalesOrder = new Button();
            buttonProductionOrder = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 31);
            label1.Name = "label1";
            label1.Size = new Size(222, 20);
            label1.TabIndex = 0;
            label1.Text = "Hvilken ordretype skal oprettes?";
            // 
            // buttonSalesOrder
            // 
            buttonSalesOrder.Location = new Point(35, 86);
            buttonSalesOrder.Name = "buttonSalesOrder";
            buttonSalesOrder.Size = new Size(94, 29);
            buttonSalesOrder.TabIndex = 1;
            buttonSalesOrder.Text = "Salgsordre";
            buttonSalesOrder.UseVisualStyleBackColor = true;
            buttonSalesOrder.Click += button1_Click;
            // 
            // buttonProductionOrder
            // 
            buttonProductionOrder.Location = new Point(163, 86);
            buttonProductionOrder.Name = "buttonProductionOrder";
            buttonProductionOrder.Size = new Size(94, 29);
            buttonProductionOrder.TabIndex = 2;
            buttonProductionOrder.Text = "Prod. ordre";
            buttonProductionOrder.UseVisualStyleBackColor = true;
            buttonProductionOrder.Click += buttonProductionOrder_Click;
            // 
            // OrderTypeSelection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 127);
            Controls.Add(buttonProductionOrder);
            Controls.Add(buttonSalesOrder);
            Controls.Add(label1);
            Name = "OrderTypeSelection";
            Text = "OrderTypeSelection";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonSalesOrder;
        private Button buttonProductionOrder;
    }
}