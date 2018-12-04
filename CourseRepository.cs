using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace StudentManagementWF
{
    class CourseRepository
    {

        //Display all the courses into the data grid view this can be called to refresh the table
        public DataTable DisplayCourses()
        {

            DatabaseConnection connect = new DatabaseConnection();
            connect.conOpen();

            SqlCommand sqlData = new SqlCommand("SELECT * FROM Courses", connect.Con);
            DataTable courseTable = new DataTable();
            SqlDataReader reader = sqlData.ExecuteReader();
            courseTable.Load(reader);

            connect.conClose();

            return courseTable;


        }

        //Add course function used for the main form to add courses to the database.
        public void AddCourse(string courseName, int minimumGrade)
        {

            var course = new Course();

            course.MinimumGrade = minimumGrade;


            if (course.Valid)
            {
                DatabaseConnection connect = new DatabaseConnection();
                connect.conOpen();

                try
                {
                    SqlCommand cmd = new SqlCommand($"INSERT into Courses (CourseName, MinimumGrade) VALUES (@CourseName, @MinimumGrade)", connect.Con);
                    cmd.Parameters.AddWithValue("@CourseName", courseName);
                    cmd.Parameters.AddWithValue("@MinimumGrade", minimumGrade);


                    cmd.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show($"{courseName}, has been added. ");



                }
                catch (SqlException)
                {

                }

                connect.conClose();
            }



        }


        //Display a single course details if the correct ID is entered and retrieve the details from the database in the assign student form
        public List<String> DisplayCourseDetails(string id)
        {


            DatabaseConnection connect = new DatabaseConnection();
            connect.conOpen();



            SqlCommand sqlData = new SqlCommand($"SELECT CourseName, MinimumGrade FROM Courses WHERE CourseId = {id}", connect.Con);

            List<String> columnData = new List<String>();

            using (SqlDataReader reader = sqlData.ExecuteReader())
            {
                while (reader.Read())
                {
                    columnData.Add(reader.GetString(0));
                    columnData.Add(reader.GetInt32(1).ToString());
                }
            }

            connect.conClose();

            return columnData;

        }


        //Get all the course names to which a student has been enrolled in via the studentId supplied
        public List<String> DisplayStudentAssignedCourses(string studentId)
        {


            DatabaseConnection connect = new DatabaseConnection();
            connect.conOpen();

            var courseId = new List<string>();

            SqlCommand sqlData = new SqlCommand($"SELECT CourseId FROM EnrolledStudents WHERE StudentId = {studentId}", connect.Con);

            using (SqlDataReader reader = sqlData.ExecuteReader())
            {
                while (reader.Read())
                {

                    courseId.Add(reader.GetInt32(0).ToString());
                }
            }


            List<String> columnData = new List<string>();


            foreach (var item in courseId)
            {

                columnData.AddRange(DisplayCourseDetails(item));

            }



            connect.conClose();

            return columnData;

        }

        //Add the student to the course 
        public void AddStudentToCourse(string studentID, string courseID)
        {

            DatabaseConnection connect = new DatabaseConnection();
            connect.conOpen();


            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = connect.Con;
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT into EnrolledStudents (StudentId, CourseId) VALUES (@StudentId, @CourseId)";
                command.Parameters.AddWithValue("@StudentId", studentID);
                command.Parameters.AddWithValue("@CourseId", courseID);

                try
                {
                    int recordsAffected = command.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show("Student added");
                }
                catch (SqlException)
                {
                    System.Windows.Forms.MessageBox.Show("Something has gone wrong the student hasn't been added to the course!");

                }
                finally
                {
                    connect.conClose();
                }
            }

        }



    }
}
