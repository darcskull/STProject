using STProject.Classes;
using STProject.Interfaces;
using System;
using System.Data.SqlClient;

namespace STProject.Core
{
    public class Teacher: User, ITeacher
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
        public Teacher ReadFromData(string email, string password)
        {
            conn.Open();
            string sql = "SELECT * FROM Teacher";
            var cmd = new SqlCommand(sql, conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (rdr.GetValue(1).ToString() == email && rdr.GetValue(2).ToString() == password)
                { 
                    var teacher = new Teacher();
                    teacher.FirstName = rdr.GetValue(3).ToString();
                    teacher.LastName = rdr.GetValue(4).ToString();
                    teacher.Email = rdr.GetValue(1).ToString();
                    teacher.Departament = rdr.GetValue(5).ToString();
                    teacher.Password = rdr.GetValue(2).ToString();
                    teacher.AdminNumber = int.Parse(rdr.GetValue(7).ToString());
                    teacher.PhoneNumber = rdr.GetValue(6).ToString();
                    conn.Close();
                    return teacher;
                }
            }
            conn.Close();
            return null;
        }
    }
}
