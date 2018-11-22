using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentalOffice.Models
{
    public class Login
    {
        public int loginID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
