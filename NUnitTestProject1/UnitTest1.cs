using NUnit.Framework;
using STProject.Core;
using System;

namespace NUnitTest
{
    public class Tests
    {
        private Student student;
        [SetUp]
        public void Setup()
        {
            student = new Student();
        }

        [TestCase(0)]
        [TestCase(-2)]
        [TestCase(-10)]
        public void Evaluation_StudentException(int evaluation)
        {
            Assert.Throws<ArgumentException>(() => student.Evaluation = evaluation);
        }
    }
}