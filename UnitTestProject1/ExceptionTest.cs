using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using STProject.Core;
using Assert = NUnit.Framework.Assert;

namespace UnitTestProject1
{
    [TestClass]
    public class ExceptionTest
    {
        private Student student;
        [SetUp]
        public void SetUp()
        {
          student = new Student();
        }
        [Test]
        public void TestMethod1()
        {
            
            Assert.Throws<ArgumentException>(() => student.Evaluation = -4);
        }
    }
}
