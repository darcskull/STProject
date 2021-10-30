using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STProject.Core
{
    public class Teacher
    {
        private string name;

        [System.Data.Linq.Mapping.Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID { get; set; }
        public string Password { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int AdminNumber { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Departament { get; set; }
        
    }
}
