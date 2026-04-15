namespace WindowsFormsApp1
{
    partial class Form1
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
            this.Browse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MiddleNameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GenderListBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CourseListBox = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.YearBox = new System.Windows.Forms.TextBox();
            this.BirthDateBox = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(103, 267);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(100, 46);
            this.Browse.TabIndex = 0;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "STUDENT REGISTRATION";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(103, 54);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(100, 20);
            this.FirstNameBox.TabIndex = 3;
            this.FirstNameBox.TextChanged += new System.EventHandler(this.FirstNameBox_TextChanged);
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(28, 57);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(60, 13);
            this.FirstName.TabIndex = 4;
            this.FirstName.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name:";
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(103, 80);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(100, 20);
            this.LastNameBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Middle Initial:";
            // 
            // MiddleNameBox
            // 
            this.MiddleNameBox.Location = new System.Drawing.Point(103, 106);
            this.MiddleNameBox.Name = "MiddleNameBox";
            this.MiddleNameBox.Size = new System.Drawing.Size(100, 20);
            this.MiddleNameBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Birthdate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Address:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // GenderListBox
            // 
            this.GenderListBox.FormattingEnabled = true;
            this.GenderListBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderListBox.Location = new System.Drawing.Point(103, 158);
            this.GenderListBox.Name = "GenderListBox";
            this.GenderListBox.Size = new System.Drawing.Size(100, 17);
            this.GenderListBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Course:";
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(103, 181);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(100, 20);
            this.AddressBox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Year:";
            // 
            // CourseListBox
            // 
            this.CourseListBox.FormattingEnabled = true;
            this.CourseListBox.Items.AddRange(new object[] {
            "BSIT",
            "BSTVETED",
            "BSMECH"});
            this.CourseListBox.Location = new System.Drawing.Point(103, 207);
            this.CourseListBox.Name = "CourseListBox";
            this.CourseListBox.Size = new System.Drawing.Size(100, 17);
            this.CourseListBox.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Image:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(290, 267);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(95, 46);
            this.Save.TabIndex = 23;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // YearBox
            // 
            this.YearBox.Location = new System.Drawing.Point(103, 230);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(100, 20);
            this.YearBox.TabIndex = 24;
            // 
            // BirthDateBox
            // 
            this.BirthDateBox.Location = new System.Drawing.Point(103, 132);
            this.BirthDateBox.Name = "BirthDateBox";
            this.BirthDateBox.Size = new System.Drawing.Size(100, 20);
            this.BirthDateBox.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.tile;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BirthDateBox);
            this.Controls.Add(this.YearBox);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CourseListBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GenderListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MiddleNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Browse);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MiddleNameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox GenderListBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox CourseListBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox YearBox;
        private System.Windows.Forms.DateTimePicker BirthDateBox;
    }
}

