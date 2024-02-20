using NUnit.Framework;
using Moq;
using SchoolDataLibrary;
namespace SchoolData
{
    [TestFixture]
    public class SchoolDataTests
    {
        [Test]
        public void Teacher_GetTeacherInfo_ShouldReturnCorrectInfo()
        {
            var teacher = new Teacher("Faith Rachel", "Science");
            var result = teacher.GetTeacherInfo();
            Assert.That(result, Is.EqualTo("Faith Rachel teaches Science"));
        }
        [Test]
        public void Student_GetStudentInfo_ShouldReturnCorrectInfo()
        {
            var student = new Student("Junia", 7);
            var result = student.GetStudentInfo();
            Assert.That(result, Is.EqualTo("Junia is in grade 7"));
        }
        [Test]
        public void Subject_GetSubjectInfo_ShouldReturnCorrectInfo()
        {
            var subject = new Subject("Physics", 3);
            var result = subject.GetSubjectInfo();
            Assert.That(result, Is.EqualTo("Physics has 3 credits"));
        }
        [Test]
        public void MockingExample()
        {
            var mockTeacher = new Teacher("MockedTeacher", "MockedSubject");
            var result = mockTeacher.GetTeacherInfo();
            Assert.That(result, Is.EqualTo("MockedTeacher teaches MockedSubject"));
        }
        [Test]
        [TestCase("Faith", 8)]
        [TestCase("Junia", 9)]
        public void Student_GetStudentInfoWithData(string studentName, int gradeLevel)
        {
            var student = new Student(studentName, gradeLevel);
            var result = student.GetStudentInfo();
            Assert.That(result, Is.EqualTo($"{studentName} is in grade {gradeLevel}"));
        }
    }
}