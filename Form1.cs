using System;
using System.Windows.Forms;

namespace StudentManagementWF
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var NewStudent = new StudentRepository();
            var Courses = new CourseRepository();
            dataGridView1.DataSource = NewStudent.DisplayStudents();
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.DataSource = Courses.DisplayCourses();
            dataGridView2.AutoResizeColumns();
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


        }


        //Add a new student to the database
        private void AddStudent_Click(object sender, EventArgs e)
        {
            var NewStudent = new StudentRepository();
            NewStudent.AddStudent(FirstName.Text, LastName.Text, StudentAddress.Text, StudentType.Text);
            ClearForm();
            dataGridView1.DataSource = NewStudent.DisplayStudents();


        }


        //Add a new course to the database
        private void AddCourseBtn_Click(object sender, EventArgs e)
        {
            var NewCourse = new CourseRepository();
            NewCourse.AddCourse(CourseName.Text, int.Parse(MinGrade.Text));
            ClearForm();
            dataGridView2.DataSource = NewCourse.DisplayCourses();


        }

        //Display undergraduate students in the datagrid view
        private void undergraduatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var NewStudent = new StudentRepository();
            dataGridView1.DataSource = NewStudent.DisplayStudentsByType("U");
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        //Display postgraduate students in the datagrid view
        private void postgraduatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var NewStudent = new StudentRepository();
            dataGridView1.DataSource = NewStudent.DisplayStudentsByType("P");
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        //Display oversea students in the datagrid view
        private void foreignStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var NewStudent = new StudentRepository();
            dataGridView1.DataSource = NewStudent.DisplayStudentsByType("F");
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        //Display all students in the datagrid view
        private void viewAllStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var NewStudent = new StudentRepository();
            dataGridView1.DataSource = NewStudent.DisplayStudents();
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        private void assignStudentToCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            AssignStudentForm studentForm = new AssignStudentForm();

            // Show the settings form
            studentForm.Show();
        }

        private void UpdateGradeBtn_Click(object sender, EventArgs e)
        {

            //Get user input
            var studentId = StudentIdTxtBox.Text;
            var studentGrade = StudentGradeTxtBox.Text;

            //Validate user input
            var NewStudent = new Grade();
            NewStudent.StudentId = studentId;
            NewStudent.StudentGrade = studentGrade;

            //Update the database with the user input once valid.

            var UpdateGrade = new GradeRepository();

            UpdateGrade.UpdateStudentsGrade(NewStudent.StudentId, NewStudent.StudentGrade);



        }


        //Clear all form inputs.
        private void ClearForm()
        {

            FirstName.Clear();
            LastName.Clear();
            StudentAddress.Clear();
            StudentType.SelectedIndex = -1;
            CourseName.Clear();
            MinGrade.Clear();
        }


    }
}
