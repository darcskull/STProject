using STProject.Classes;
using STProject.Interfaces;
using System;
using System.Data.SqlClient;

namespace STProject.Core
{
    public class Teacher: Data, ITeacher
    {
        const byte ConstMin_SymbolsForPassword = 6;
        private string firstName;
        private string password;
        private string lastname;
        private string phoneNumber;
        private string email;
        private string departament;
        private int adminNumber;

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
                    throw new ArgumentException("Password cannot be null or empty!");
                }
                if (value.Length < ConstMin_SymbolsForPassword)
                {
                    throw new ArgumentException("Password cannot be less than six symbols");
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
                    throw new ArgumentException("Last name cannot be null or empty!");
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

                this.phoneNumber = value;
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
                    throw new ArgumentException("First name cannot be null or empty!");
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Departament cannot be null or empty!");
                }
                this.departament = value;
            }
        }

        public int AdminNumber
        {
            get
            {
                return this.adminNumber;
            }
            set
            {

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
