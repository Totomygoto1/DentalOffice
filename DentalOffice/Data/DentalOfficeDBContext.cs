using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DentalOffice.Models
{
    public class DentalOfficeDBContext : DbContext
    {
        public DentalOfficeDBContext (DbContextOptions<DentalOfficeDBContext> options)
            : base(options)
        {
        }

        public DbSet<DentalOffice.Models.Customer> Customer { get; set; }
        public DbSet<DentalOffice.Models.Dentist> Dentist { get; set; }
        public DbSet<DentalOffice.Models.Visit> Visit { get; set; }
        public DbSet<DentalOffice.Models.Login> Login { get; set; }
        public DbSet<DentalOffice.Models.DentistAvailable> DentistAvailable { get; set; }

    }
}
