using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STProject.Core
{
    public  class Student
    {
        private string name;

        [System.Data.Linq.Mapping.Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID { get; set; } 
        public string Password { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public float Evaluation { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Departament { get; set; }
        public int FacultyNumber { get; set; }
        
    }
}
