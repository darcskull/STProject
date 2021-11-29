using STProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STProject.Interfaces
{
    public interface IStudent
    {
        void InsertStudent(Student student);
        int Evaluation { get; set; }
        int FacultyNumber { get; set; }
        void Evaluate(int grade);

        void UpdateStudent(int evaluation, string email);
        Student ReadFromData(string email, string password);
        List<Student> StudentsCollection();
    }
}
