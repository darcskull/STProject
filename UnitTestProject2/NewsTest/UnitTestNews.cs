using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using STProject.Core;

namespace UnitTestProgram
{
    [TestClass]
    public class UnitTestNews
    {
        private News validNew = new News("name", "information");

        [TestMethod]
        public void News_Exception_InitialisationsNameNull()
        {
            Assert.ThrowsException<ArgumentException>(()=>new News(null,"Information"));//Името не може да бъде null
        }
        [TestMethod]
        public void News_Exception_InitialisationsNameSpace()
        {
            Assert.ThrowsException<ArgumentException>(() => new News(" ", "Information"));//Името не може да бъде празен интервал
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
            var textNews = validNew.ReadNews();
            Assert.IsNotNull(textNews);
        }
    }
}
