namespace WinFormsSemesterProjekt.GUI.PopUps
{
    partial class UpdatedCustomer
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
            labelText = new Label();
            buttonOk = new Button();
            SuspendLayout();
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Location = new Point(32, 32);
            labelText.Name = "labelText";
            labelText.Size = new Size(185, 40);
            labelText.TabIndex = 7;
            labelText.Text = "Oplysninger for kunde\r\n{navn} er blevet opdateret.";
            labelText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(78, 86);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(94, 29);
            buttonOk.TabIndex = 6;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // UpdatedCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 127);
            Controls.Add(labelText);
            Controls.Add(buttonOk);
            Name = "UpdatedCustomer";
            Text = "UpdatedCustomer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelText;
        private Button buttonOk;
    }
}