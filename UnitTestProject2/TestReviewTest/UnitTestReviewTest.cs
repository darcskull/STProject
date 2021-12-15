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
        /// <summary>
        ///  Проверява дали броят на въпросите в базата е по-голям от 0
        /// </summary>
        [TestMethod]
        public void Read_From_Data()
        {
            List<ReviewTest> listReview = revview.readForReview("testonly@abv.bg", "СТ");
            Assert.IsTrue(listReview.Count > 0);
        }
    }
}
