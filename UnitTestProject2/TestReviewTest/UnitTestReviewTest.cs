using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using STProject.Classes;
using STProject.Core;

namespace UnitTestProgram
{
    [TestClass]
    public class UnitTestReviewTest
    {
        private ReviewTest revview = new ReviewTest();

        [TestMethod]
        public void Read_From_Data()
        {
            List<ReviewTest> listReview = revview.readForReview("testonly@abv.bg", "СТ");
            Assert.IsTrue(listReview.Count > 0);
        }
    }
}
