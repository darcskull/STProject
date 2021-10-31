﻿using STProject.Core;
using STProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STProject.Classes
{
    public class ReviewTest: Data, ITest
    {
        private int grade;
        private int points;
        private string email;
        private string subject;
        private Questions [] questions;
        private string [] givenAnswers;

        public int Grade { get { return grade; } set { grade = value; } }
        public int Points { get { return points; } set { points = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Subject { get { return subject; } set { subject = value; } }
        public Questions [] ReviewQuestions { get { return questions;  } set { questions = value; } }
        public string [] GivenAnswers { get { return givenAnswers; } set { givenAnswers = value; } }

        public ReviewTest ( int g, int p, string e, string s, Questions[] q, string[] a)
        {
            Grade = g;
            Points = p;
            Email = e;
            Subject = s;
            ReviewQuestions = q;
            GivenAnswers = a;
        }

        public int GradeTest(Questions [] questions, string [] answers)
        {
            int result = 0;
            for (int i = 0; i<answers.Length; ++i)
            {
                if (questions[i].AnswerTrue == answers[i])
                    result++;
            }

            return result;
        }

        public void InsertTest(ReviewTest review)
        {
            conn.Open();
            string x = "";
            for (int i=0; i<review.questions.Length;++i)
            {
              x += $"'{review.questions[i].Question}','{review.questions[i].AnswerTrue}','{review.GivenAnswers[i]}',";
            }
            SqlCommand cmd = new SqlCommand($"insert into Test values('{review.Email}','{review.Grade}','{review.Subject}','{review.Points}','{x}');", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
