using STProject.Classes;
using STProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STProject.Core
{
   public  class Questions: Data, IQuestion
    {
        private string question;
        private string answer1;
        private string answer2;
        private string answer3;
        private string answer4;
        private string answertrue;
        private string subject;
        public string Question { get { return question; } set { question = value; } }
        public string Answer1 { get { return answer1; } set { answer1 = value; } }
        public string Answer2{ get { return answer2; } set { answer2 = value; } }
        public string Answer3 { get { return answer3; } set { answer3 = value; } }
        public string Answer4 { get { return answer4; } set { answer4 = value; } }
        public string AnswerTrue { get { return answertrue; } set { answertrue = value; } }
        public string Subject { get { return subject; } set { subject = value;  } }

        public void setAnswer(Questions q)
        {
            switch (q.AnswerTrue)
            {
                case "а":
                    q.AnswerTrue = q.Answer1;
                    break;
                case "б":
                    q.AnswerTrue = q.Answer2;
                    break;
                case "в":
                    q.AnswerTrue = q.Answer3;
                    break;
                case "г":
                    q.AnswerTrue = q.Answer4;
                    break;
                default:
                    Console.WriteLine("В записът няма отбелязана буква на отговор");
                    break;
            }
        }
        public bool checkValidQuestion(Questions q)
        {
            if (q.AnswerTrue == q.Answer1 || q.AnswerTrue == q.Answer2 || q.AnswerTrue == q.Answer3 || q.Answer4 == q.AnswerTrue)
                return true;
            return false;
        }

        public void InsertQuestion(Questions question)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand($"insert into Question values(N'{question.Question}',N'{question.Answer1}',N'{question.Answer2}',N'{question.Answer3}'," +
                $"N'{question.Answer4}',N'{question.AnswerTrue}',N'{question.Subject}');", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public bool checkForQuestion(string q, string st)
        {
            bool bol = true;
            try
            {
                conn.Open();
                string sql = "SELECT * FROM Question";
                var cmd = new SqlCommand(sql, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    if (rdr.GetValue(1).ToString() == q && st == rdr.GetValue(7).ToString())
                    {
                        bol = false;
                    }
                }
            }
            catch(Exception exc)
            {
                Console.WriteLine("Грешка при търсене на въпрос: " + exc.Message);
            }

            conn.Close();
            return bol;
        }
    }
}
