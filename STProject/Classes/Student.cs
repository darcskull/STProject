using STProject.Classes;
using STProject.Interfaces;
using System;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace STProject.Core
{
    public  class Student: Data, IStudent
    {
        const byte ConstMin_SymbolsForPassword = 6;
        const int ConstFackNumberbettwenFirst = 470000;
        const int ConstFackNumberbettwenSecond = 480000;
        private string firstName;
        private string password;
        private string verifyPassword;
        private string lastname;
        private string phoneNumber;
        private string email;
        private string departament;
        private int facultyNumber;
        private int evaluation;
        public string VerifyPassword
        {
            get
            {
                return this.verifyPassword;
            }
            set
            {
                
                if(this.Password.ToString() != value)
                {
                    throw new ArgumentException("Парололите не съвпадат");
                }
                this.verifyPassword = value;
            }
        }
        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Паролата не може да бъде null или празно!");
                }
                if (value.Length < ConstMin_SymbolsForPassword)
                {
                    throw new ArgumentException("Паролата не може да бъде по малка от 6 символа!");
                }
               

                this.password = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastname;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Фамилното име не може да бъде null или празно!");
                }
                this.lastname = value;
            }
         }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Телефонният номер е празен или не пълен!");
                }
                if (!Regex.Match(value, @"[0-9]{10}").Success)
                {
                    throw new ArgumentException("Телефонният номер е невалиден");
                }
                this.phoneNumber = value ;
            }
        }

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
                    throw new ArgumentException("Оценката трябва да е по голяма или равна на 2!");
                }
                this.evaluation = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Името не може да бъде null или празно!");
                }
                this.firstName = value;
            }
        }
       

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (value.Trim().EndsWith("."))
                {
                    throw new ArgumentException("E-mail не може да завършва на точка!");
                }
                try
                {
                    var addr = new MailAddress(value);
                }
                catch 
                {

                    throw new ArgumentException("Невалиден Email");
                }

                this.email = value;
            }
        }

        public string Departament
        {
            get
            {
                return this.departament;
            }
            set
            {
               
                this.departament = value;
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
                    throw new ArgumentException("Факултетният номер трябва да е между 470000 и 480000");
                }
                this.facultyNumber = value;
            }
        }

        public void Evaluate(int grade)
        {
            if (Evaluation == 0)
                Evaluation = grade;
            else
                Evaluation = (Evaluation + grade) / 2;
        }
        public void InsertStudent(Student student)
          {
              conn.Open();
            SqlCommand cmd = new SqlCommand($"insert into Students values(N'{student.FirstName}',N'{student.LastName}',N'{student.Email}',N'{student.Departament}',N'{student.Evaluation}',N'{student.Password}',N'{student.FacultyNumber}',N'{student.PhoneNumber}');", conn);
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
                string emailTEST = rdr.GetValue(3).ToString();
                string passTEST = rdr.GetValue(6).ToString();
                ;
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

                    break;
                }
                else
                {
                    student = null;
                }

            }

            conn.Close();
            return student;
        }
    }
}
