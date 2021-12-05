using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using STProject.Core;

namespace UnitTestProgram
{
    [TestClass]
    public class UnitTestTeacher
    {
        Teacher teachers = new Teacher();
        [TestMethod]
        public void Teacher_Exception_Initialisations()
        {
            Teacher teacher = new Teacher();
            Assert.ThrowsException<ArgumentException>(() => teacher.AdminNumber = -1);//Административния номер не може да бъде по-малък от 1000
            Assert.ThrowsException<ArgumentException>(() => teacher.AdminNumber = 50000);// Административния номер не може да бъде по-голям от 2000
            Assert.ThrowsException<ArgumentException>(() => teacher.Password = "");//Паролата не може да бъде празна
            teacher.Password = "1234t56";
            Assert.ThrowsException<ArgumentException>(() => teacher.VerifyPassword= "3456788");//Паролата трябва да бъде еднаква
            Assert.ThrowsException<ArgumentException>(() => teacher.FirstName = "");//Името не може да бъде празно
            Assert.ThrowsException<ArgumentException>(() => teacher.LastName = "");//Фамилията не може да бъде празна
            Assert.ThrowsException<ArgumentException>(() => teacher.Email = "");//Email-a не може да бъде празeн
            Assert.ThrowsException<ArgumentException>(() => teacher.PhoneNumber = "hjklfd123");// Телефония номер трябва да бъде валиден
        }

        [TestMethod]
        public void Teacher_ReadFromData()
        {
            Teacher testExc = teachers.ReadFromData("abv@abv.bg", "123456");
            Assert.AreEqual(testExc.FirstName, "ime");
            Assert.AreEqual(testExc.LastName, "imel");
            Assert.AreEqual(testExc.Email, "abv@abv.bg");
            Assert.AreEqual(testExc.PhoneNumber, "0889234567");
            Assert.AreEqual(testExc.Password, "123456");
        }

        [TestMethod]
        public void Teacher_ReadTeachers()
        {
            List<Teacher> listTc = teachers.TeachersCollection();
            Assert.IsTrue(listTc.Count > 0);
        }
    }
}
