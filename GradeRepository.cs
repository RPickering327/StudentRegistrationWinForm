using System.Data.SqlClient;

namespace StudentManagementWF
{
    class GradeRepository
    {

        public string GetSingleUserGrade(string StudentId)
        {


            DatabaseConnection connect = new DatabaseConnection();
            connect.conOpen();

            int grade;

            using (var command = new SqlCommand($"SELECT StudentGrade FROM Grades WHERE StudentId = @StudentId", connect.Con))
            {
                command.Parameters.AddWithValue("@StudentId", StudentId);
                grade = (int)command.ExecuteScalar();
            }

            string gradeConverted = grade.ToString();


            return gradeConverted;

        }


        public void UpdateStudentsGrade(string studentId, string studentGrade)
        {

            DatabaseConnection connect = new DatabaseConnection();
            connect.conOpen();


            using (var command = new SqlCommand($"UPDATE Grades SET StudentGrade = @StudentGrade WHERE StudentId = @StudentId", connect.Con))
            {
                command.Parameters.AddWithValue("@StudentId", studentId);
                command.Parameters.AddWithValue("@StudentGrade", studentGrade);
                command.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Grade Updated!");

            }
        }

    }
}


