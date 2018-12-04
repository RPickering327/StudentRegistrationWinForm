using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentManagementWF;

namespace StudentRegistrationUnitTesting
{
    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void MinimumGradeBelowAndAboveExpected()
        {
            //Creat a new instance of course
            var NewCourse = new Course();

            //Assign a value below 0
            NewCourse.MinimumGrade = -1;

            //Check the value has not been assigned to minimum grade
            Assert.AreNotEqual(NewCourse.MinimumGrade, -1);

            //Assign a value above 100
            NewCourse.MinimumGrade = 101;

            //Check the value has not been assigned to minimum grade
            Assert.AreNotEqual(NewCourse.MinimumGrade, 101);
            Assert.AreEqual(NewCourse.Valid, false);

        }

        [TestMethod]
        public void ValidGradeEntered()
        {
            //Creat a new instance of course
            var NewCourse = new Course();

            //Assign a value below 0
            NewCourse.MinimumGrade = 55;

            //Check the value has not been assigned to minimum grade
            Assert.AreEqual(NewCourse.MinimumGrade, 55);
            Assert.AreEqual(NewCourse.Valid, true);
        }
    }
}
