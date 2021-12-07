using STProject.Classes;
using STProject.Interfaces;
using STProject.Messages;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace STProject.Core
{
    public  class Student: User, IStudent
    {
        const int ConstFackNumberbettwenFirst = 470000;
        const int ConstFackNumberbettwenSecond = 480000;
        private int facultyNumber;
        private int evaluation;

        public int Evaluation
        {
            get
            {
                return this.evaluation;
            }
            set
            {
                if (value < 2)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidEvaluation);
                }
                this.evaluation = value;
            }
        }

        public int FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
               
                if (value < ConstFackNumberbettwenFirst || value > ConstFackNumberbettwenSecond)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidFacultyNumber);
                }
                this.facultyNumber = value;
            }
        }

        public void Evaluate(int grade)
        {
            int gradee = Evaluation + grade;
            if (Evaluation == 2)
                Evaluation = grade;
            else
                Evaluation = gradee / 2 + gradee % 2;
        }
        public void InsertStudent(Student student)
          {
            conn.Open();
            SqlCommand cmd = new SqlCommand($"insert into Students values(N'{student.FirstName}',N'{student.LastName}',N'{student.Email}',N'{student.Departament}',N'{student.Evaluation}',N'{student.Password}',N'{student.FacultyNumber}',N'{student.PhoneNumber}');", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateStudent(int evaluation, string email)
        { 
            SqlCommand cmd = new SqlCommand("UPDATE Students SET Evaluation = @evaluation Where Email = @email", conn);
            cmd.Parameters.AddWithValue("@evaluation", evaluation);
            cmd.Parameters.AddWithValue("@email", email);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public Student ReadFromData(string email, string password)
        {
            conn.Open();
            string sql = "SELECT * FROM Students";
            var cmd = new SqlCommand(sql, conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            var student = new Student();
            while (rdr.Read())
            {
                if (rdr.GetValue(3).ToString() == email && rdr.GetValue(6).ToString() == password)
                {
                    student.FirstName = rdr.GetValue(1).ToString();
                    student.LastName = rdr.GetValue(2).ToString();
                    student.Email = rdr.GetValue(3).ToString();
                    student.Departament = rdr.GetValue(4).ToString();
                    student.Evaluation = int.Parse(rdr.GetValue(5).ToString());
                    student.Password = rdr.GetValue(6).ToString();
                    student.FacultyNumber = int.Parse(rdr.GetValue(7).ToString());
                    student.PhoneNumber = rdr.GetValue(8).ToString();
                    conn.Close();
                    return student;
                }
            }
            conn.Close();
            return null;
        }
        public bool CheckForStudent(string email)
        {
            bool bol = false;
            conn.Open();
            string sql = "SELECT * FROM Students";
            var cmd = new SqlCommand(sql, conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (rdr.GetValue(3).ToString() == email)
                {
                    bol = true;
                }
            }
            conn.Close();
            return bol;
        }

        public List<Student> StudentsCollection()
        {
            conn.Open();
            string sql = "SELECT * FROM Students";
            var cmd = new SqlCommand(sql, conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            
            var list = new List<Student>();
            while (rdr.Read())
            {
                var student = new Student();
                student.FirstName = rdr.GetValue(1).ToString();
                student.LastName = rdr.GetValue(2).ToString();
                student.Email = rdr.GetValue(3).ToString();
                student.Departament = rdr.GetValue(4).ToString();
                student.Evaluation = int.Parse(rdr.GetValue(5).ToString());
                student.Password = rdr.GetValue(6).ToString();
                student.FacultyNumber = int.Parse(rdr.GetValue(7).ToString());
                student.PhoneNumber = rdr.GetValue(8).ToString();
                list.Add(student);

            }
            conn.Close();
            return list;
        }
    }
}
