using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace STProject.Classes
{
    public class Person: Data
    {
        const byte ConstMin_SymbolsForPassword = 6;
        private string firstName;
        private string password;
        private string verifyPassword;
        private string lastname;
        private string phoneNumber;
        private string email;
        private string departament;
        public string VerifyPassword
        {
            get
            {
                return this.verifyPassword;
            }
            set
            {

                if (this.Password.ToString() != value)
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
                    throw new ArgumentException("Паролата не може да бъде празно!");
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
                    throw new ArgumentException("Фамилното име не може да бъде празно!");
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
                if (!Regex.Match(value, @"[0-9]{10}").Success)
                {
                    throw new ArgumentException("Телефонният номер е невалиден");
                }
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
                    throw new ArgumentException("Името не може да бъде празно!");
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
                    throw new ArgumentException("E-mail не може да завършва с точка!");
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

    }
}
