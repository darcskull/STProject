using STProject.Classes;
using STProject.Interfaces;
using System;
using System.Data.SqlClient;

namespace STProject.Core
{
    public class Teacher: Student, ITeacher
    {
        const int ConstFackNumberbettwenFirst = 1000;
        const int ConstFackNumberbettwenSecond = 2000;
        private int adminNumber;

        public int AdminNumber
        {
            get
            {
                return this.adminNumber;
            }
            set
            {
                if (value < ConstFackNumberbettwenFirst || value > ConstFackNumberbettwenSecond)
                {
                    throw new ArgumentException("Факултетният номер трябва да е между 1000 и 2000");
                }
                
                this.adminNumber = value;
            }
        }

        public void InsertTeacher(Teacher teacher)
           {
               conn.Open();
               SqlCommand cmd = new SqlCommand($"insert into Teacher values('{teacher.Email}','{teacher.Password}',N'{teacher.FirstName}',N'{teacher.LastName}'," +
                   $"N'{teacher.Departament}','{teacher.PhoneNumber}','{teacher.AdminNumber}');", conn);
               cmd.ExecuteNonQuery();
               conn.Close();
           }
    }
}
