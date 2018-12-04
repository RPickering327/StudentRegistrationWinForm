namespace StudentManagementWF
{
    class Grade
    {

        public int GradeId { get; set; }

        private string _studentId;

        public string StudentId
        {
            get { return _studentId; }


            set
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(value, "^[0-9]*$"))
                {
                    _studentId = value;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Please enter a numeric input");
                }




            }
        }



        private string _studentGrade;

        public string StudentGrade
        {
            get
            {
                return _studentGrade;
            }

            set
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(value, "^[0-9]*$"))
                {
                    _studentGrade = value;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Please enter a numeric input for student grade");

                }


            }
        }


    }
}
