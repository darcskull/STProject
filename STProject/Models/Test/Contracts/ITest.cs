using STProject.Classes;
using STProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STProject.Interfaces
{
   public interface ITest
    {
        void InsertTest(ReviewTest review);
        int Grade { get; set; }
        int Points { get; set; }
        string Email { get; set; }
        string Subject { get; set; }
        Questions[] ReviewQuestions { get; set; }
        string[] GivenAnswers { get; set; }
        List<ReviewTest> readForReview(string email, string subject);
    }
}
