using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STProject.Models.User.Contracts
{
    public interface IUser
    {
        string VerifyPassword { get; set; }
        string Password { get; set; }
        string LastName { get; set; }
        string PhoneNumber { get; set; }
        string FirstName { get; set; }
        string Email { get; set; }
        string Departament { get; set; }

    }
}
