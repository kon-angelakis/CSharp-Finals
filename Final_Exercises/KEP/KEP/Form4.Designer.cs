namespace KEP
{
    partial class Form4
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.delButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.selButton = new System.Windows.Forms.Button();
            this.deleteCont = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.editCont = new System.Windows.Forms.GroupBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addrBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.mailBox = new System.Windows.Forms.TextBox();
            this.ssnBox = new System.Windows.Forms.TextBox();
            this.appBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.editCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Application Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox1.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(10, 220);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(775, 220);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(100, 115);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(88, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 0;
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(40, 81);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(75, 23);
            this.delButton.TabIndex = 4;
            this.delButton.Text = "Delete";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "ID of deletion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "ID to edit";
            // 
            // selButton
            // 
            this.selButton.Location = new System.Drawing.Point(36, 100);
            this.selButton.Name = "selButton";
            this.selButton.Size = new System.Drawing.Size(75, 23);
            this.selButton.TabIndex = 4;
            this.selButton.Text = "Select";
            this.selButton.UseVisualStyleBackColor = true;
            this.selButton.Click += new System.EventHandler(this.selButton_Click);
            // 
            // deleteCont
            // 
            this.deleteCont.Controls.Add(this.numericUpDown2);
            this.deleteCont.Controls.Add(this.label3);
            this.deleteCont.Controls.Add(this.delButton);
            this.deleteCont.Enabled = false;
            this.deleteCont.Location = new System.Drawing.Point(270, 10);
            this.deleteCont.Name = "deleteCont";
            this.deleteCont.Size = new System.Drawing.Size(150, 130);
            this.deleteCont.TabIndex = 1;
            this.deleteCont.TabStop = false;
            this.deleteCont.Text = "Delete Entry";
            this.deleteCont.Visible = false;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(50, 51);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // editCont
            // 
            this.editCont.Controls.Add(this.applyButton);
            this.editCont.Controls.Add(this.label11);
            this.editCont.Controls.Add(this.label10);
            this.editCont.Controls.Add(this.label9);
            this.editCont.Controls.Add(this.label8);
            this.editCont.Controls.Add(this.label7);
            this.editCont.Controls.Add(this.label6);
            this.editCont.Controls.Add(this.label5);
            this.editCont.Controls.Add(this.addrBox);
            this.editCont.Controls.Add(this.phoneBox);
            this.editCont.Controls.Add(this.mailBox);
            this.editCont.Controls.Add(this.ssnBox);
            this.editCont.Controls.Add(this.appBox);
            this.editCont.Controls.Add(this.dateTimePicker1);
            this.editCont.Controls.Add(this.nameBox);
            this.editCont.Controls.Add(this.numericUpDown1);
            this.editCont.Controls.Add(this.selButton);
            this.editCont.Controls.Add(this.label4);
            this.editCont.Enabled = false;
            this.editCont.Location = new System.Drawing.Point(265, 10);
            this.editCont.Name = "editCont";
            this.editCont.Size = new System.Drawing.Size(520, 200);
            this.editCont.TabIndex = 1;
            this.editCont.TabStop = false;
            this.editCont.Text = "Edit Entry";
            this.editCont.Visible = false;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(36, 136);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 12;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(421, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Application:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(215, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Date of Birth:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(437, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(234, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Phone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "SSN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Name:";
            // 
            // addrBox
            // 
            this.addrBox.Location = new System.Drawing.Point(406, 120);
            this.addrBox.Name = "addrBox";
            this.addrBox.Size = new System.Drawing.Size(100, 20);
            this.addrBox.TabIndex = 9;
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(201, 120);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(100, 20);
            this.phoneBox.TabIndex = 8;
            // 
            // mailBox
            // 
            this.mailBox.Location = new System.Drawing.Point(406, 69);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(100, 20);
            this.mailBox.TabIndex = 7;
            // 
            // ssnBox
            // 
            this.ssnBox.Location = new System.Drawing.Point(201, 69);
            this.ssnBox.Name = "ssnBox";
            this.ssnBox.Size = new System.Drawing.Size(100, 20);
            this.ssnBox.TabIndex = 6;
            // 
            // appBox
            // 
            this.appBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.appBox.FormattingEnabled = true;
            this.appBox.ItemHeight = 13;
            this.appBox.Items.AddRange(new object[] {
            "Family Status Certificate",
            "Birth Certificate",
            "Marital Status Certificate",
            "Death Certificate",
            "Capybara Certificate"});
            this.appBox.Location = new System.Drawing.Point(392, 166);
            this.appBox.Name = "appBox";
            this.appBox.Size = new System.Drawing.Size(121, 21);
            this.appBox.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(146, 166);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(304, 28);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(49, 74);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "Family Status Certificate",
            "Birth Certificate",
            "Marital Status Certificate",
            "Death Certificate",
            "Capybara Certificate"});
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Family Status Certificate",
            "Birth Certificate",
            "Marital Status Certificate",
            "Death Certificate",
            "Capybara Certificate"});
            this.comboBox2.Location = new System.Drawing.Point(100, 70);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(125, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Entry";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 451);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.editCont);
            this.Controls.Add(this.deleteCont);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form4";
            this.Text = "Manage Applications";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.deleteCont.ResumeLayout(false);
            this.deleteCont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.editCont.ResumeLayout(false);
            this.editCont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button selButton;
        private System.Windows.Forms.GroupBox deleteCont;
        private System.Windows.Forms.GroupBox editCont;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TextBox ssnBox;
        private System.Windows.Forms.ComboBox appBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addrBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox mailBox;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}