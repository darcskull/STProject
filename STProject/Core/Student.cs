using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace STProject.Core
{
    [Table("Student")]
    public  class Student
    {
        const byte ConstMin_SymbolsForPassword = 6;
        private string firstName;
        private int id;
        private string password;
        private string lastname;
        private string phoneNumber;
        private string email;
        private string departament;
        private int facultyNumber;
        private float evaluation;

        [System.Data.Linq.Mapping.Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID 
        {
            get
            {
                return this.id;
            }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Id cannot be zero or negative!");
                }
                this.id = value;
            }
        }
        [System.Data.Linq.Mapping.Column(IsPrimaryKey = true, IsDbGenerated = true)]
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
                if (value.Length< ConstMin_SymbolsForPassword)
                {
                    throw new ArgumentException("Password cannot be less than six symbols");
                }
                this.password = value;
            }
        }
        [System.Data.Linq.Mapping.Column(IsPrimaryKey = true, IsDbGenerated = true)]
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
        [System.Data.Linq.Mapping.Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public string PhoneNumber
        {
            get
            {
                return this.lastname;
            }
            set
            {
                
                this.lastname = value;
            }
        }
        [System.Data.Linq.Mapping.Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public float Evaluation
        {
            get
            {
                return this.evaluation;
            }
            set
            {

                this.evaluation = value;
            }
        }
        [System.Data.Linq.Mapping.Column(IsPrimaryKey = true, IsDbGenerated = true)]
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
        [System.Data.Linq.Mapping.Column(IsPrimaryKey = true, IsDbGenerated = true)]
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
        [System.Data.Linq.Mapping.Column(IsPrimaryKey = true, IsDbGenerated = true)]
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
        [System.Data.Linq.Mapping.Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {

                this.facultyNumber = value;
            }
        }
        
    }
}
