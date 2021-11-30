using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using STProject.Core;

namespace UnitTestProgram
{
    [TestClass]
    public class UnitTestQueestions
    {
        private Questions question = new Questions();

        [TestMethod]
        public void Questions_SetAnswerA()
        {
            Questions quest = new Questions();
            MockQuestion(quest);
            quest.AnswerTrue = "а";
            question.setAnswer(quest);
            Assert.AreEqual(quest.AnswerTrue, quest.Answer1);
        }

        public void MockQuestion(Questions qq)
        {
            qq.Question = "question";
            qq.Answer1 = "answer1";
            qq.Answer2 = "answer2";
            qq.Answer3 = "answer3";
            qq.Answer4 = "answer4";
            qq.Subject = "Математика";
        }

        [TestMethod]
        public void Questions_SetAnswerB()
        {
            Questions quest = new Questions();
            MockQuestion(quest);
            quest.AnswerTrue = "б";
            question.setAnswer(quest);
            Assert.AreEqual(quest.AnswerTrue, quest.Answer2);
        }

        [TestMethod]
        public void Questions_SetAnswerC()
        {
            Questions quest = new Questions();
            MockQuestion(quest);
            quest.AnswerTrue = "в";
            question.setAnswer(quest);
            Assert.AreEqual(quest.AnswerTrue, quest.Answer3);
        }

        [TestMethod]
        public void Questions_SetAnswerD()
        {
            Questions quest = new Questions();
            MockQuestion(quest);
            quest.AnswerTrue = "г";
            question.setAnswer(quest);
            Assert.AreEqual(quest.AnswerTrue, quest.Answer4);
        }

        [TestMethod]
        public void Questions_CheckValidQuestion()
        {
            Questions quest = new Questions();
            MockQuestion(quest);
            quest.AnswerTrue = quest.Answer1;
            bool condition = question.checkValidQuestion(quest);
            Assert.IsTrue(condition);
        }

        [TestMethod]
        public void Questions_CheckValidQuestion_False()
        {
            Questions quest = new Questions();
            MockQuestion(quest);
            quest.AnswerTrue = "qqqqq";
            bool condition = question.checkValidQuestion(quest);
            Assert.IsFalse(condition);
        }

        [TestMethod]
        public void Questions_SetAnswer_CheckValidQuestion()
        {
            Questions quest = new Questions();
            MockQuestion(quest);
            quest.AnswerTrue = "г";
            question.setAnswer(quest);
            bool condition = question.checkValidQuestion(quest);
            Assert.IsTrue(condition);
        }

        [TestMethod]
        public void Questions_Exit_False()
        {
            Questions quest = new Questions();
            MockQuestion(quest);
            quest.Question = "въпрос. който не съществува????";
            bool condition = question.checkForQuestion(quest.Question, quest.Subject);
            Assert.IsTrue(condition);
        }

        [TestMethod]
        public void Questions_Exit_True()
        {
            Questions quest = new Questions();
            quest.Question = "тест";
            quest.Subject = "САА";
            bool condition = question.checkForQuestion(quest.Question, quest.Subject);
            Assert.IsFalse(condition);
        }

        [TestMethod]
        public void Questions_ReadAllQuestions()
        {
            var readText = question.readQuestions("Математика");
            Assert.IsNotNull(readText);
        }

        [TestMethod]
        public void Questions_ReadAllQuestions_Empty()
        {
            List<Questions> readText = question.readQuestions(" ");
            Assert.AreEqual(readText.Count, 0);
        }
    }
}
