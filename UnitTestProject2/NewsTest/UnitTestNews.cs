using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using STProject.Core;

namespace UnitTestProgram
{
    [TestClass]
    public class UnitTestNews
    {
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
       

    }
}
