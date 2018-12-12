namespace StudentManagementWF
{
    partial class form1
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
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.StudentAddress = new System.Windows.Forms.TextBox();
            this.AddStudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StudentType = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.UpdateGradeBtn = new System.Windows.Forms.Button();
            this.StudentGradeTxtBox = new System.Windows.Forms.TextBox();
            this.StudentIdTxtBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CourseName = new System.Windows.Forms.TextBox();
            this.MinGrade = new System.Windows.Forms.TextBox();
            this.AddCourseBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.assignStudentToCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentsByTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undergraduatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postgraduatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foreignStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(133, 72);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(174, 20);
            this.FirstName.TabIndex = 0;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(133, 96);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(174, 20);
            this.LastName.TabIndex = 1;
            // 
            // StudentAddress
            // 
            this.StudentAddress.Location = new System.Drawing.Point(133, 122);
            this.StudentAddress.Name = "StudentAddress";
            this.StudentAddress.Size = new System.Drawing.Size(174, 20);
            this.StudentAddress.TabIndex = 2;
            // 
            // AddStudent
            // 
            this.AddStudent.Location = new System.Drawing.Point(234, 174);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(114, 52);
            this.AddStudent.TabIndex = 4;
            this.AddStudent.Text = "Add Student";
            this.AddStudent.UseVisualStyleBackColor = true;
            this.AddStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add a student:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "First name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Student Type";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(864, 283);
            this.dataGridView1.TabIndex = 10;
            // 
            // StudentType
            // 
            this.StudentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentType.FormattingEnabled = true;
            this.StudentType.Items.AddRange(new object[] {
            "U",
            "P",
            "F"});
            this.StudentType.Location = new System.Drawing.Point(133, 147);
            this.StudentType.Name = "StudentType";
            this.StudentType.Size = new System.Drawing.Size(173, 21);
            this.StudentType.TabIndex = 12;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 243);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(880, 325);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(872, 289);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Students";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(872, 289);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Courses";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(872, 271);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.UpdateGradeBtn);
            this.tabPage3.Controls.Add(this.StudentGradeTxtBox);
            this.tabPage3.Controls.Add(this.StudentIdTxtBox);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(872, 289);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Update Grades";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // UpdateGradeBtn
            // 
            this.UpdateGradeBtn.Location = new System.Drawing.Point(210, 91);
            this.UpdateGradeBtn.Name = "UpdateGradeBtn";
            this.UpdateGradeBtn.Size = new System.Drawing.Size(138, 59);
            this.UpdateGradeBtn.TabIndex = 20;
            this.UpdateGradeBtn.Text = "Update grade";
            this.UpdateGradeBtn.UseVisualStyleBackColor = true;
            this.UpdateGradeBtn.Click += new System.EventHandler(this.UpdateGradeBtn_Click);
            // 
            // StudentGradeTxtBox
            // 
            this.StudentGradeTxtBox.Location = new System.Drawing.Point(174, 54);
            this.StudentGradeTxtBox.Name = "StudentGradeTxtBox";
            this.StudentGradeTxtBox.Size = new System.Drawing.Size(174, 31);
            this.StudentGradeTxtBox.TabIndex = 9;
            // 
            // StudentIdTxtBox
            // 
            this.StudentIdTxtBox.Location = new System.Drawing.Point(174, 16);
            this.StudentIdTxtBox.Name = "StudentIdTxtBox";
            this.StudentIdTxtBox.Size = new System.Drawing.Size(174, 31);
            this.StudentIdTxtBox.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 28);
            this.label10.TabIndex = 7;
            this.label10.Text = "Student grade:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 28);
            this.label9.TabIndex = 6;
            this.label9.Text = "Student Id:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(395, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "Add a course:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(396, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Course name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(396, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "Minimum grade";
            // 
            // CourseName
            // 
            this.CourseName.Location = new System.Drawing.Point(541, 75);
            this.CourseName.Name = "CourseName";
            this.CourseName.Size = new System.Drawing.Size(174, 20);
            this.CourseName.TabIndex = 17;
            // 
            // MinGrade
            // 
            this.MinGrade.Location = new System.Drawing.Point(541, 101);
            this.MinGrade.Name = "MinGrade";
            this.MinGrade.Size = new System.Drawing.Size(174, 20);
            this.MinGrade.TabIndex = 18;
            // 
            // AddCourseBtn
            // 
            this.AddCourseBtn.Location = new System.Drawing.Point(601, 174);
            this.AddCourseBtn.Name = "AddCourseBtn";
            this.AddCourseBtn.Size = new System.Drawing.Size(114, 52);
            this.AddCourseBtn.TabIndex = 19;
            this.AddCourseBtn.Text = "Add Course";
            this.AddCourseBtn.UseVisualStyleBackColor = true;
            this.AddCourseBtn.Click += new System.EventHandler(this.AddCourseBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assignStudentToCourseToolStripMenuItem,
            this.viewStudentsByTypeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(904, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // assignStudentToCourseToolStripMenuItem
            // 
            this.assignStudentToCourseToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.assignStudentToCourseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignStudentToCourseToolStripMenuItem.Name = "assignStudentToCourseToolStripMenuItem";
            this.assignStudentToCourseToolStripMenuItem.Size = new System.Drawing.Size(155, 20);
            this.assignStudentToCourseToolStripMenuItem.Text = "Assign student to course";
            this.assignStudentToCourseToolStripMenuItem.Click += new System.EventHandler(this.assignStudentToCourseToolStripMenuItem_Click);
            // 
            // viewStudentsByTypeToolStripMenuItem
            // 
            this.viewStudentsByTypeToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.viewStudentsByTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undergraduatesToolStripMenuItem,
            this.postgraduatesToolStripMenuItem,
            this.foreignStudentsToolStripMenuItem,
            this.viewAllStudentsToolStripMenuItem});
            this.viewStudentsByTypeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewStudentsByTypeToolStripMenuItem.Name = "viewStudentsByTypeToolStripMenuItem";
            this.viewStudentsByTypeToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.viewStudentsByTypeToolStripMenuItem.Text = "View students by type";
            // 
            // undergraduatesToolStripMenuItem
            // 
            this.undergraduatesToolStripMenuItem.Name = "undergraduatesToolStripMenuItem";
            this.undergraduatesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.undergraduatesToolStripMenuItem.Text = "Undergraduates";
            this.undergraduatesToolStripMenuItem.Click += new System.EventHandler(this.undergraduatesToolStripMenuItem_Click);
            // 
            // postgraduatesToolStripMenuItem
            // 
            this.postgraduatesToolStripMenuItem.Name = "postgraduatesToolStripMenuItem";
            this.postgraduatesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.postgraduatesToolStripMenuItem.Text = "Postgraduates";
            this.postgraduatesToolStripMenuItem.Click += new System.EventHandler(this.postgraduatesToolStripMenuItem_Click);
            // 
            // foreignStudentsToolStripMenuItem
            // 
            this.foreignStudentsToolStripMenuItem.Name = "foreignStudentsToolStripMenuItem";
            this.foreignStudentsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.foreignStudentsToolStripMenuItem.Text = "Foreign Students";
            this.foreignStudentsToolStripMenuItem.Click += new System.EventHandler(this.foreignStudentsToolStripMenuItem_Click);
            // 
            // viewAllStudentsToolStripMenuItem
            // 
            this.viewAllStudentsToolStripMenuItem.Name = "viewAllStudentsToolStripMenuItem";
            this.viewAllStudentsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.viewAllStudentsToolStripMenuItem.Text = "View all students";
            this.viewAllStudentsToolStripMenuItem.Click += new System.EventHandler(this.viewAllStudentsToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(382, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 210);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(8, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(350, 210);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 569);
            this.Controls.Add(this.AddCourseBtn);
            this.Controls.Add(this.MinGrade);
            this.Controls.Add(this.CourseName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.StudentType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddStudent);
            this.Controls.Add(this.StudentAddress);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "form1";
            this.Text = "Student Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox StudentAddress;
        private System.Windows.Forms.Button AddStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox StudentType;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CourseName;
        private System.Windows.Forms.TextBox MinGrade;
        private System.Windows.Forms.Button AddCourseBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem assignStudentToCourseToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem viewStudentsByTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undergraduatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postgraduatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foreignStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllStudentsToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button UpdateGradeBtn;
        private System.Windows.Forms.TextBox StudentGradeTxtBox;
        private System.Windows.Forms.TextBox StudentIdTxtBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

