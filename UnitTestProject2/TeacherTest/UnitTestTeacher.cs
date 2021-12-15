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
        /// <summary>
        /// Метода проверява дали учителя се инициализира според задедните параметри
        /// </summary>
        [TestMethod]
        public void Teacher_Exception_Initialisations()
        {
            Teacher teacher = new Teacher();
            Assert.ThrowsException<ArgumentException>(() => teacher.AdminNumber = -1);//Административния номер не може да бъде по-малък от 1000
            Assert.ThrowsException<ArgumentException>(() => teacher.AdminNumber = 50000);// Административния номер не може да бъде по-голям от 2000
            Assert.ThrowsException<ArgumentException>(() => teacher.Password = "");//Паролата не може да бъде празна
            teacher.Password = "1234t56";
            Assert.ThrowsException<ArgumentException>(() => teacher.VerifyPassword = "3456788");//Паролата трябва да бъде еднаква
            Assert.ThrowsException<ArgumentException>(() => teacher.FirstName = "");//Името не може да бъде празно
            Assert.ThrowsException<ArgumentException>(() => teacher.LastName = "");//Фамилията не може да бъде празна
            Assert.ThrowsException<ArgumentException>(() => teacher.Email = "");//Email-a не може да бъде празeн
            Assert.ThrowsException<ArgumentException>(() => teacher.PhoneNumber = "hjklfd123");// Телефония номер трябва да бъде валиден
        }
        /// <summary>
        /// Метода проверява дали данните са прочетени правилно от базата
        /// </summary>
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
        /// <summary>
        /// Метода проверява дали броя на учителите е по-голям от нула
        /// </summary>
        [TestMethod]
        public void Teacher_ReadTeachers()
        {
            List<Teacher> listTc = teachers.TeachersCollection();
            Assert.IsTrue(listTc.Count > 0);
        }
        /// <summary>
        /// Метода проверява дали съществува учител с текущият еmail
        /// </summary>
        [TestMethod]
        public void Teacher_CheckForExistingTeacher()
        {
            Assert.IsTrue(teachers.CheckForTeacher("imel@abv.bg"));
        }
        /// <summary>
        /// Метода проверява дали НЕ съществува учител с текущият еmail
        /// </summary>
        [TestMethod]
        public void Teacher_CheckForNonExistingTeacher()
        {
            Assert.IsFalse(teachers.CheckForTeacher("nesushtestvuvashEmail@abv.com"));
        }
        /// <summary>
        /// Метода проверява дали не съществува учител с даденият админ. номер
        /// </summary>
        [TestMethod]
        public void Teacher_CheckForNonExistingTeacherAdminNumber()
        {
            Assert.IsFalse(teachers.CheckForTeacherAdminNumber(456789));
        }
        /// <summary>
        /// Метода проверява дали съществува учител с даденият админ. номер
        /// </summary>
        [TestMethod]
        public void Teacher_CheckForExistingTeacherAdminNumber()
        {
            Assert.IsTrue(teachers.CheckForTeacherAdminNumber(1234));
        }
        /// <summary>
        /// Метода проверява дали Не съществува учител с даденият Телефонен номер
        /// </summary>
        [TestMethod]
        public void Teacher_CheckForNonExistingTeacherPhoneNumber()
        {
            Assert.IsFalse(teachers.CheckForTeacherPhoneNumber("123tel"));
        }
        /// <summary>
        /// Метода проверява дали съществува учител с даденият Телефонен номер
        /// </summary>
        [TestMethod]
        public void Teacher_CheckForExistingTeacherPhoneNumber()
        {
            Assert.IsTrue(teachers.CheckForTeacherPhoneNumber("0899999999"));
        }
    }
}
