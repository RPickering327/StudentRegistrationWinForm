using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentManagementWF;

namespace StudentRegistrationUnitTesting
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void InvalidFirstNameAndLastName()
        {
            //Creat a new instance of course
            var student = new Student();

            //Assign a value below 0
            student.StudentFirstName = "";
            student.StudentLastName = null;

            //Check the value has not been assigned to minimum grade
            Assert.AreEqual(student.StudentFirstName, null);
            Assert.AreEqual(student.StudentLastName, null);


        }

        [TestMethod]
        public void ValidFirstNameAndLastName()
        {
            //Creat a new instance of course
            var student = new Student();

            //Assign a value below 0
            student.StudentFirstName = "John";
            student.StudentLastName = "Smith";

            //Check the value has not been assigned to minimum grade
            Assert.AreEqual(student.StudentFirstName, "John");
            Assert.AreEqual(student.StudentLastName, "Smith");


        }
    }
}
