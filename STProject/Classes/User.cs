using STProject.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace STProject.Classes
{
    public class User: Data
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
                    throw new ArgumentException(ExceptionMessages.NoMatchPassword);
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
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPassword);
                }
                if (value.Length < ConstMin_SymbolsForPassword)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPasswordLenght) ;
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
                    throw new ArgumentException(ExceptionMessages.InvalidFamileName);
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
                    throw new ArgumentException(ExceptionMessages.InvalidPhoneNumber);
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
                    throw new ArgumentException(ExceptionMessages.InvalidFirstName);
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
                    throw new ArgumentException(ExceptionMessages.InvalidEmeilDotsFinal);
                }
                try
                {
                    var addr = new MailAddress(value);
                }
                catch
                {

                    throw new ArgumentException(ExceptionMessages.InvalidEmail);
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
