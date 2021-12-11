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

        //Името и информацията не може да бъде null или white Space 
        [DataTestMethod]
        [DataRow(" ", "information")]
        [DataRow(null, "information")]
        [DataRow("name", " ")]
        [DataRow("name", null)]
        public void News_Exception_InitialisationsNameNull(string name,string information)
        {
            Assert.ThrowsException<ArgumentException>(()=>new News(name,information));
        }
       
        [TestMethod]
        public void News_Complete()
        {
            News news = new News(validNew.Name, validNew.Information);
            Assert.AreEqual(news.Name,validNew.Name);
            Assert.AreEqual(news.Information, validNew.Information);
        }

        [TestMethod]
        public void News_DrawNews()
        {
            var textNews = validNew.DrawNews();
            Assert.IsNotNull(textNews);
        }

        [TestMethod]
        public void News_ReadNews()
        {
            List<News> textNews = validNew.ReadNews();
            Assert.IsNotNull(textNews);
            Assert.IsTrue(textNews.Count > 0);
        }
    }
}
