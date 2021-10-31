﻿using System;

namespace STProject.Core
{
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
                return this.lastname;
            }
            set
            {
                
                this.lastname = value;
            }
        }

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
        
        public Student ( string fn, string ln, string e, string p, int fnumber, string d, string pn, float ev)
        {
            FirstName = fn;
            LastName = ln;
            Email = e;
            Password = p;
            FacultyNumber = fnumber;
            Departament = d;
            PhoneNumber = pn;
            Evaluation = ev;
        }

        public void Evaluate(int grade)
        {
            if (Evaluation == 0)
                Evaluation = grade;
            else
                Evaluation = (Evaluation + grade) / 2;
        }
    }
}
