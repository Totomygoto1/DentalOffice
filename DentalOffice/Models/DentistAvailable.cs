using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentalOffice.Models
{
    public class DentistAvailable
    {
        public int dentistavailableID { get; set; }
        public int dentistID { get; set; }
        public DateTime fromDatetime { get; set; }
        public DateTime toDatetime { get; set; }
        public Dentist Dentist { get; set; }

    }
}
