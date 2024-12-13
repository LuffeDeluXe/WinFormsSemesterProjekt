namespace WinFormsSemesterProjekt.GUI.PopUps
{
    partial class CreatedOrder
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
            buttonOk = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 9);
            label1.Name = "label1";
            label1.Size = new Size(209, 80);
            label1.TabIndex = 5;
            label1.Text = "Ordre sendt til {receiver}.\r\nNyt {orderType} oprettet.\r\n\r\nOrdrenummer: {orderNumber}";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(77, 92);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(94, 29);
            buttonOk.TabIndex = 4;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // CreatedOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 127);
            Controls.Add(label1);
            Controls.Add(buttonOk);
            Name = "CreatedOrder";
            Text = "CreatedOrder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonOk;
    }
}