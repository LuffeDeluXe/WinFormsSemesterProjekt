﻿namespace WinFormsSemesterProjekt.GUI.PopUps
{
    partial class MinWarning
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
            buttonYes = new Button();
            buttonNo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 26);
            label1.Name = "label1";
            label1.Size = new Size(330, 40);
            label1.TabIndex = 0;
            label1.Text = "Lagerbeholdningen har ramt minimumsniveauet.\r\nVil du genbestille produktet?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonYes
            // 
            buttonYes.Location = new Point(75, 86);
            buttonYes.Name = "buttonYes";
            buttonYes.Size = new Size(94, 29);
            buttonYes.TabIndex = 1;
            buttonYes.Text = "Ja";
            buttonYes.UseVisualStyleBackColor = true;
            buttonYes.Click += buttonYes_Click;
            // 
            // buttonNo
            // 
            buttonNo.Location = new Point(238, 86);
            buttonNo.Name = "buttonNo";
            buttonNo.Size = new Size(94, 29);
            buttonNo.TabIndex = 2;
            buttonNo.Text = "Nej";
            buttonNo.UseVisualStyleBackColor = true;
            buttonNo.Click += buttonNo_Click;
            // 
            // MinWarning
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 127);
            Controls.Add(buttonNo);
            Controls.Add(buttonYes);
            Controls.Add(label1);
            Name = "MinWarning";
            Text = "MinWarning";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonYes;
        private Button buttonNo;
    }
}