using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentalOffice.Models
{
    public class Visit
    {
        public int visitID { get; set; }
        public int customerID { get; set; }
        public int dentistID { get; set; }
        public DateTime visitDate { get; set; }
        public string notes { get; set; }
        public string image1 { get; set; }
        public string image2 { get; set; }
        public string image3 { get; set; }
        public string author { get; set; }
        public Customer Customer { get; set; }
        public Dentist Dentist { get; set; }
    }
}
