using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using STProject.Core;

namespace UnitTestProgram
{
    [TestClass]
    public class UnitTestNews
    {
        
        private News validNew = new News("name", "information");

        /// <summary>
        /// Метода проверява дали името и информацията дали са празни полета!
        /// </summary>
        /// <param name="name">Име на заглавието за новината</param>
        /// <param name="information">Информация за новината</param>
        [DataTestMethod]
        [DataRow(" ", "information")]
        [DataRow(null, "information")]
        [DataRow("name", " ")]
        [DataRow("name", null)]
        public void News_Exception_InitialisationsNameNull(string name,string information)
        {
            Assert.ThrowsException<ArgumentException>(()=>new News(name,information));
        }
       /// <summary>
       /// Метода инициализира конструктура и проверява резултатите дали съвпадат
       /// </summary>
        [TestMethod]
        public void News_Complete()
        {
            News news = new News(validNew.Name, validNew.Information);
            Assert.AreEqual(news.Name,validNew.Name);
            Assert.AreEqual(news.Information, validNew.Information);
        }
        /// <summary>
        /// Метода проверява дали новината е различна от нула(т.е дали е създадена)
        /// </summary>
        [TestMethod]
        public void News_DrawNews()
        {
            var textNews = validNew.DrawNews();
            Assert.IsNotNull(textNews);
        }

        /// <summary>
        /// Метода проверява дали новината се чете коректно
        /// </summary>
        [TestMethod]
        public void News_ReadNews()
        {
            List<News> textNews = validNew.ReadNews();
            Assert.IsNotNull(textNews);
            Assert.IsTrue(textNews.Count > 0);
        }

        /// <summary>
        /// Метода проверява дали новината е null
        /// </summary>
        [TestMethod]
        public void News_CheckForNonExistingNew()
        {
            Assert.IsFalse(validNew.checkForNews(validNew));
        }
      
        private News mockExistingNew()
        {
            return new News("Иновация", "News add");
        }
        /// <summary>
        /// Метода проверява дали новината съществува
        /// </summary>
        [TestMethod]
        public void News_CheckForExistingNew()
        {
            Assert.IsTrue(validNew.checkForNews(mockExistingNew()));
        }
        /// <summary>
        /// Метода проверява дали  съществува дадената информация
        /// </summary>
        [TestMethod]
        public void News_CheckForExistingNewName()
        {
            News newCheck = mockExistingNew();
            newCheck.Information = "Фалшива информация, която не съществува!?!?";
            Assert.IsTrue(validNew.checkForNews(newCheck));
        }

        [TestMethod]
        /// <summary>
        /// Метода проверява дали новината съществува даденото име
        /// </summary>
        public void News_CheckForExistingNewInformation()
        {
            News newCheck = mockExistingNew();
            newCheck.Name = "Фалшиво име, което не съществува!?!?";
            Assert.IsTrue(validNew.checkForNews(newCheck));
        }

        /// <summary>
        /// Метода сортира новините във възходящ ред(Последната добавена е първа)
        /// </summary>
        [TestMethod]
        public void News_ReverseNews()
        {
            List<News> reverseList = new List<News>();
            reverseList.Add(validNew);
            News newCheck = mockExistingNew();
            reverseList.Add(newCheck);
            News new3 = new News("Name3", "Information3");
            reverseList.Add(new3);
            reverseList = validNew.reverseNews(reverseList);
            Assert.AreEqual(reverseList[0].Name, new3.Name);
            Assert.AreEqual(reverseList[0].Information, new3.Information);
            Assert.AreEqual(reverseList[1].Name, newCheck.Name);
            Assert.AreEqual(reverseList[1].Information, newCheck.Information);
            Assert.AreEqual(reverseList[2].Name, validNew.Name);
            Assert.AreEqual(reverseList[2].Information, validNew.Information);
        }
    }
}
