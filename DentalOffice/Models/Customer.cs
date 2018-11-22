using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentalOffice.Models
{
    public class Customer
    {
        public int customerID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string SocialSecurity { get; set; }

        public ICollection<Visit> Visits { get; set; }
    }
}
