﻿namespace WinFormsSemesterProjekt.GUI
{
    partial class EditCustomer
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
            label1 = new Label();
            label7 = new Label();
            textBoxArea = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            radioButtonCompany = new RadioButton();
            radioButtonPrivateCustomer = new RadioButton();
            textBoxEmail = new TextBox();
            textBoxPhoneNumber = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBoxLastName = new TextBox();
            textBoxFirstName = new TextBox();
            SuspendLayout();
            // 
            // buttonReturn
            // 
            buttonReturn.Location = new Point(16, 409);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(158, 29);
            buttonReturn.TabIndex = 40;
            buttonReturn.Text = "Tilbage til oversigt";
            buttonReturn.UseVisualStyleBackColor = true;
            buttonReturn.Click += buttonReturn_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(326, 409);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(154, 29);
            buttonEdit.TabIndex = 39;
            buttonEdit.Text = "Opdater oplysninger";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(238, 9);
            label1.Name = "label1";
            label1.Size = new Size(325, 59);
            label1.TabIndex = 34;
            label1.Text = "Rediger kunde";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(221, 268);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 53;
            label7.Text = "Område:";
            // 
            // textBoxArea
            // 
            textBoxArea.Location = new Point(288, 265);
            textBoxArea.Name = "textBoxArea";
            textBoxArea.Size = new Size(233, 27);
            textBoxArea.TabIndex = 52;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(360, 308);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 51;
            label6.Text = "Kundetype:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(182, 224);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 50;
            label5.Text = "E-Mailadresse:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(171, 176);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 49;
            label4.Text = "Telefonnummer:";
            // 
            // radioButtonCompany
            // 
            radioButtonCompany.AutoSize = true;
            radioButtonCompany.Location = new Point(400, 340);
            radioButtonCompany.Name = "radioButtonCompany";
            radioButtonCompany.Size = new Size(78, 24);
            radioButtonCompany.TabIndex = 48;
            radioButtonCompany.TabStop = true;
            radioButtonCompany.Text = "Erhverv";
            radioButtonCompany.UseVisualStyleBackColor = true;
            // 
            // radioButtonPrivateCustomer
            // 
            radioButtonPrivateCustomer.AutoSize = true;
            radioButtonPrivateCustomer.Location = new Point(324, 340);
            radioButtonPrivateCustomer.Name = "radioButtonPrivateCustomer";
            radioButtonPrivateCustomer.Size = new Size(67, 24);
            radioButtonPrivateCustomer.TabIndex = 47;
            radioButtonPrivateCustomer.TabStop = true;
            radioButtonPrivateCustomer.Text = "Privat";
            radioButtonPrivateCustomer.UseVisualStyleBackColor = true;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(288, 221);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(233, 27);
            textBoxEmail.TabIndex = 46;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(288, 173);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(233, 27);
            textBoxPhoneNumber.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(213, 131);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 44;
            label3.Text = "Efternavn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 88);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 43;
            label2.Text = "Fornavn:";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(288, 128);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(233, 27);
            textBoxLastName.TabIndex = 42;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(288, 85);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(233, 27);
            textBoxFirstName.TabIndex = 41;
            // 
            // EditCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(textBoxArea);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(radioButtonCompany);
            Controls.Add(radioButtonPrivateCustomer);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(buttonReturn);
            Controls.Add(buttonEdit);
            Controls.Add(label1);
            Name = "EditCustomer";
            Text = "EditCustomer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonReturn;
        private Button buttonEdit;
        private Label label1;
        private Label label7;
        private TextBox textBoxArea;
        private Label label6;
        private Label label5;
        private Label label4;
        private RadioButton radioButtonCompany;
        private RadioButton radioButtonPrivateCustomer;
        private TextBox textBoxEmail;
        private TextBox textBoxPhoneNumber;
        private Label label3;
        private Label label2;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
    }
}