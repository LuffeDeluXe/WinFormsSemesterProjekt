namespace WinFormsSemesterProjekt.GUI.PopUps
{
    partial class ConfirmDeletionCustomer
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
            buttonYes = new Button();
            buttonNo = new Button();
            SuspendLayout();
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Location = new Point(46, 32);
            labelText.Name = "labelText";
            labelText.Size = new Size(146, 40);
            labelText.TabIndex = 9;
            labelText.Text = "Er du sikker på, at du\r\nvil slette {navn}?";
            labelText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonYes
            // 
            buttonYes.Location = new Point(29, 86);
            buttonYes.Name = "buttonYes";
            buttonYes.Size = new Size(79, 29);
            buttonYes.TabIndex = 8;
            buttonYes.Text = "Ja";
            buttonYes.UseVisualStyleBackColor = true;
            buttonYes.Click += buttonOk_Click;
            // 
            // buttonNo
            // 
            buttonNo.Location = new Point(138, 86);
            buttonNo.Name = "buttonNo";
            buttonNo.Size = new Size(79, 29);
            buttonNo.TabIndex = 10;
            buttonNo.Text = "Nej";
            buttonNo.UseVisualStyleBackColor = true;
            buttonNo.Click += buttonNo_Click;
            // 
            // ConfirmDeletionCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 127);
            Controls.Add(buttonNo);
            Controls.Add(labelText);
            Controls.Add(buttonYes);
            Name = "ConfirmDeletionCustomer";
            Text = "ConfirmDeletionCustomer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelText;
        private Button buttonYes;
        private Button buttonNo;
    }
}