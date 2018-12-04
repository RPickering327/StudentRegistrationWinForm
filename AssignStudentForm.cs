using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace StudentManagementWF
{
    public partial class AssignStudentForm : Form
    {
        public AssignStudentForm()
        {
            InitializeComponent();
            AssignStudentBtn.Enabled = false;
        }


        //Search for the student within the database and display the courses they are listed on.
        private void SearchStudentBtn_Click(object sender, EventArgs e)
        {

            var FoundStudent = new StudentRepository();
            var StudentGrade = new GradeRepository();
            var EnrolledCourses = new CourseRepository();


            //Assign the method output to a list of strings to be displayed.
            List<string> studentData = FoundStudent.DisplaySingleStudentDetails(StudentIdSearch.Text);
            //If the student has a course already assigned display them on the screen.
            List<string> enrolledCourses = EnrolledCourses.DisplayStudentAssignedCourses(StudentIdSearch.Text);


            //Display the student first and last name.
            if (studentData.Count > 0)
            {
                for (int i = 0; i < 1; i++)
                {
                    StudentNameLbl.Text = "";
                    StudentNameLbl.Text += studentData[0] + " " + studentData[1];
                    StudentTypeLbl.Text = studentData[2];
                    studentData.Clear();

                }

                StudentGradeLbl.Text = StudentGrade.GetSingleUserGrade(StudentIdSearch.Text);

                courseslbl.Text = "";

                for (var j = 0; j < enrolledCourses.Count; j += 2)
                {
                    courseslbl.Text += enrolledCourses[j] + "\r\n";
                }
            }
            else
            {

                StudentNameLbl.Text = "There are no students with that ID";

                StudentTypeLbl.Text = "";
                StudentGradeLbl.Text = "";
                courseslbl.Text = "";

                studentData.Clear();

            }

            MeetMinimumGrade();

        }



        //When the course ID is entered the course is brought up for the user to validate the minimum requirements
        private void SearchCourseBtn_Click(object sender, EventArgs e)
        {

            var CourseDetails = new CourseRepository();


            //Assign the method output to a list of strings to be displayed.
            List<String> CourseData = CourseDetails.DisplayCourseDetails(SearchCourseBox.Text);

            //If the course count is greater than zero display the courses
            if (CourseData.Count > 0)
            {
                for (int i = 0; i < 1; i++)
                {

                    courseNameLbl.Text = CourseData[0];
                    RequiredGradeLbl.Text = CourseData[1];

                    CourseData.Clear();

                }
            }
            else
            {

                courseNameLbl.Text = "Course not found";
                CourseData.Clear();

            }



            MeetMinimumGrade();

        }


        //If the user meets the minimum grade required for the course enable the assign button
        private void MeetMinimumGrade()
        {

            int studentGrade = 0;
            int courseGrade = 0;


            //Try to convert the text if not do nothing
            if (int.TryParse(StudentGradeLbl.Text, out _))
            {
                studentGrade = Int32.Parse(StudentGradeLbl.Text);
            }

            if (int.TryParse(RequiredGradeLbl.Text, out _))
            {
                courseGrade = Int32.Parse(RequiredGradeLbl.Text);
            }


            //If the search box is not null or empty run the validation check
            if (!string.IsNullOrEmpty(SearchCourseBox.Text))
            {
                if (studentGrade >= courseGrade)
                {
                    ValidCourseLbl.Text = "Eligible: YES";
                    AssignStudentBtn.Enabled = true;

                }
                else
                {
                    ValidCourseLbl.Text = "Eligible NO";
                    AssignStudentBtn.Enabled = false;
                }
            }



        }

        private void AssignStudentBtn_Click(object sender, EventArgs e)
        {

            var EnrollStudents = new CourseRepository();

            EnrollStudents.AddStudentToCourse(StudentIdSearch.Text, SearchCourseBox.Text);
        }
    }
}
