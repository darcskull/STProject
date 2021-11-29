using STProject.Core;
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

        public void InsertTest(ReviewTest review)
        {
            conn.Open();
            if (review.questions != null)
            {
                SqlCommand cmd = new SqlCommand($"insert into Test values(N'{review.Email}',N'{review.Grade}',N'{review.Subject}',N'{review.Points}'," +
                $"N'{review.questions[0].Question}',N'{review.questions[0].AnswerTrue}',N'{review.GivenAnswers[0]}'," +
                $"N'{review.questions[1].Question}',N'{review.questions[1].AnswerTrue}',N'{review.GivenAnswers[1]}'," +
                $"N'{review.questions[2].Question}',N'{review.questions[2].AnswerTrue}',N'{review.GivenAnswers[2]}'," +
                $"N'{review.questions[3].Question}',N'{review.questions[3].AnswerTrue}',N'{review.GivenAnswers[3]}'," +
                $"N'{review.questions[4].Question}',N'{review.questions[4].AnswerTrue}',N'{review.GivenAnswers[4]}'," +
                $"N'{review.questions[5].Question}',N'{review.questions[5].AnswerTrue}',N'{review.GivenAnswers[5]}'," +
                $"N'{review.questions[6].Question}',N'{review.questions[6].AnswerTrue}',N'{review.GivenAnswers[6]}'," +
                $"N'{review.questions[7].Question}',N'{review.questions[7].AnswerTrue}',N'{review.GivenAnswers[7]}'," +
                $"N'{review.questions[8].Question}',N'{review.questions[8].AnswerTrue}',N'{review.GivenAnswers[8]}'," +
                $"N'{review.questions[9].Question}',N'{review.questions[9].AnswerTrue}',N'{review.GivenAnswers[9]}');", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            
          
          
        }

        public List<ReviewTest> readForReview(string email, string subject)
        {
            List<ReviewTest> reviewTest = new List<ReviewTest>();
            int counter = 5;
            try
            {
                conn.Open();
                string sql = "SELECT * FROM Test";
                var cmd = new SqlCommand(sql, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
               while (rdr.Read())
               {
                    if (rdr.GetValue(1).ToString() == email && subject == rdr.GetValue(3).ToString())
                    {
                        ReviewTest reviewobj = new ReviewTest();
                        reviewobj.Email = rdr.GetValue(1).ToString();
                        reviewobj.Grade = int.Parse(rdr.GetValue(2).ToString());
                        reviewobj.Subject = rdr.GetValue(3).ToString();
                        reviewobj.Points = int.Parse(rdr.GetValue(4).ToString());
                        string[] answers = new string[10];
                        Questions[] quests = new Questions[10];
                        for(int i = 0; i < 10; ++i)
                        {
                            Questions qquest = new Questions();
                            qquest.Question = rdr.GetValue(counter).ToString();
                            qquest.AnswerTrue = rdr.GetValue(counter + 1).ToString();
                            quests[i] = qquest;
                            answers[i] = rdr.GetValue(counter+2).ToString();
                            counter += 3;
                        }
                        reviewobj.ReviewQuestions = quests;
                        reviewobj.GivenAnswers = answers;
                        reviewTest.Add(reviewobj);
                    }        
               }
            }
            catch (Exception exc)
            {
                Console.WriteLine("Грешка при търсене на тест: " + exc.Message);
            }

            conn.Close();
            return reviewTest;
        }
    }
}
