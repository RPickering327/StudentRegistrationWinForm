using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace StudentManagementWF
{
    class StudentRepository
    {

        //Adds the student into the database
        public void AddStudent(string firstName, string lastName, string address, string studentType)
        {


            var NewStudent = new Student();

            NewStudent.StudentFirstName = firstName;
            NewStudent.StudentLastName = lastName;
            NewStudent.StudentType = studentType;


            if (!string.IsNullOrEmpty(NewStudent.StudentFirstName))
            {
                if (!string.IsNullOrEmpty(NewStudent.StudentLastName))
                {
                    if (!string.IsNullOrEmpty(NewStudent.StudentType))
                    {

                        DatabaseConnection connect = new DatabaseConnection();
                        connect.conOpen();

                        try
                        {
                            SqlCommand cmd = new SqlCommand("INSERT into Student (FirstName, LastName, Address, StudentType) VALUES (@firstName, @lastName, @address, @studentType)", connect.Con);
                            cmd.Parameters.AddWithValue("@firstName", firstName);
                            cmd.Parameters.AddWithValue("@lastName", lastName);
                            cmd.Parameters.AddWithValue("@address", address);
                            cmd.Parameters.AddWithValue("@studentType", studentType);
                            cmd.ExecuteNonQuery();

                            System.Windows.Forms.MessageBox.Show($"{firstName}, {lastName} has been added. ");



                        }
                        catch (SqlException)
                        {

                        }


                        connect.conClose();
                    }
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show($"Student was not added to the database, they're missing data");

            }


        }


        // Displays all the students in the table on the first screen into the datagrid view
        public DataTable DisplayStudents()
        {

            DatabaseConnection connect = new DatabaseConnection();

            connect.conOpen();

            SqlCommand sqlData = new SqlCommand("SELECT Student.*, Grades.StudentGrade FROM Student LEFT JOIN Grades ON Student.StudentId = Grades.StudentId", connect.Con);
            DataTable studentTable = new DataTable();
            SqlDataReader reader = sqlData.ExecuteReader();
            studentTable.Load(reader);

            connect.conClose();

            return studentTable;

        }


        // Displays all the students in the table on the first screen into the datagrid view
        public DataTable DisplayStudentsByType(string studentType)
        {

            DatabaseConnection connect = new DatabaseConnection();

            connect.conOpen();

            SqlCommand sqlData = new SqlCommand($"SELECT Student.*, Grades.StudentGrade FROM Student LEFT JOIN Grades ON Student.StudentId = Grades.StudentId WHERE Student.StudentType = @studentType", connect.Con);
            sqlData.Parameters.AddWithValue("@studentType", studentType);
            DataTable studentTable = new DataTable();
            SqlDataReader reader = sqlData.ExecuteReader();
            studentTable.Load(reader);

            connect.conClose();

            return studentTable;

        }


        //Display the student details if the correct ID is entered and retrieve the details from the database in the assign student form
        public List<String> DisplaySingleStudentDetails(string id)
        {


            DatabaseConnection connect = new DatabaseConnection();
            connect.conOpen();



            SqlCommand sqlData = new SqlCommand($"SELECT FirstName, LastName, StudentType FROM Student WHERE StudentId = @studentId", connect.Con);
            sqlData.Parameters.AddWithValue("@studentId", id);

            List<String> columnData = new List<String>();

            using (SqlDataReader reader = sqlData.ExecuteReader())
            {
                while (reader.Read())
                {
                    columnData.Add(reader.GetString(0));
                    columnData.Add(reader.GetString(1));
                    columnData.Add(reader.GetString(2));
                }
            }

            connect.conClose();

            return columnData;

        }
    }
}



