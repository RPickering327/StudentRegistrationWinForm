namespace StudentManagementWF
{
    public class Course
    {

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public bool Valid { get; set; }



        private int _minimumGrade;


        //Only grades between 0 and 100 should be accepted.
        public int MinimumGrade
        {
            get { return _minimumGrade; }


            set
            {

                if (value > 0 && value < 100)
                {
                    _minimumGrade = value;
                    Valid = true;
                }
                else
                {
                    Valid = false;
                    System.Windows.Forms.MessageBox.Show("Grades should be between 0 - 100");
                }


            }
        }


    }
}
