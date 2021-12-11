using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using STProject.Core;

namespace UnitTestProgram
{
    [TestClass]
    public class UnitTestStudent
    {
        private Student students = new Student();

        [TestMethod]
        public void Student_Exception_Initialisations()
        {
            Student student = new Student();
            Assert.ThrowsException<ArgumentException>(()=>student.Evaluation = -1);//Оценката не може да бъде по-малка от 2
            Assert.ThrowsException<ArgumentException>(() => student.FacultyNumber = -1);//Факултетния номер не може да бъде по-малък от 470000
            Assert.ThrowsException<ArgumentException>(() => student.FacultyNumber = 50000);// Факултетния номер не може да бъде по-голям от 480000
            Assert.ThrowsException<ArgumentException>(() => student.Password = "");//Паролата не може да бъде празна
            student.Password = "1234t56";
            Assert.ThrowsException<ArgumentException>(() => student.VerifyPassword= "3456788");//Паролата трябва да бъде еднаква
            Assert.ThrowsException<ArgumentException>(() => student.FirstName = "");//Името не може да бъде празно
            Assert.ThrowsException<ArgumentException>(() => student.LastName = "");//Фамилията не може да бъде празна
            Assert.ThrowsException<ArgumentException>(() => student.Email = "");//Email-a не може да бъде празeн
            Assert.ThrowsException<ArgumentException>(() => student.PhoneNumber = "hjklfd123");// Телефония номер трябва да бъде валиден

        }

        [TestMethod]
        public void Student_Evaluation_When_Default()
        {
            Student student = new Student();
            student.Evaluation = 2;

            student.Evaluate(5);
            Assert.AreEqual(student.Evaluation, 5);
        }

        [TestMethod]
        public void Student_Evaluation()
        {
            Student student = new Student();
            student.Evaluation = 3;

            student.Evaluate(6);
            Assert.AreEqual(student.Evaluation, 5);
        }

        [TestMethod]
        public void Student_ReadFromData()
        {
            Student testExc = students.ReadFromData("ime@abv.bg", "123456");
            Assert.AreEqual(testExc.FirstName, "ime");
            Assert.AreEqual(testExc.LastName, "ime3");
            Assert.AreEqual(testExc.Email, "ime@abv.bg");
            Assert.AreEqual(testExc.PhoneNumber, "0999838283");
            Assert.AreEqual(testExc.Password, "123456");
        }

        [TestMethod]
        public void Student_ReadStudents()
        {
            List<Student> listSt = students.StudentsCollection();
            Assert.IsTrue(listSt.Count > 0);
        }


        public Student StudentData()
        {
            return students.ReadFromData("testonly@abv.bg", "12test");
        }

        [TestMethod]
        public void Student_Update_Grade()
        {
            Student testStudent = StudentData();
            testStudent.Evaluate(6);
            students.UpdateStudent(testStudent.Evaluation, testStudent.Email);
            testStudent = StudentData();
            Assert.AreEqual(testStudent.Evaluation, 6);
        }
        [TestMethod]
        public void Student_CheckForExistingStudent()
        {
            Assert.IsTrue(students.CheckForStudent("ime@abv.bg"));
        }

        [TestMethod]
        public void Student_CheckForNonExistingStudent()
        {
            Assert.IsFalse(students.CheckForStudent("nesushtestvuvashEmail@abv.com"));
        }

        [TestMethod]
        public void Student_CheckForNonExistingStudentPhoneNumber()
        {
            Assert.IsFalse(students.CheckForStudentPhoneNumber("123tel"));
        }

        [TestMethod]
        public void Student_CheckForExistingStudentPhoneNumber()
        {
            Assert.IsTrue(students.CheckForStudentPhoneNumber("0893924342"));
        }

        [TestMethod]
        public void Student_CheckForNonExistingStudentFacultyNumber()
        {
            Assert.IsFalse(students.CheckForStudentFacultyNumber(123));
        }

        [TestMethod]
        public void Student_CheckForExistingStudentFacultyNumber()
        {
            Assert.IsTrue(students.CheckForStudentFacultyNumber(471234));
        }
    }
}
