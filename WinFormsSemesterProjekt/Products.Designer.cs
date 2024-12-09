namespace WinFormsSemesterProjekt
{
    partial class Products
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
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            searchBar = new TextBox();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            listBox1 = new ListBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(197, 49);
            label1.TabIndex = 0;
            label1.Text = "Produkter";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(202, 26);
            label2.TabIndex = 1;
            label2.Text = "Filtrer efter kategori";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 284);
            label3.Name = "label3";
            label3.Size = new Size(227, 26);
            label3.TabIndex = 2;
            label3.Text = "Filtrer efter lagerstatus";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(694, 22);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Søg";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(12, 409);
            button2.Name = "button2";
            button2.Size = new Size(123, 29);
            button2.TabIndex = 4;
            button2.Text = "Hovedmenu";
            button2.UseVisualStyleBackColor = false;
            // 
            // searchBar
            // 
            searchBar.BorderStyle = BorderStyle.FixedSingle;
            searchBar.Location = new Point(313, 24);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(375, 27);
            searchBar.TabIndex = 5;
            searchBar.Enter += searchBar_Enter;
            searchBar.Leave += searchBar_Leave;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(313, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(475, 304);
            dataGridView1.TabIndex = 6;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(313, 409);
            button3.Name = "button3";
            button3.Size = new Size(148, 29);
            button3.TabIndex = 7;
            button3.Text = "Nyt produkt";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(476, 409);
            button4.Name = "button4";
            button4.Size = new Size(148, 29);
            button4.TabIndex = 8;
            button4.Text = "Ændr valgt produkt";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(640, 409);
            button5.Name = "button5";
            button5.Size = new Size(148, 29);
            button5.TabIndex = 9;
            button5.Text = "Slet valgt produkt";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Black;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = SystemColors.ControlLightLight;
            button6.Location = new Point(694, 57);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 10;
            button6.Text = "Sorter efter";
            button6.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(20, 117);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(222, 164);
            listBox1.TabIndex = 11;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(20, 313);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(83, 24);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "På lager";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(20, 343);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(115, 24);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.Text = "Ikke på lager";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(listBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(searchBar);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Products";
            Text = "Products";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private TextBox searchBar;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private ListBox listBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}