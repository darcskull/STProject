using STProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STProject.Interfaces
{
    public interface IQuestion
    {
        string Question { get; set; }
          string Answer1 { get; set; }
        string Answer2 { get; set; }
        string Answer3 { get; set; }
        string Answer4 { get; set; }
        string AnswerTrue { get; set; }
        string Subject { get; set; }
        void setAnswer(Questions q);
        bool checkValidQuestion(Questions q);
        bool checkForQuestion(string q, string st);
        List<Questions> readQuestions(string subject);
        void InsertQuestion(Questions question);
    }
}
