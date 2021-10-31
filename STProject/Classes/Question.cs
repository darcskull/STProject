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

        public Questions (string q, string a1, string a2, string a3, string a4, string at)
        {
            Question = q;
            Answer1 = a1;
            Answer2 = a2;
            Answer3 = a3;
            Answer4 = a4;
            AnswerTrue = at;
        }

        public void InsertQuestion(Questions question)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand($"insert into Question values('{question.Question}','{question.Answer1}','{question.Answer2}','{question.Answer3}'," +
                $"'{question.Answer4}','{question.AnswerTrue}','{question.Subject}');", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
