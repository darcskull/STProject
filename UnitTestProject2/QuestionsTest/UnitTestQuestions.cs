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
        /// <summary>
        /// Проверява дали отговора е правилният отговор "a"
        /// </summary>
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
        /// <summary>
        /// Проверява дали отговора е правилният отговор "b"
        /// </summary>
        [TestMethod]
        public void Questions_SetAnswerB()
        {
            Questions quest = new Questions();
            MockQuestion(quest);
            quest.AnswerTrue = "б";
            question.setAnswer(quest);
            Assert.AreEqual(quest.AnswerTrue, quest.Answer2);
        }
        /// <summary>
        /// Проверява дали отговора е правилният отговор "c"
        /// </summary>
        [TestMethod]
        public void Questions_SetAnswerC()
        {
            Questions quest = new Questions();
            MockQuestion(quest);
            quest.AnswerTrue = "в";
            question.setAnswer(quest);
            Assert.AreEqual(quest.AnswerTrue, quest.Answer3);
        }

        /// <summary>
        /// Проверява дали отговора е правилният отговор "d"
        /// </summary>
        [TestMethod]
        public void Questions_SetAnswerD()
        {
            Questions quest = new Questions();
            MockQuestion(quest);
            quest.AnswerTrue = "г";
            question.setAnswer(quest);
            Assert.AreEqual(quest.AnswerTrue, quest.Answer4);
        }
        /// <summary>
        /// Проверява дали избраният отговор е правилен
        /// </summary>
        [TestMethod]
        public void Questions_CheckValidQuestion()
        {
            Questions quest = new Questions();
            MockQuestion(quest);
            quest.AnswerTrue = quest.Answer1;
            bool condition = question.checkValidQuestion(quest);
            Assert.IsTrue(condition);
        }
        /// <summary>
        /// Проверява дали избраният отговор е грешен
        /// </summary>
        [TestMethod]
        public void Questions_CheckValidQuestion_False()
        {
            Questions quest = new Questions();
            MockQuestion(quest);
            quest.AnswerTrue = "qqqqq";
            bool condition = question.checkValidQuestion(quest);
            Assert.IsFalse(condition);
        }
        /// <summary>
        /// Проверява дали избраният отговор е правилен
        /// </summary>
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
        /// <summary>
        /// Проверява дали въпроса не съществува
        /// </summary>
        [TestMethod]
        public void Questions_Exits_False()
        {
            Questions quest = new Questions();
            MockQuestion(quest);
            quest.Question = "въпрос. който не съществува????";
            bool condition = question.checkForQuestion(quest.Question, quest.Subject);
            Assert.IsTrue(condition);
        }
        /// <summary>
        /// Проверява дали въпроса съществува
        /// </summary>
        [TestMethod]
        public void Questions_Exits_True()
        {
            Questions quest = new Questions();
            quest.Question = "тест";
            quest.Subject = "САА";
            bool condition = question.checkForQuestion(quest.Question, quest.Subject);
            Assert.IsFalse(condition);
        }
        /// <summary>
        /// Проверява дали списъка с въпроси  не е null (т.е дали е инициализиран правилно)
        /// </summary>
        [TestMethod]
        public void Questions_ReadAllQuestions()
        {
            var readText = question.readQuestions("Математика");
            Assert.IsNotNull(readText);
        }
        /// <summary>
        /// Проверява дали списъка с въпроси  не е празно място
        /// </summary>
        [TestMethod]
        public void Questions_ReadAllQuestions_Empty()
        {
            List<Questions> readText = question.readQuestions(" ");
            Assert.AreEqual(readText.Count, 0);
        }
    }
}
