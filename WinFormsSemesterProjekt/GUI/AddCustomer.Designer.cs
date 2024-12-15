namespace WinFormsSemesterProjekt.GUI
{
    partial class AddCustomer
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
            buttonAdd = new Button();
            label3 = new Label();
            label2 = new Label();
            textBoxLastName = new TextBox();
            textBoxFirstName = new TextBox();
            label1 = new Label();
            textBoxPhoneNumber = new TextBox();
            textBoxEmail = new TextBox();
            radioButtonPrivateCustomer = new RadioButton();
            radioButtonCompany = new RadioButton();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxArea = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // buttonReturn
            // 
            buttonReturn.Location = new Point(14, 409);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(158, 29);
            buttonReturn.TabIndex = 26;
            buttonReturn.Text = "Tilbage til oversigt";
            buttonReturn.UseVisualStyleBackColor = true;
            buttonReturn.Click += buttonReturn_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(324, 409);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(154, 29);
            buttonAdd.TabIndex = 25;
            buttonAdd.Text = "Opret kunde";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(213, 130);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 20;
            label3.Text = "Efternavn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 87);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 19;
            label2.Text = "Fornavn:";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(288, 127);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(233, 27);
            textBoxLastName.TabIndex = 16;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(288, 84);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(233, 27);
            textBoxFirstName.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(263, 9);
            label1.Name = "label1";
            label1.Size = new Size(288, 59);
            label1.TabIndex = 14;
            label1.Text = "Opret kunde";
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(288, 172);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(233, 27);
            textBoxPhoneNumber.TabIndex = 27;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(288, 220);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(233, 27);
            textBoxEmail.TabIndex = 28;
            // 
            // radioButtonPrivateCustomer
            // 
            radioButtonPrivateCustomer.AutoSize = true;
            radioButtonPrivateCustomer.Location = new Point(324, 339);
            radioButtonPrivateCustomer.Name = "radioButtonPrivateCustomer";
            radioButtonPrivateCustomer.Size = new Size(67, 24);
            radioButtonPrivateCustomer.TabIndex = 29;
            radioButtonPrivateCustomer.TabStop = true;
            radioButtonPrivateCustomer.Text = "Privat";
            radioButtonPrivateCustomer.UseVisualStyleBackColor = true;
            // 
            // radioButtonCompany
            // 
            radioButtonCompany.AutoSize = true;
            radioButtonCompany.Location = new Point(400, 339);
            radioButtonCompany.Name = "radioButtonCompany";
            radioButtonCompany.Size = new Size(78, 24);
            radioButtonCompany.TabIndex = 30;
            radioButtonCompany.TabStop = true;
            radioButtonCompany.Text = "Erhverv";
            radioButtonCompany.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(171, 175);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 31;
            label4.Text = "Telefonnummer:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(182, 223);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 32;
            label5.Text = "E-Mailadresse:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(360, 307);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 33;
            label6.Text = "Kundetype:";
            // 
            // textBoxArea
            // 
            textBoxArea.Location = new Point(288, 264);
            textBoxArea.Name = "textBoxArea";
            textBoxArea.Size = new Size(233, 27);
            textBoxArea.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(221, 267);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 35;
            label7.Text = "Område:";
            // 
            // AddCustomer
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
            Controls.Add(buttonReturn);
            Controls.Add(buttonAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(label1);
            Name = "AddCustomer";
            Text = "AddCustomer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonReturn;
        private Button buttonAdd;
        private Label label3;
        private Label label2;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private Label label1;
        private TextBox textBoxPhoneNumber;
        private TextBox textBoxEmail;
        private RadioButton radioButtonPrivateCustomer;
        private RadioButton radioButtonCompany;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxArea;
        private Label label7;
    }
}