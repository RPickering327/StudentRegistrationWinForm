namespace StudentManagementWF
{
    public class Student
    {
        public int StudentId { get; private set; }
        public string Address { get; set; }

        private string _firstName;
        private string _lastName;
        private string _studentType;


        //Verify a valid first name is giving
        public string StudentFirstName
        {
            get { return _firstName; }
            set
            {

                if (!string.IsNullOrEmpty(value))
                {
                    _firstName = value;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("First name is empty");
                }



            }
        }

        //Verify a valid last name is giving
        public string StudentLastName
        {
            get { return _lastName; }
            set
            {

                if (!string.IsNullOrEmpty(value))
                {
                    _lastName = value;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Last name is empty");
                }



            }
        }

        //Verfiy a valid student type is giving
        public string StudentType
        {
            get { return _studentType; }
            set
            {

                if (value == "F" || value == "P" || value == "U")
                {
                    _studentType = value;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Student type is not valid");
                }



            }
        }


    }
}
