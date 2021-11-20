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

        //TODO check if exist + update older results
        public void InsertTest(ReviewTest review)
        {
            conn.Open();
            string x = "";
            for (int i=0; i<review.questions.Length;++i)
            {
              x += $"N'{review.questions[i].Question}',N'{review.questions[i].AnswerTrue}',N'{review.GivenAnswers[i]}',";
            }
            SqlCommand cmd = new SqlCommand($"insert into Test values(N'{review.Email}',N'{review.Grade}',N'{review.Subject}',N'{review.Points}','{x}');", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public ReviewTest readForReview(string email, string subject)
        {
            ReviewTest review = new ReviewTest();
            var cmd = new SqlCommand("SELECT * FROM Test WHERE Email = @email, Predmet = @sub", conn);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@sub", subject);
            try
            {
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    if (rdr.GetValue(1).ToString() == email && subject == rdr.GetValue(3).ToString())
                    {
                        review.Email = rdr.GetValue(1).ToString();
                        review.Grade = int.Parse(rdr.GetValue(2).ToString());
                        review.Subject = rdr.GetValue(3).ToString();
                        review.Points = int.Parse(rdr.GetValue(4).ToString());
                        for(int i=5; i<30; i += 3)
                        {
                            review.questions[i].Question = rdr.GetValue(i).ToString();
                            review.questions[i].AnswerTrue = rdr.GetValue(i + 1).ToString();
                            review.givenAnswers[i] = rdr.GetValue(i+2).ToString();
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("Грешка при търсене на тест: " + exc.Message);
            }

            conn.Close();
            return review;
        }
    }
}
